using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{

    public partial class TetrisForm : Form
    {
        const int FIELD_WIDTH = 15;
        const int FIELD_HEIGHT = 20;
        const int DOT_SIZE = 20;
        const int DEFAULT_VALUE_OF_ARRAY = 0;
        const int INITIAL_SHAPE_SPEED = 300;
        const int LOWEST_POSSIBLE_SHAPE_SPEED = 50;
        const int STEP_OF_SHAPE_SPEED_INCREASE = 20;
        const int MOVE_TO_THE_BOTTOM_SHAPE_SPEED = 1;
        const int SCORE_PER_LINE = 100;
        int[,] fieldDotsArray;
        int score;
        bool isGameInRun;
        int currentSpeed;
        Shape currentShape;
        Shape nextShape;
        Bitmap nextShapeBitmap;
        Graphics nextShapeGraphics;

        public TetrisForm()
        {
            InitializeComponent();
            HideGamePanel();
            fieldDotsArray = new int[FIELD_WIDTH, FIELD_HEIGHT];
            TetrisTimer.Tick += new EventHandler(TetrisTickMoves);
            isGameInRun = false;
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            isGameInRun = true;
            score = 0;
            ShowGamePanel();
            FillFieldDotArrayWithDefaultValue();
            Invalidate();
            currentShape = (Shape)GetRandomShapeWithCenterAligned().Clone();
            nextShape = (Shape)GetNextShape().Clone();
            TetrisTimer.Interval = INITIAL_SHAPE_SPEED;
            TetrisTimer.Start();
            this.KeyDown += TetrisForm_KeyDown;
            this.KeyDown += PauseGame;
            ScoreLabel.Text = "Score: " + score;
        }

        private void PauseGame(object sender, KeyEventArgs e)
        {  
            switch (e.KeyCode)
            {
                case Keys.P:
                    isGameInRun = !isGameInRun;
                    if (isGameInRun)
                    {
                        TetrisTimer.Start();
                        this.KeyDown += TetrisForm_KeyDown;
                    }
                    else
                    {
                        TetrisTimer.Stop();
                        this.KeyDown -= TetrisForm_KeyDown;
                    }
                    break;

                default:
                    return;
            }
        }

        private void FillFieldDotArrayWithDefaultValue()
        {
            for (int i = 0; i < FIELD_WIDTH; i++)
            {
                for (int j = 0; j < FIELD_HEIGHT; j++)
                {
                    fieldDotsArray[i, j] = DEFAULT_VALUE_OF_ARRAY;
                }
            }
        }

        private void PaintField(object sender, PaintEventArgs e)
        {
            DrawGridOfField(e.Graphics);
            DrawShape(e.Graphics);
        }

        private void DrawGridOfField(Graphics fieldGraphics)
        {
            for (int i = 0; i <= FIELD_HEIGHT; i++)
            {
                fieldGraphics.DrawLine(Pens.Black, new Point(50, 50 + i * DOT_SIZE), new Point(50 + FIELD_WIDTH * DOT_SIZE, 50 + i * DOT_SIZE));
            }

            for (int i = 0; i <= FIELD_WIDTH; i++)
            {
                fieldGraphics.DrawLine(Pens.Black, new Point(50 + i * DOT_SIZE, 50), new Point(50 + i * DOT_SIZE, 50 + FIELD_HEIGHT * DOT_SIZE));
            }
        }

        private void DrawShape(Graphics fieldGraphics)
        {
            for (int i = 0; i < FIELD_WIDTH; i++)
            {
                for (int j = 0; j < FIELD_HEIGHT; j++)
                {
                    if (fieldDotsArray[i, j] > 0)
                        fieldGraphics.FillRectangle(ShapesHandler.ColorsForShape[fieldDotsArray[i, j]], new Rectangle(50 + i * DOT_SIZE + 1, 50 + j * DOT_SIZE + 1, DOT_SIZE - 1, DOT_SIZE - 1));
                }
            }
        }

        private void ShowGamePanel()
        {
            ScoreLabel.Visible = true;
            NextShapeLabel.Visible = true;
            NextShapePictureBox.Visible = true;
            StartGameButton.Visible = false;
            StartGameButton.Enabled = false;
            InstructionGroupBox.Visible = false;
        }

        private void HideGamePanel()
        {
            ScoreLabel.Visible = false;
            NextShapeLabel.Visible = false;
            NextShapePictureBox.Visible = false;
            StartGameButton.Visible = true;
            StartGameButton.Enabled = true;
            InstructionGroupBox.Visible = true;
        }

        private Shape GetRandomShapeWithCenterAligned()
        {
            Shape shape = (Shape)ShapesHandler.GetRandomShape().Clone();

            shape.PositionX = FIELD_WIDTH / 2;
            shape.PositionY = -shape.Height;

            return shape;
        }

        private Shape GetNextShape()
        {
            Shape shape = (Shape)GetRandomShapeWithCenterAligned().Clone();
            nextShapeBitmap = new Bitmap(6 * DOT_SIZE, 6 * DOT_SIZE);
            nextShapeGraphics = Graphics.FromImage(nextShapeBitmap);

            nextShapeGraphics.FillRectangle(Brushes.LightGray, 0, 0, nextShapeBitmap.Width, nextShapeBitmap.Height);
            int startX = (6 - shape.Width) / 2;
            int startY = (6 - shape.Height) / 2;

            for (int i = 0; i < shape.Height; i++)
            {
                for (int j = 0; j < shape.Width; j++)
                {
                    nextShapeGraphics.FillRectangle(
                        shape.Dots[i, j] > 0 ? shape.Color : Brushes.LightGray,
                        (startX + j) * DOT_SIZE, (startY + i) * DOT_SIZE, DOT_SIZE, DOT_SIZE);
                }
            }

            NextShapePictureBox.Size = nextShapeBitmap.Size;
            NextShapePictureBox.Image = nextShapeBitmap;

            return shape;
        }

        private void TetrisTickMoves(object sender, EventArgs e)
        {
            DeletePreviousStepOfShape();
            if (CanShapeMoveDown())
            {
                currentShape.Move(moveDown: 1);
            }
            else
            {
                if(TetrisTimer.Interval == MOVE_TO_THE_BOTTOM_SHAPE_SPEED)
                {
                    TetrisTimer.Interval = currentSpeed;
                }
                CheckForOverTheGame();
                UpdateFieldDotsArray();
                currentShape = nextShape;
                nextShape = GetNextShape();
                ClearFilledRowsWithUpdatingScore();

            }
            UpdateFieldDotsArray();
            Invalidate();
        }

        private void DeletePreviousStepOfShape()
        {

            for (int i = currentShape.PositionX; i < currentShape.PositionX + currentShape.Width; i++)
            {
                for (int j = currentShape.PositionY; j < currentShape.PositionY + currentShape.Height; j++)
                {
                    if (i >= 0 && j >= 0 && currentShape.Dots[j - currentShape.PositionY, i - currentShape.PositionX] != DEFAULT_VALUE_OF_ARRAY)
                    {
                        fieldDotsArray[i, j] = DEFAULT_VALUE_OF_ARRAY;
                    }
                }
            }
        }

        private bool CanShapeMoveDown()
        {
            for (int i = currentShape.PositionX; i < currentShape.PositionX + currentShape.Width; i++)
            {
                for (int j = currentShape.PositionY; j < currentShape.PositionY + currentShape.Height; j++)
                {
                    if (currentShape.Dots[j - currentShape.PositionY, i - currentShape.PositionX] != DEFAULT_VALUE_OF_ARRAY)
                    {
                        if (j + 1 == FIELD_HEIGHT) return false;
                        if ((j + 1) > 0 && fieldDotsArray[i, j + 1] != 0) return false;
                    }
                }
            }
            return true;
        }

        private bool CanShapeMoveSideways(int moveLeft = 0, int moveRight = 0)
        {
            for (int i = currentShape.PositionX; i < currentShape.PositionX + currentShape.Width; i++)
            {
                for (int j = currentShape.PositionY; j < currentShape.PositionY + currentShape.Height; j++)
                {
                    if (currentShape.Dots[j - currentShape.PositionY, i - currentShape.PositionX] != DEFAULT_VALUE_OF_ARRAY)
                    {
                        if (i - moveLeft < 0 || i + moveRight == FIELD_WIDTH) return false;
                        if ((i + 1) > 0 && (j + 1) > 0 && fieldDotsArray[i - moveLeft + moveRight, j] != 0) return false;
                    }
                }
            }
            return true;
        }

        private bool CanShapeBeRotated()
        {
            for (int i = currentShape.PositionX; i < currentShape.PositionX + currentShape.Width; i++)
            {
                for (int j = currentShape.PositionY; j < currentShape.PositionY + currentShape.Height; j++)
                {
                    if (i < 0 || j < 0 || i >= FIELD_WIDTH || j >= FIELD_HEIGHT || fieldDotsArray[i, j] != DEFAULT_VALUE_OF_ARRAY)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void UpdateFieldDotsArray()
        {

            for (int i = currentShape.PositionX; i < currentShape.PositionX + currentShape.Width; i++)
            {
                for (int j = currentShape.PositionY; j < currentShape.PositionY + currentShape.Height; j++)
                {
                    if (i >= 0 && j >= 0 && currentShape.Dots[j - currentShape.PositionY, i - currentShape.PositionX] != DEFAULT_VALUE_OF_ARRAY)
                    {
                        fieldDotsArray[i, j] = currentShape.Dots[j - currentShape.PositionY, i - currentShape.PositionX];
                    }
                }
            }
        }

        private void ClearFilledRowsWithUpdatingScore()
        {
            for (int i = 0; i < FIELD_HEIGHT; i++)
            {
                int j;
                for (j = FIELD_WIDTH - 1; j >= 0; j--)
                {
                    if (fieldDotsArray[j, i] == DEFAULT_VALUE_OF_ARRAY)
                    {
                        break;
                    }
                }
                if (j == -1)
                {
                    score += SCORE_PER_LINE;
                    ScoreLabel.Text = "Score: " + score;
                    if (TetrisTimer.Interval >= LOWEST_POSSIBLE_SHAPE_SPEED + STEP_OF_SHAPE_SPEED_INCREASE)
                    {
                        TetrisTimer.Interval -= STEP_OF_SHAPE_SPEED_INCREASE;
                    }
                    for (j = 0; j < FIELD_WIDTH; j++)
                    {
                        for (int k = i; k > 0; k--)
                        {
                            fieldDotsArray[j, k] = fieldDotsArray[j, k - 1];
                        }
                        fieldDotsArray[j, 0] = DEFAULT_VALUE_OF_ARRAY;
                    }
                }
            }
        }

        private void TetrisForm_KeyDown(object sender, KeyEventArgs e)
        {
            var verticalMove = 0;
            var horizontalMove = 0;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    DeletePreviousStepOfShape();
                    if (CanShapeMoveSideways(moveLeft: 1))
                    {
                        verticalMove--;
                        currentShape.Move(horizontalMove, verticalMove);
                        UpdateFieldDotsArray();
                        Invalidate();
                    }
                    break;

                case Keys.Right:
                    DeletePreviousStepOfShape();
                    if (CanShapeMoveSideways(moveRight: 1))
                    {
                        verticalMove++;
                        currentShape.Move(horizontalMove, verticalMove);
                        UpdateFieldDotsArray();
                        Invalidate();
                    }
                    break;

                case Keys.Down:
                    DeletePreviousStepOfShape();
                    if (CanShapeMoveDown())
                    {
                        horizontalMove++;
                        currentShape.Move(horizontalMove, verticalMove);
                        UpdateFieldDotsArray();
                        Invalidate();
                    }
                    break;

                case Keys.Up:
                    DeletePreviousStepOfShape();
                    currentShape.Turn();
                    if (CanShapeBeRotated())
                    {
                        UpdateFieldDotsArray();
                        Invalidate();
                    }
                    else
                    {
                        currentShape.RollBack();
                    }
                    break;

                case Keys.Space:
                    currentSpeed = TetrisTimer.Interval;
                    TetrisTimer.Interval = MOVE_TO_THE_BOTTOM_SHAPE_SPEED;
                    break;

                case Keys.E:
                    EndGame();
                    break;

                default: 
                    return;
            }
        }

        private void EndGame()
        {
            isGameInRun = false;
            TetrisTimer.Stop();
            this.KeyDown -= TetrisForm_KeyDown;
            this.KeyDown -= PauseGame;
            MessageBox.Show("Game is over! You've reached " + score + " score!");
            HideGamePanel();
        }

        private void CheckForOverTheGame()
        {
            if (currentShape.PositionY <= 0)
            {
                EndGame();
            }
        }

    }
}
