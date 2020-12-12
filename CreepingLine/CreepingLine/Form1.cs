using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreepingLine
{
    public partial class CreepingLineForm : Form
    {
        static class Charecters
        {
            public static Dictionary<char, byte[]> charecters = new Dictionary<char, byte[]>()
            {
                [' '] = new byte[]{ 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 },
                ['A'] = new byte[] { 0x38, 0x44, 0x82, 0x82, 0xFE, 0x82, 0x82, 0x82, 0x82, 0x82 },
                ['B'] = new byte[] { 0xFC, 0x82, 0x82, 0x82, 0xFC, 0x82, 0x82, 0x82, 0x82, 0xFC },
                ['C'] = new byte[] { 0xFE, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0x80, 0xFE },
                ['D'] = new byte[] { 0xFC, 0x82, 0x82, 0x82, 0x82, 0x82, 0x82, 0x82, 0x84, 0xF8 },
                ['E'] = new byte[] { 0xFE, 0x80, 0x80, 0x80, 0xFC, 0x80, 0x80, 0x80, 0x80, 0xFE },
                ['F'] = new byte[] { 0xFE, 0x80, 0x80, 0x80, 0xFC, 0x80, 0x80, 0x80, 0x80, 0x80 },
                ['G'] = new byte[] { 0x7E, 0x80, 0x80, 0x80, 0xBE, 0xA2, 0x82, 0x82, 0x82, 0x7C },
                ['H'] = new byte[] { 0x82, 0x82, 0x82, 0x82, 0xFE, 0x82, 0x82, 0x82, 0x82, 0x82 }
            };

            public static void UpdateCharectersDictionary(char charecter, byte[] rowsCodes)
            {
                if (!charecters.ContainsKey(charecter)) {
                    charecters.Add(charecter, rowsCodes);
                }
                else
                {
                    charecters[charecter] = rowsCodes;
                }
            }
        }

        class CharectersConstructor
        {
            Button[,] buttonsOfCharecterPanel = new Button[NUMBER_OF_BITS_IN_RAW, NUMBER_OF_BITS_IN_COLUMN];
            byte[,] bytesOfRawOfCharecter = new byte[NUMBER_OF_BITS_IN_RAW, NUMBER_OF_BITS_IN_COLUMN];
            Color colorForOne = Color.Black;
            Color colorForZero = Color.White;

            public CharectersConstructor(Form form)
            {
                GenerateCharecterEditPanel(form);
                FillBytesOfRawOfCharecterWithDefaultValues();
                DisableLastColumnButtons();
            }

            public void GenerateCharecterEditPanel(Form form)
            {
                Panel CharecterPanel = new Panel();
                CharecterPanel.Size = new Size(SIZE_OF_CELL * 2 * NUMBER_OF_BITS_IN_RAW, SIZE_OF_CELL * 2 * NUMBER_OF_BITS_IN_COLUMN);
                CharecterPanel.Location = new Point(294, 250);
                CharecterPanel.BorderStyle = BorderStyle.FixedSingle;
                form.Controls.Add(CharecterPanel);
                for (int i = 0; i < NUMBER_OF_BITS_IN_RAW; i++)
                {
                    for (int j = 0; j < NUMBER_OF_BITS_IN_COLUMN; j++)
                    {
                        int rawIndex = i;
                        int columnIndex = j;
                        buttonsOfCharecterPanel[i, j] = new Button();
                        buttonsOfCharecterPanel[i, j].BackColor = colorForZero;
                        buttonsOfCharecterPanel[i, j].Size = new Size(SIZE_OF_CELL * 2, SIZE_OF_CELL * 2);
                        buttonsOfCharecterPanel[i, j].Location = new Point(i * SIZE_OF_CELL * 2, j * SIZE_OF_CELL * 2);
                        buttonsOfCharecterPanel[i, j].Click += (sender, e) => ButtonOfCharecterPanel_Click(sender, e, rawIndex, columnIndex);
                        CharecterPanel.Controls.Add(buttonsOfCharecterPanel[i, j]);
                    }
                }
            }

            public void ButtonOfCharecterPanel_Click(object sender, EventArgs e, int i, int j)
            {
                if (bytesOfRawOfCharecter[i, j] == 0)
                {
                    bytesOfRawOfCharecter[i, j] = 1;
                    buttonsOfCharecterPanel[i, j].BackColor = colorForOne;
                }
                else
                {
                    bytesOfRawOfCharecter[i, j] = 0;
                    buttonsOfCharecterPanel[i, j].BackColor = colorForZero;
                }
                Form myForm = buttonsOfCharecterPanel[i, j].FindForm();
                myForm.ActiveControl = null;
            }

            private void FillBytesOfRawOfCharecterWithDefaultValues()
            {
                const byte DEFAULT_VALUE = 0;
                for (int i = 0; i < NUMBER_OF_BITS_IN_RAW; i++)
                {
                    for (int j = 0; j < NUMBER_OF_BITS_IN_COLUMN; j++)
                    {
                        bytesOfRawOfCharecter[i, j] = DEFAULT_VALUE;
                    }
                }
            }

            private void DisableLastColumnButtons()
            {
                for (int i = 0; i < NUMBER_OF_BITS_IN_RAW; i++)
                {
                    for (int j = 0; j < NUMBER_OF_BITS_IN_COLUMN; j++)
                    {
                        if (i == NUMBER_OF_BITS_IN_RAW - 1) buttonsOfCharecterPanel[i, j].Enabled = false;
                    }
                }
            }

            public void ReconfigurePanelToStartState()
            {
                FillBytesOfRawOfCharecterWithDefaultValues();
                MakeButtonsToHaveDefaultBackColor();
            }

            private void MakeButtonsToHaveDefaultBackColor()
            {
                for (int i = 0; i < NUMBER_OF_BITS_IN_RAW; i++)
                {
                    for (int j = 0; j < NUMBER_OF_BITS_IN_COLUMN; j++)
                    {
                        buttonsOfCharecterPanel[i, j].BackColor = colorForZero;
                    }
                }
            }

            public void ConstructCharecter(string charecter)
            {
                byte[] rows = new byte[NUMBER_OF_BITS_IN_COLUMN];
                int counter = 0;
                for (int i = 0; i < NUMBER_OF_BITS_IN_COLUMN; i++)
                {
                    string row = "";
                    for (int j = 0; j < NUMBER_OF_BITS_IN_RAW; j++)
                    {
                        row += bytesOfRawOfCharecter[j, i];
                    }
                    rows[counter] = Convert.ToByte(row, 2);
                    counter++;
                }
                Charecters.UpdateCharectersDictionary(charecter[0], rows);
            }

            public void EnablePanelButtons()
            {
                for (int i = 0; i < NUMBER_OF_BITS_IN_RAW-1; i++)
                {
                    for (int j = 0; j < NUMBER_OF_BITS_IN_COLUMN; j++)
                    {
                        buttonsOfCharecterPanel[i, j].Enabled = true;
                    }
                }
            }

            public void DisablePanelButtons()
            {
                for (int i = 0; i < NUMBER_OF_BITS_IN_RAW; i++)
                {
                    for (int j = 0; j < NUMBER_OF_BITS_IN_COLUMN; j++)
                    {
                        buttonsOfCharecterPanel[i, j].Enabled = false;
                    }
                }
            }
        }

        class PlaceForCharecters
        {
            PictureBox placeForCharecter;
            Bitmap bitmap = new Bitmap(NUMBER_OF_BITS_IN_RAW * SIZE_OF_CELL, SIZE_OF_CELL * NUMBER_OF_BITS_IN_COLUMN);
            Graphics graph;
            static SolidBrush BrushForOne = new SolidBrush(Color.Black);
            static SolidBrush BrushForZero = new SolidBrush(Color.White);
            byte[] charecter = new byte[NUMBER_OF_BITS_IN_COLUMN];
            static byte[] undefinedSymbol = new byte[] { 0xFE, 0xFE, 0xFE, 0xFE, 0xFE, 0xFE, 0xFE, 0xFE, 0xFE, 0xFE };

            public PlaceForCharecters()
            {
                graph = Graphics.FromImage(bitmap);
            }

            public void InitializeCharecter(char charecterOnInvisibleRegister)
            {
                if(Charecters.charecters.ContainsKey(charecterOnInvisibleRegister))
                {
                    Array.Copy(Charecters.charecters[charecterOnInvisibleRegister], charecter, NUMBER_OF_BITS_IN_COLUMN);
                } 
                else
                {
                    Array.Copy(undefinedSymbol, charecter, NUMBER_OF_BITS_IN_COLUMN);
                }
            }

            public void DrawCharecter()
            {
                for (int i = 0; i < NUMBER_OF_BITS_IN_COLUMN; i++)
                {
                    for (int j = NUMBER_OF_BITS_IN_RAW-1; j >= 0; j--)
                    {
                        if ((charecter[i] & (1 << j)) != 0)
                        {
                            graph.FillRectangle(BrushForOne, ((NUMBER_OF_BITS_IN_RAW - 1) - j) * SIZE_OF_CELL, i * SIZE_OF_CELL, SIZE_OF_CELL, SIZE_OF_CELL);
                        }
                        else
                        {
                            graph.FillRectangle(BrushForZero, ((NUMBER_OF_BITS_IN_RAW - 1) - j) * SIZE_OF_CELL, i * SIZE_OF_CELL, SIZE_OF_CELL, SIZE_OF_CELL);
                        }
                    }
                }
                placeForCharecter.Image = bitmap;
            }

            public string GetFirstColumn()
            {
                string column = "";
                for (int i = 0; i < NUMBER_OF_BITS_IN_COLUMN; i++)
                {
                    int bit = Convert.ToInt32((charecter[i] & 1 << (NUMBER_OF_BITS_IN_RAW - 1)) != 0);
                    column += bit;
                }
                return column;
            }

            public void AddColumnToLastBit(string binaryColumn)
            {
                for (int i = 0; i < NUMBER_OF_BITS_IN_COLUMN; i++)
                {
                    charecter[i] = (byte)(charecter[i] | (binaryColumn[i] & 1)); 
                }
            }

            public void ShiftCharecter()
            {
                for (int i = 0; i < NUMBER_OF_BITS_IN_COLUMN; i++)
                {
                    charecter[i] = (byte)(charecter[i] << 1);
                }
            }

            public void CreatePictureBox(Form form, int x)
            {
                int y = 100;
                placeForCharecter = new PictureBox
                {
                    Size = new Size(SIZE_OF_CELL * NUMBER_OF_BITS_IN_RAW, SIZE_OF_CELL * NUMBER_OF_BITS_IN_COLUMN),
                    Location = new Point(x, y),
                };
                form.Controls.Add(placeForCharecter);
            } 
        }

        class Display
        {
            const int NUMBER_OF_PLACES = 8;
            public List<PlaceForCharecters> placesForCharecters = new List<PlaceForCharecters>(NUMBER_OF_PLACES);

            public Display(Form form)
            {
                CreatePlacesForCharecters(form);
                placesForCharecters.Add(new PlaceForCharecters());
            }

            public void CreatePlacesForCharecters(Form form)
            {
                int x = 0;
                const int OFFSET = 3;
                for(int i = 0; i< NUMBER_OF_PLACES; i++)
                {
                    x += SIZE_OF_CELL * NUMBER_OF_BITS_IN_RAW;
                    PlaceForCharecters placeForCharecters = new PlaceForCharecters();
                    placeForCharecters.InitializeCharecter(' ');
                    placeForCharecters.CreatePictureBox(form, x);
                    x += OFFSET;
                    placeForCharecters.DrawCharecter();
                    placesForCharecters.Add(placeForCharecters);
                }
            }

            public async Task RunCreepingLineTask(string textToDisplay, int speed)
            {
                for (int i = 0; i < textToDisplay.Length + NUMBER_OF_PLACES; i++)
                {
                    char charecter;
                    if (i >= textToDisplay.Length) charecter = ' ';
                    else charecter = textToDisplay[i];
                    LoadCharecterToInvisibleResgister(charecter);
                    for (int k = 0; k < NUMBER_OF_BITS_IN_RAW; k++)
                    {
                        string[] columns = new string[NUMBER_OF_PLACES];
                        for(int j = NUMBER_OF_PLACES-1; j>= 0; j--)
                        {
                            columns[j] = placesForCharecters[j + 1].GetFirstColumn();
                        }
                        for(int j = NUMBER_OF_PLACES-1; j >=0; j--)
                        {
                            if(j == (NUMBER_OF_PLACES - 1)) placesForCharecters[j+1].ShiftCharecter();
                            placesForCharecters[j].ShiftCharecter();
                            placesForCharecters[j].AddColumnToLastBit(columns[j]);
                            placesForCharecters[j].DrawCharecter();
                        }
                        await Task.Delay(speed);
                    }
                }
            }

            private void LoadCharecterToInvisibleResgister(char charecter)
            {
                placesForCharecters.Last().InitializeCharecter(charecter);
            }
        } 

        const int SIZE_OF_CELL = 10;
        const int NUMBER_OF_BITS_IN_RAW = 8;
        const int NUMBER_OF_BITS_IN_COLUMN = 10;
        Display creepingLine;
        CharectersConstructor charectersConstructor;

        public CreepingLineForm()
        {
            InitializeComponent();
            InitializeSpeedComboBox();
            creepingLine = new Display(this);
            charectersConstructor = new CharectersConstructor(this);
        }

        private void InitializeSpeedComboBox()
        {
            Dictionary<string, int> speed = new Dictionary<string, int>
            {
              {"Slow", 120},
              {"Normal", 60},
              {"Fast", 25}
            };
            SpeedComboBox.DataSource = new BindingSource(speed, null);
            SpeedComboBox.DisplayMember = "Key";
            SpeedComboBox.ValueMember = "Value";
            SpeedComboBox.SelectedIndex = 1;
        }


        private async void RunCreepingLineButton_Click(object sender, EventArgs e)
        {
            string textToUseForCreepingLine = CreepingLineTextBox.Text.ToUpper();
            int speed = int.Parse(SpeedComboBox.SelectedValue.ToString());
            if (textToUseForCreepingLine != "")
            {
                try
                {
                    SpeedComboBox.Enabled = false;
                    RunCreepingLineButton.Enabled = false;
                    ConstructCharecterButton.Enabled = false;
                    charectersConstructor.DisablePanelButtons();
                    await creepingLine.RunCreepingLineTask(textToUseForCreepingLine, speed);
                }
                finally
                {
                    SpeedComboBox.Enabled = true;
                    RunCreepingLineButton.Enabled = true;
                    ConstructCharecterButton.Enabled = true;
                    charectersConstructor.EnablePanelButtons();
                }
            }
            else
            {
                MessageBox.Show("You should enter text to use creeping line!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void ConstructCharecterButton_Click(object sender, EventArgs e)
        {
            if (CharecterToConstructTextBox.Text != "")
            {
                ConstructCharecterButton.Enabled = false;
                charectersConstructor.ConstructCharecter(CharecterToConstructTextBox.Text.ToUpper());
                ConstructCharecterButton.Enabled = true;
                CharecterToConstructTextBox.Text = "";
                charectersConstructor.ReconfigurePanelToStartState();
            }
            else
            {
                MessageBox.Show("You should enter the charecter to construct it!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
            }
        }
    }
}
