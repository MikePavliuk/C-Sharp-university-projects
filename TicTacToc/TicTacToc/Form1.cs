using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToc
{
    public partial class TicTacTocForm : Form
    {
        private Player currentPlayer;
        private Level currentLevel;

        private const int SIZE_OF_QUADRATIC_MATRIX = 3;
        private const int DEFAULT_VALUE_OF_MATRIX = 10;
        private const int CLOSE_SCORE_FOR_COMPUTER_WIN = DEFAULT_VALUE_OF_MATRIX + (SIZE_OF_QUADRATIC_MATRIX - 1) * (int)Player.O;
        private const int CLOSE_SCORE_FOR_PLAYER_WIN = DEFAULT_VALUE_OF_MATRIX + (SIZE_OF_QUADRATIC_MATRIX - 1) * (int)Player.X;
        private const int MAX_POSSIBLE_NUMBER_OF_MOVES = SIZE_OF_QUADRATIC_MATRIX * SIZE_OF_QUADRATIC_MATRIX;

        private bool isGameFinished;
        private int numberOfMoves;

        private Random randomNumberGenerator = new Random();

        Button[,] buttonsOfGamePanel = new Button[SIZE_OF_QUADRATIC_MATRIX, SIZE_OF_QUADRATIC_MATRIX];
        int[,] matrixOfGameScore = new int[SIZE_OF_QUADRATIC_MATRIX, SIZE_OF_QUADRATIC_MATRIX];

        public TicTacTocForm()
        {
            InitializeComponent();
            GenerateButtonsForGamePanel();
            FillMatrixOfGameScoreWithDefaultValues();
            DisableBoardButtons();
            Level1RadioButton.Checked = true;
            isGameFinished = false;
            numberOfMoves = 0;
        }

        public enum Player
        {
            O,
            X
        }

        public enum Level
        {
            First = 1,
            Second = 2,
            Third = 3
        }

        private void GenerateButtonsForGamePanel()
        {
            for (int i = 0; i < SIZE_OF_QUADRATIC_MATRIX; i++)
            {
                for (int j = 0; j < SIZE_OF_QUADRATIC_MATRIX; j++)
                {
                    int rawIndex = i;
                    int columnIndex = j;
                    buttonsOfGamePanel[i, j] = new Button();
                    buttonsOfGamePanel[i, j].Font = new System.Drawing.Font(DefaultFont.FontFamily, 80, FontStyle.Bold);
                    buttonsOfGamePanel[i, j].Size = new Size(150, 150);
                    buttonsOfGamePanel[i, j].Location = new Point(j * 150, i * 150);
                    buttonsOfGamePanel[i, j].Click += (sender, e) => ButtonOfGamePanel_Click(sender, e, rawIndex, columnIndex);
                    TicTacTocPanel.Controls.Add(buttonsOfGamePanel[i, j]);
                }
            }
        }
        private void FillMatrixOfGameScoreWithDefaultValues()
        {
            for (int i = 0; i < SIZE_OF_QUADRATIC_MATRIX; i++)
            {
                for (int j = 0; j < SIZE_OF_QUADRATIC_MATRIX; j++)
                {
                    matrixOfGameScore[i, j] = DEFAULT_VALUE_OF_MATRIX;
                }
            }
        }
        private void DisableBoardButtons()
        {
            for (int i = 0; i < SIZE_OF_QUADRATIC_MATRIX; i++)
            {
                for (int j = 0; j < SIZE_OF_QUADRATIC_MATRIX; j++)
                {
                    buttonsOfGamePanel[i, j].Enabled = false;
                }
            }
        }
        private void StartGameButton_Click(object sender, EventArgs e)
        {
            RestartGameConfigurations();
            if (Level1RadioButton.Checked) currentLevel = Level.First;
            else if (Level2RadioButton.Checked) currentLevel = Level.Second;
            else if (Level3RadioButton.Checked) currentLevel = Level.Third;
        }
        private void RestartGameConfigurations()
        {
            FillMatrixOfGameScoreWithDefaultValues();
            EnableBoardButtons();
            ClearBoard();
            isGameFinished = false;
            numberOfMoves = 0;
        }

        private void EnableBoardButtons()
        {
            for (int i = 0; i < SIZE_OF_QUADRATIC_MATRIX; i++)
            {
                for (int j = 0; j < SIZE_OF_QUADRATIC_MATRIX; j++)
                {
                    buttonsOfGamePanel[i, j].Enabled = true;
                }
            }
        }

        private void ClearBoard()
        {
            for (int i = 0; i < SIZE_OF_QUADRATIC_MATRIX; i++)
            {
                for (int j = 0; j < SIZE_OF_QUADRATIC_MATRIX; j++)
                {
                    buttonsOfGamePanel[i, j].Text = null;
                }
            }
        }

        private void ButtonOfGamePanel_Click(object sender, EventArgs e, int i, int j)
        {
            currentPlayer = Player.X;
            FillButton(i, j);
            numberOfMoves += 1;
            CheckMatrixScoresForWin();
            if(numberOfMoves == MAX_POSSIBLE_NUMBER_OF_MOVES && !isGameFinished)
            {
                EndGameWithDraw();
            }
            else if (!isGameFinished)
            {
                GiveMoveToComputer();
            }
            this.ActiveControl = null;
        }

        private void FillButton(int i, int j)
        {
            buttonsOfGamePanel[i, j].Enabled = false;
            buttonsOfGamePanel[i, j].Text = currentPlayer.ToString();
            matrixOfGameScore[i, j] = (int)currentPlayer;
        }

        private void CheckMatrixScoresForWin()
        {
            if (numberOfMoves >= 2 * SIZE_OF_QUADRATIC_MATRIX - 1)
            {
                if (DoesRawFilled() || DoesColumnFilled() || DoesDiagonalFilled())
                {
                    isGameFinished = true;
                    EndGameWithWin();
                }
            }
        }

        private bool DoesRawFilled()
        {
            for (int i = 0; i < SIZE_OF_QUADRATIC_MATRIX; i++)
            {
                int currentScore = 0;
                for (int j = 0; j < SIZE_OF_QUADRATIC_MATRIX; j++)
                {
                    currentScore += matrixOfGameScore[i, j];
                }
                if (DoesSomebodyWin(currentScore)) return true;
            }
            return false;
        }

        private bool DoesColumnFilled()
        {
            for (int i = 0; i < SIZE_OF_QUADRATIC_MATRIX; i++)
            {
                int currentScore = 0;
                for (int j = 0; j < SIZE_OF_QUADRATIC_MATRIX; j++)
                {
                    currentScore += matrixOfGameScore[j, i];
                }
                if (DoesSomebodyWin(currentScore)) return true;
            }
            return false;
        }

        private bool DoesDiagonalFilled()
        {
            int mainDiagonalScore = 0;
            int antiDiagonalScore = 0;
            for (int i = 0; i < SIZE_OF_QUADRATIC_MATRIX; i++)
            {
                for (int j = 0; j < SIZE_OF_QUADRATIC_MATRIX; j++)
                {
                    if (i == j) mainDiagonalScore += matrixOfGameScore[i, j];
                    if (i == SIZE_OF_QUADRATIC_MATRIX - j - 1) antiDiagonalScore += matrixOfGameScore[i, j];
                }

            }
            if (DoesSomebodyWin(mainDiagonalScore)) return true;
            else if (DoesSomebodyWin(antiDiagonalScore)) return true;
            else return false;
        }

        private bool DoesSomebodyWin(int currentScore)
        {
            const int SCORE_WIN_PLAYER = SIZE_OF_QUADRATIC_MATRIX;
            const int SCORE_WIN_COMPUTER = 0;
            if (currentScore == SCORE_WIN_PLAYER) return true;
            else if (currentScore == SCORE_WIN_COMPUTER) return true;
            else return false;
        }

        private void EndGameWithWin()
        {
            isGameFinished = true;
            DisableBoardButtons();
            MessageBox.Show("Player " + currentPlayer + " has won!", "Congratulations");
        }

        private void EndGameWithDraw()
        {
            isGameFinished = true;
            DisableBoardButtons();
            MessageBox.Show("Draw!", "Congratulations");
        }

        private void GiveMoveToComputer()
        {
            currentPlayer = Player.O;
            if (currentLevel == Level.First) TurnOfComputerLevel1();
            else if (currentLevel == Level.Second) TurnOfComputerLevel2();
            else if (currentLevel == Level.Third) TurnOfComputerLevel3();
        }

        private void TurnOfComputerLevel1()
        {
            FillFirstEmptyButton();
        }

        private void FillFirstEmptyButton()
        {
            for (int i = 0; i < SIZE_OF_QUADRATIC_MATRIX; i++)
            {
                for (int j = 0; j < SIZE_OF_QUADRATIC_MATRIX; j++)
                {
                    if (matrixOfGameScore[i, j] == DEFAULT_VALUE_OF_MATRIX)
                    {
                        ComputerMove(i, j);
                        return;
                    }
                }
            }
        }

        private void ComputerMove(int i, int j)
        {
            FillButton(i, j);
            CheckMatrixScoresForWin();
            numberOfMoves += 1;
        }

        private void TurnOfComputerLevel2()
        {
            int numberOfMovesBeforeCheck = numberOfMoves;
            FillLineIfScoreIsEqualTo(CLOSE_SCORE_FOR_PLAYER_WIN);
            if (numberOfMovesBeforeCheck == numberOfMoves)
            {
                FillFirstEmptyButton();
            }
        }

        private void TurnOfComputerLevel3()
        {
            int numberOfMovesBeforeCheck = numberOfMoves;
            FillLineIfScoreIsEqualTo(CLOSE_SCORE_FOR_COMPUTER_WIN);
            if (numberOfMovesBeforeCheck == numberOfMoves)
            {
                FillLineIfScoreIsEqualTo(CLOSE_SCORE_FOR_PLAYER_WIN);
                if (numberOfMovesBeforeCheck == numberOfMoves)
                {
                    FillLineIfScoreIsEqualTo((SIZE_OF_QUADRATIC_MATRIX-1)*DEFAULT_VALUE_OF_MATRIX);
                    if (numberOfMovesBeforeCheck == numberOfMoves)
                    {
                        FillRandomEmptyButton();
                    }
                }
            }
        }

        private void FillRandomEmptyButton()
        {
            int randIndexOfRaw = randomNumberGenerator.Next(0, SIZE_OF_QUADRATIC_MATRIX - 1);
            int randIndexOfColumn = randomNumberGenerator.Next(0, SIZE_OF_QUADRATIC_MATRIX - 1);
            if (matrixOfGameScore[randIndexOfRaw, randIndexOfColumn] == DEFAULT_VALUE_OF_MATRIX)
            {
                ComputerMove(randIndexOfRaw, randIndexOfColumn);
                return;
            }
            else FillRandomEmptyButton();
        }

        private void FillLineIfScoreIsEqualTo(int scoreToCompareWith)
        {
            int mainDiagonalScore = 0;
            int antidiagonalScore = 0;
            for (int i = 0; i < SIZE_OF_QUADRATIC_MATRIX; i++)
            {
                int currentScoreOfRaw = 0;
                int currentScoreOfColumn = 0;
                for (int j = 0; j < SIZE_OF_QUADRATIC_MATRIX; j++)
                {
                    currentScoreOfRaw += matrixOfGameScore[i, j];
                    currentScoreOfColumn += matrixOfGameScore[j, i];
                    if (i == j) mainDiagonalScore += matrixOfGameScore[i, j];
                    if (i == SIZE_OF_QUADRATIC_MATRIX - j - 1) antidiagonalScore += matrixOfGameScore[i, j];
                }
                if (currentScoreOfRaw == scoreToCompareWith)
                {
                    FillNecessaryRaw(i);
                    return;
                }
                else if (currentScoreOfColumn == scoreToCompareWith)
                {
                    FillNecessaryColumn(i);
                    return;
                }
            }
            if (mainDiagonalScore == scoreToCompareWith)
            {
                FillMainDiagonal();
            }
            else if (antidiagonalScore == scoreToCompareWith)
            {
                FillAntidiagonal();
            }
        }

        private void FillNecessaryRaw(int rawIndex)
        {
            for (int k = 0; k < SIZE_OF_QUADRATIC_MATRIX; k++)
            {
                if (matrixOfGameScore[rawIndex, k] == DEFAULT_VALUE_OF_MATRIX)
                {
                    ComputerMove(rawIndex, k);
                    return;
                }
            }
        }

        private void FillNecessaryColumn(int columnIndex)
        {
            for (int k = 0; k < SIZE_OF_QUADRATIC_MATRIX; k++)
            {
                if (matrixOfGameScore[k, columnIndex] == DEFAULT_VALUE_OF_MATRIX)
                {
                    ComputerMove(k, columnIndex);
                    return;
                }
            }
        }

        private void FillMainDiagonal()
        {
            for (int i = 0; i < SIZE_OF_QUADRATIC_MATRIX; i++)
            {
                if (matrixOfGameScore[i, i] == DEFAULT_VALUE_OF_MATRIX)
                {
                    ComputerMove(i, i);
                    return;
                }
            }
        }

        private void FillAntidiagonal()
        {
            for (int i = 0; i < SIZE_OF_QUADRATIC_MATRIX; i++)
            {
                for (int j = 0; j < SIZE_OF_QUADRATIC_MATRIX; j++)
                {
                    if (i == SIZE_OF_QUADRATIC_MATRIX - j - 1)
                    {
                        if (matrixOfGameScore[i, j] == DEFAULT_VALUE_OF_MATRIX)
                        {
                            ComputerMove(i, j);
                            return;
                        }
                    }
                }
            }
        }
    }
}
