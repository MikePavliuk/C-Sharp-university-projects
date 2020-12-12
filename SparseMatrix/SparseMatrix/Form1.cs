using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparseMatrix
{
    public partial class SparseMatrix : Form
    {
        class CSparseMatrix: ICloneable
        {
            static int defaultNameCounter = 0;

            static int defaultCloneNameCounter = 0;

            public int NumberOfDimensions { get; set;} 

            public int DefaultNumber { get; set; }

            public string Name { get; set; }

            public List<int> DimensionsRanges = new List<int>();

            List<CSparseCell> cells = new List<CSparseCell>();

            public CSparseMatrix()
            {
                SetDefaultName();
                ShowMessage("Created " + Name);
            }

            public CSparseMatrix(string name)
            {
                Name = name;
                ShowMessage("Created " + Name);
            }

            public object Clone()
            {
                string name = Name + "_copy" + defaultCloneNameCounter;
                defaultCloneNameCounter++;
                CSparseMatrix matrix = new CSparseMatrix(name);
                matrix.DefaultNumber = DefaultNumber;
                matrix.NumberOfDimensions = NumberOfDimensions;
                matrix.DimensionsRanges.AddRange(DimensionsRanges);
                matrix.cells = new List<CSparseCell>(cells.Count);
                for(int i = 0; i < cells.Count; i++)
                {
                    matrix.cells[i] = (CSparseCell)cells[i].Clone();
                }
                return matrix;
            }

            ~CSparseMatrix()
            {
                ShowMessage("Deleted " + Name);
            }

            public void SetDefaultName()
            {
                const string DEFAULT_NAME = "SparseMatrix";
                Name = DEFAULT_NAME + "_" + defaultNameCounter;
                defaultNameCounter++;
            }

            public void SetDimensionsRanges(List<int> ranges)
            {
                DimensionsRanges.AddRange(ranges);
            }


            public void SetValueIntoCell(int value, List<int> coordinates, int defaultNumber)
            {
                if(IsValidCell(coordinates))
                {
                    if(!IsDuplicateCell(coordinates))
                    {
                        if (value != defaultNumber)
                        {
                            CSparseCell cell = new CSparseCell();
                            cell.Value = value;
                            cell.coordinates.AddRange(coordinates);
                            cells.Add(cell);
                        }
                        else ShowMessage("You've entered default number into cell empty cell. It won't be stored.");
                    }
                    else 
                    {
                        ChangeValueOfTheCell(coordinates, value, defaultNumber);
                    }
                }
            }

            private bool IsValidCell(List<int> coordinates)
            {
                for (int i = 0; i < coordinates.Count; i++)
                {
                    if (coordinates[i] >= 0 && coordinates[i] < DimensionsRanges[i]) continue;
                    else return false;
                }
                return true;
            }


            private bool IsDuplicateCell(List<int> coordinates)
            {
                foreach (CSparseCell cell in cells)
                {
                    if (cell.coordinates.All(coordinates.Contains)) return true;
                }
                return false;
            }

            private void ChangeValueOfTheCell(List<int> coordinates, int value, int defaultNumber)
            {
                foreach (CSparseCell cell in cells)
                {
                    int counter = 0;
                    for (int i = 0; i < coordinates.Count; i++)
                    {
                        if (cell.coordinates[i] == coordinates[i])
                        {
                            counter++;
                        }
                    }
                    if (counter == coordinates.Count)
                    {
                        if (value == defaultNumber)
                        {
                            cells.Remove(cell);
                        }
                        else
                        {
                            cell.Value = value;
                        }
                        return;
                    }
                }
            }

            public int GetValueFromCell(List<int> coordinates)
            {
                foreach(CSparseCell cell in cells)
                {
                    if (Enumerable.SequenceEqual(cell.coordinates, coordinates))
                        return cell.Value;
                }
                return DefaultNumber;
            } 

            private void IncCoord(ref List<int> aCoord)
            { 
                for (var curDim = NumberOfDimensions - 1; curDim >= 0; --curDim)
                {
                    if (aCoord[curDim] == DimensionsRanges[curDim] - 1)
                        aCoord[curDim] = 0;
                    else
                    {
                        ++aCoord[curDim];
                        break;
                    }
                }
            }

            public IEnumerable<List<int>> AllCoords()
            {
                var curCellCoord = Enumerable.Repeat(0, NumberOfDimensions).ToList();
                var numCells = DimensionsRanges.Product();
                for (int j1 = 0; j1 < numCells; ++j1)
                {
                    yield return curCellCoord.ToList();
                    IncCoord(ref curCellCoord);
                }
            }

            public void OutputRangesOfMatrix(TextBox textBox)
            {
                textBox.Text += " size: [";
                string rangesStr = "";
                foreach (int range in DimensionsRanges)
                {
                    rangesStr += range + ", ";
                }
                if (rangesStr.Length != 0) rangesStr = rangesStr.Substring(0, rangesStr.Length - 2);
                textBox.Text += rangesStr + "]";
            }

            public void OutputValuesDifferentFromDefaultOne(TextBox textBox, int defaultNumber)
            {
                textBox.Text += "values different from default (" + defaultNumber + "): ";
                if (cells.Count != 0)
                {
                    string valuesStr = "";
                    foreach (CSparseCell cell in cells)
                    {
                        textBox.Text += "[";
                        foreach (int coordinate in cell.coordinates)
                        {
                            valuesStr += coordinate + ", ";
                        }
                        if (valuesStr.Length != 0) valuesStr = valuesStr.Substring(0, valuesStr.Length - 2);
                        textBox.Text += valuesStr + "]: " + cell.Value + "; ";
                    }
                }
                else
                {
                    textBox.Text += " none";
                }
            }

            public void ShowMessage(string messageText)
            {
                MessageBox.Show(messageText,
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
        }

        class CSparseCell: ICloneable
        {
            public int Value { get; set; }
            public List<int> coordinates = new List<int>();

            public CSparseCell() => coordinates = new List<int>();

            public CSparseCell(List<int> coords, int val)
            {
                Value = val;
                coordinates = coords;
            }
            public object Clone()
            {
                CSparseCell clonedCell = new CSparseCell();
                clonedCell.Value = Value;
                clonedCell.coordinates = coordinates.ToList();
                return clonedCell;
            }

        }

        List<CSparseMatrix> matrices = new List<CSparseMatrix>();

        public SparseMatrix()
        {
            InitializeComponent();
        }

        private void AddNewMatrixButton_Click(object sender, EventArgs e)
        {
            if (NewMatrixNumberOfDimesionsTextBox.Text != "" && NewMatrixRangesOfDimensionsTextBox.Text != "" 
                && NewMatrixDefaultValueTextBox.Text != "")
            {
                if (NewMatrixNumberOfDimesionsTextBox.Text == "0")
                {
                    ShowMessage("Number of dimesions can't be 0", "Error");
                    return;
                }
                string name = NewMatrixNameTextBox.Text;
                CSparseMatrix matrix;
                if (name != "") {
                    if (DoesNameOfMatrixAlreadyExist(name)) {
                        do
                        {
                            name += "_1";
                        }
                        while (DoesNameOfMatrixAlreadyExist(name));
                        ShowMessage("You've entered the name that is already exists, so we added postfix \"_1\"", "Information");
                    }
                    matrix = new CSparseMatrix(name); 
                }
                else matrix = new CSparseMatrix();
                matrix.DefaultNumber = int.Parse(NewMatrixDefaultValueTextBox.Text);
                matrix.NumberOfDimensions = int.Parse(NewMatrixNumberOfDimesionsTextBox.Text);
                matrix.SetDimensionsRanges(ParseStringOfRangesForCreatingDimensionsRanges(NewMatrixRangesOfDimensionsTextBox.Text, matrix.NumberOfDimensions));
                matrices.Add(matrix);
                AddItemToComboBoxes(matrix.Name);
                NewMatrixNameTextBox.Text = "";
                NewMatrixNumberOfDimesionsTextBox.Text = "";
                NewMatrixRangesOfDimensionsTextBox.Text = "";
                NewMatrixDefaultValueTextBox.Text = "";
            }
            else
            {
                ShowMessage("You should will all fields in spite of optional one", "Error");
            }
        }

        private bool DoesNameOfMatrixAlreadyExist(string name)
        {
            foreach(CSparseMatrix matrix in matrices)
            {
                if (matrix.Name == name) return true;
            }
            return false;
        }

        private List<int> ParseStringOfRangesForCreatingDimensionsRanges(string ranges, int numberOfRanges)
        {
            MatchCollection matchList = Regex.Matches(ranges, "([1-9][0-9]*)|0");
            List<int> enteredRanges = matchList.Cast<Match>().Select(match => int.Parse(match.Value)).ToList();
            bool isSomeRangeWasEqualToZero = false;
            for(int i = 0; i < enteredRanges.Count; i++)
            {
                if(enteredRanges[i] == 0)
                {
                    isSomeRangeWasEqualToZero = true;
                    enteredRanges[i] = 1;
                }
            }
            if(isSomeRangeWasEqualToZero)
            {
                ShowMessage("0 range can't be initialise, so it was changed to 1", "Information");
            }
            if (enteredRanges.Count < numberOfRanges)
            {
                while(enteredRanges.Count < numberOfRanges)
                {
                    enteredRanges.Add(enteredRanges.Last());
                }
                ShowMessage("Your range has less arguments then number of dimensions you've entered, so we filled ranges with value of last range you've entered.", "Information");
            }
            else if (enteredRanges.Count > numberOfRanges)
            {
                while (enteredRanges.Count > numberOfRanges)
                {
                    enteredRanges.RemoveAt(enteredRanges.Count - 1);
                }
                ShowMessage("Your range has more arguments then number of dimensions you've entered, so we have deleted unnecessary values", "Information");
            }
            return enteredRanges;
        }

        private void AddItemToComboBoxes(string name)
        {
            ShowMatrixByNameComboBox.Items.Add(name);
            DeleteMatrixNyNameComboBox.Items.Add(name);
            RenameMatrixByOldNameComboBox.Items.Add(name);
            CreateCloneOfMatrixByNameComboBox.Items.Add(name);
            AddNewValueToMatrixByNameComboBox.Items.Add(name);
        }

        private void ShowMatrixByNameButton_Click(object sender, EventArgs e)
        {
            if(ShowMatrixByNameComboBox.SelectedIndex != -1)
            {
                foreach (CSparseMatrix matrix in matrices)
                {
                    if (matrix.Name == ShowMatrixByNameComboBox.SelectedItem.ToString())
                    {
                        OutputTextBox.Text = "\"" + matrix.Name + "\"";
                        matrix.OutputRangesOfMatrix(OutputTextBox);
                        OutputTextBox.AppendText(Environment.NewLine);
                        if (CanWeOutputAllValuesFast(matrix))
                        {
                            OutputTextBox.Text += "values: ";
                            var coordinatesWithValue = matrix.AllCoords().Select(c => $"[{c.Join(",")}] - {matrix.GetValueFromCell(c)}");
                            OutputTextBox.Text += string.Join("; ", coordinatesWithValue.ToArray());
                            ShowMatrixByNameComboBox.SelectedIndex = -1;
                        }
                        else
                        {
                            matrix.OutputValuesDifferentFromDefaultOne(OutputTextBox, matrix.DefaultNumber);
                        }
                        return;
                    }
                }
            }
            else
            {
                ShowMessage("You should choose matrix to show it.", "Error");
            }
        }


        private bool CanWeOutputAllValuesFast(CSparseMatrix matrix)
        {
            const int NUMBER_OF_CELL_WHICH_CALCULATED_IN_NORMAL_SPEED = 300000;
            int productOfDimenstions = matrix.DimensionsRanges[0];
            for(int i = 1; i < matrix.DimensionsRanges.Count; i++)
            {
                productOfDimenstions *= matrix.DimensionsRanges[i];
                if (productOfDimenstions > NUMBER_OF_CELL_WHICH_CALCULATED_IN_NORMAL_SPEED) return false;
            }
            if ((matrix.NumberOfDimensions * productOfDimenstions) > NUMBER_OF_CELL_WHICH_CALCULATED_IN_NORMAL_SPEED) return false;
            return true;
        }

        private void ShowAllMatricesButton_Click(object sender, EventArgs e)
        {
            OutputTextBox.Text = "";
            OutputTextBox.Text = matrices.Count + " matrices:";
            OutputTextBox.AppendText(Environment.NewLine);
            for(int i = 0; i < matrices.Count; i++)
            {
                OutputTextBox.Text += "[" + i + "] = \"" + matrices[i].Name + "\"";
                matrices[i].OutputRangesOfMatrix(OutputTextBox);
                matrices[i].OutputValuesDifferentFromDefaultOne(OutputTextBox, matrices[i].DefaultNumber);
                OutputTextBox.AppendText(Environment.NewLine);
            }
        }

        private void DeleteMatrixByNameButton_Click(object sender, EventArgs e)
        {
            if (DeleteMatrixNyNameComboBox.SelectedIndex != -1)
            {
                foreach (CSparseMatrix matrix in matrices)
                {
                    if (matrix.Name == DeleteMatrixNyNameComboBox.SelectedItem.ToString())
                    {
                        SetComboBoxesToNoneSelectedItem();
                        DeleteItemFromComboBoxes(matrix.Name);
                        matrices.Remove(matrix);
                        return;
                    }
                }
            }
            else
            {
                ShowMessage("You should choose matrix to delete.", "Error");
            }
        }

        private void SetComboBoxesToNoneSelectedItem()
        {
            ShowMatrixByNameComboBox.SelectedIndex = -1;
            DeleteMatrixNyNameComboBox.SelectedIndex = -1;
            RenameMatrixByOldNameComboBox.SelectedIndex = -1;
            CreateCloneOfMatrixByNameComboBox.SelectedIndex = -1;
            AddNewValueToMatrixByNameComboBox.SelectedIndex = -1;
        }

        private void DeleteItemFromComboBoxes(string matrixName)
        {
            ShowMatrixByNameComboBox.Items.Remove(matrixName);
            DeleteMatrixNyNameComboBox.Items.Remove(matrixName);
            RenameMatrixByOldNameComboBox.Items.Remove(matrixName);
            CreateCloneOfMatrixByNameComboBox.Items.Remove(matrixName);
            AddNewValueToMatrixByNameComboBox.Items.Remove(matrixName);
        }

        private void DeleteAllMatricesTextBox_Click(object sender, EventArgs e)
        {
            foreach(CSparseMatrix matrix in matrices)
            {
                DeleteItemFromComboBoxes(matrix.Name);
            }
            SetComboBoxesToNoneSelectedItem();
            matrices.Clear();
        }

        private void RenameMatrixButton_Click(object sender, EventArgs e)
        {
            if (RenameMatrixByOldNameComboBox.SelectedIndex != -1)
            {
                foreach (CSparseMatrix matrix in matrices)
                {
                    if (matrix.Name == RenameMatrixByOldNameComboBox.SelectedItem.ToString())
                    {
                        string oldName = matrix.Name;
                        if(NewNameOfMatrixToRenameTextBox.Text == "")
                        {
                            matrix.SetDefaultName();
                            ShowMessage("New name was not entered, so matrix name was renamed to " + matrix.Name, "Information");
                        }
                        else
                        {
                            string name = NewNameOfMatrixToRenameTextBox.Text;
                            if (DoesNameOfMatrixAlreadyExist(name))
                            {
                                do
                                {
                                    name += "_1";
                                }
                                while (DoesNameOfMatrixAlreadyExist(name));
                                ShowMessage("You've entered the name that is already exists, so we added postfix \"_1\"", "Information");
                            }
                            matrix.Name = name;
                        }
                        SetComboBoxesToNoneSelectedItem();
                        DeleteItemFromComboBoxes(oldName);
                        AddItemToComboBoxes(matrix.Name);
                        NewNameOfMatrixToRenameTextBox.Text = "";
                        return;
                    }
                }
            }
            else
            {
                ShowMessage("You should choose matrix to rename.", "Error");
            }
        }
        private void CloneMatrixButton_Click(object sender, EventArgs e)
        {
            if (CreateCloneOfMatrixByNameComboBox.SelectedIndex != -1)
            {
                foreach(CSparseMatrix matrix in matrices)
                {
                    if (matrix.Name == CreateCloneOfMatrixByNameComboBox.SelectedItem.ToString())
                    {
                        CSparseMatrix clonedMatrix = (CSparseMatrix)matrix.Clone();
                        SetComboBoxesToNoneSelectedItem();
                        AddItemToComboBoxes(clonedMatrix.Name);
                        matrices.Add(clonedMatrix);
                        return;
                    }
                }
                foreach (CSparseMatrix matrix in matrices)
                {
                    if (matrix.Name == CreateCloneOfMatrixByNameComboBox.SelectedItem.ToString())
                    {
                        CSparseMatrix clonedMatrix = (CSparseMatrix)matrix.Clone();
                        SetComboBoxesToNoneSelectedItem();
                        AddItemToComboBoxes(clonedMatrix.Name);
                        matrices.Add(clonedMatrix);
                        return;
                    }
                }
            }
            else
            {
                ShowMessage("You should choose matrix to clone from.", "Error");
            }
        }

        private void AddValueToMatrixButton_Click(object sender, EventArgs e)
        {
            if (AddNewValueToMatrixByNameComboBox.SelectedIndex != -1)
            {
                string value = ValueForMatrixCellTextBox.Text;
                string indexes = IndexesOfCellToAddValueTextBox.Text;
                if (value != "" && indexes!= "")
                {
                    foreach (CSparseMatrix matrix in matrices)
                    {
                        if (matrix.Name == AddNewValueToMatrixByNameComboBox.SelectedItem.ToString())
                        {
                            matrix.SetValueIntoCell(int.Parse(value), ParseStringOfRangesForAddingValueIntoCell(indexes, matrix.DimensionsRanges), matrix.DefaultNumber);
                            SetComboBoxesToNoneSelectedItem();
                            ValueForMatrixCellTextBox.Text = "";
                            IndexesOfCellToAddValueTextBox.Text = "";
                            return;
                        }
                    }
                }
                else
                {
                    ShowMessage("You should fill all fields to add value", "Error");
                }
            }
            else ShowMessage("You should choose matrix to add value", "Error");
        }

        private List<int> ParseStringOfRangesForAddingValueIntoCell(string indexesOfCell, List<int> rangesOfMatrix)
        {
            MatchCollection matchList = Regex.Matches(indexesOfCell, "([1-9][0-9]*)|0");
            List<int> enteredRanges = matchList.Cast<Match>().Select(match => int.Parse(match.Value)).ToList();
            bool wasSomeIndexOutFromRange = false;
            for (int i = 0; i < enteredRanges.Count; i++)
            {
                if (enteredRanges[i] < 0 || enteredRanges[i] >= rangesOfMatrix[i])
                {
                    wasSomeIndexOutFromRange = true;
                    enteredRanges[i] = 0;
                }
            }
            if(enteredRanges.Count > rangesOfMatrix.Count)
            {
                while(enteredRanges.Count > rangesOfMatrix.Count)
                {
                    enteredRanges.RemoveAt(enteredRanges.Count - 1);
                }
                ShowMessage("You've entered too many arguments, so we will use only the number we need", "Information");
            }
            else if(enteredRanges.Count < rangesOfMatrix.Count)
            {
                while (enteredRanges.Count < rangesOfMatrix.Count)
                {
                    enteredRanges.Add(0);
                }
                ShowMessage("You've entered less arguments then needed, so we will fill empty indexes by 0", "Information");
            }
            if(wasSomeIndexOutFromRange)
            {
                ShowMessage("You have entered invalid specific index, so it was changed to 0 index", "Information");
            }
            return enteredRanges;
        }

        private void ShowMessage(string message, string headerText)
        {
            MessageBox.Show(message,
                    headerText,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
        }

        private void IgnoreNonPositiveNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            char pressedKeyCharCode = e.KeyChar;
            const int CHARCODE_OF_DELETE_BUTTON = 8;
            const int CHARCODE_OF_ENTER_BUTTON = 13;
            if (!Char.IsDigit(pressedKeyCharCode) &&
                pressedKeyCharCode != CHARCODE_OF_DELETE_BUTTON &&
                pressedKeyCharCode != CHARCODE_OF_ENTER_BUTTON)
            {
                ShowMessage("You should enter non-positive number!", "Error");
                e.Handled = true;
            }
        }

        private void IgnoreNotNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            char pressedKeyCharCode = e.KeyChar;
            const int CHARCODE_OF_DELETE_BUTTON = 8;
            const int CHARCODE_OF_ENTER_BUTTON = 13;
            const int CHARCODE_OF_MINUS_BUTTON = 45;
            if (!Char.IsDigit(pressedKeyCharCode) &&
                pressedKeyCharCode != CHARCODE_OF_DELETE_BUTTON &&
                pressedKeyCharCode != CHARCODE_OF_ENTER_BUTTON &&
                pressedKeyCharCode != CHARCODE_OF_MINUS_BUTTON)
            {
                ShowMessage("You should enter number!", "Error");
                e.Handled = true;
            }
        }

        private void NewMatrixRangesOfDimensionsTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char pressedKeyCharCode = e.KeyChar;
            const int CHARCODE_OF_DELETE_BUTTON = 8;
            const int CHARCODE_OF_ENTER_BUTTON = 13;
            const int CHARCODE_OF_SPACE_BUTTON = 32;
            if (!Char.IsDigit(pressedKeyCharCode) &&
                pressedKeyCharCode != CHARCODE_OF_DELETE_BUTTON &&
                pressedKeyCharCode != CHARCODE_OF_ENTER_BUTTON &&
                pressedKeyCharCode != CHARCODE_OF_SPACE_BUTTON)
            {
                ShowMessage("You should enter ranges of positive numbers!", "Error");
                e.Handled = true;
            }
        }

        private void AddValueIntoMatrixRangexTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char pressedKeyCharCode = e.KeyChar;
            const int CHARCODE_OF_DELETE_BUTTON = 8;
            const int CHARCODE_OF_ENTER_BUTTON = 13;
            const int CHARCODE_OF_SPACE_BUTTON = 32;
            if (!Char.IsDigit(pressedKeyCharCode) &&
                pressedKeyCharCode != CHARCODE_OF_DELETE_BUTTON &&
                pressedKeyCharCode != CHARCODE_OF_ENTER_BUTTON &&
                pressedKeyCharCode != CHARCODE_OF_SPACE_BUTTON)
            {
                ShowMessage("You should enter only positive numbers!", "Error");
                e.Handled = true;
            }
        }
    }
}
