using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    public partial class StudentsForm : Form
    {
        static int studentIdCounter = 0;
        static int employeeIdCounter = 0;

        class Student
        {
            public int id;
            public string name;
            public int age;
            public int weight;
            public double mark;
            public List<int> marks = new List<int>();

            public Student(string name, int age, int weight, int mark)
            {
                this.name = name;
                this.age = age;
                this.weight = weight;
                marks.Add(mark);
                this.mark = mark;
                id = ++studentIdCounter;
            }
        }

        class EmployeeOfDeansOffice
        {
            public string name;
            public string email;
            public int id;

            public EmployeeOfDeansOffice(string name, string email)
            {
                this.name = name;
                this.email = email;
                id = ++employeeIdCounter;
            }
        }

        class StudentsGroup
        {
            public string nameOfGroup;
            public List<Student> students = new List<Student>();
            public List<EmployeeOfDeansOffice> employeesOfDeansOffice = new List<EmployeeOfDeansOffice>();
            public delegate void MarksHandlaer(Student student, EmployeeOfDeansOffice employee, string nameOfGroup);
            public event MarksHandlaer Notify;

            public StudentsGroup(string nameOfGroup) {
                this.nameOfGroup = nameOfGroup;
            }

            public void CalculateAverageMarkOfStudent(Student student)
            {
                double sumOfMarks = 0;
                foreach (int mark in student.marks)
                {
                    sumOfMarks += mark;
                }
                student.mark = sumOfMarks / student.marks.Count();

                if (student.mark < 3)
                {
                    foreach(EmployeeOfDeansOffice currentEmployee in employeesOfDeansOffice)
                    {
                        Notify?.Invoke(student, currentEmployee, nameOfGroup);
                    }
                    
                }
            }

            public static StudentsGroup operator +(StudentsGroup group, Student student)
            {
                group.students.Add(student);
                return group;
            }
            public static StudentsGroup operator -(StudentsGroup group, Student student)
            {
                group.students.Remove(student);
                return group;
            }

            public static StudentsGroup operator +(StudentsGroup group, EmployeeOfDeansOffice employee)
            {
                group.employeesOfDeansOffice.Add(employee);
                return group;
            }
            public static StudentsGroup operator -(StudentsGroup group, EmployeeOfDeansOffice employee)
            {
                group.employeesOfDeansOffice.Remove(employee);
                return group;
            }

            public static void SortGroupOfStudentsByAge(StudentsGroup group)
            {
                group.students.Sort(delegate (Student student1, Student student2)
                {
                    return student1.age.CompareTo(student2.age);
                });
            }
            public static void SortGroupOfStudentsByWeight(StudentsGroup group)
            {
                group.students.Sort(delegate (Student student1, Student student2)
                {
                    return student1.weight.CompareTo(student2.weight);
                });
            }

            public static void SortGroupOfStudentsByMark(StudentsGroup group)
            {
                group.students.Sort(delegate (Student student1, Student student2)
                {
                    return student1.mark.CompareTo(student2.mark);
                });
            }
        }

        delegate void DelegateSortBy(StudentsGroup group);
        List<StudentsGroup> groupsOfStudents = new List<StudentsGroup>();
        Dictionary<string, DelegateSortBy> methodOfSorting = new Dictionary<string, DelegateSortBy> {
            ["age"] = new DelegateSortBy(StudentsGroup.SortGroupOfStudentsByAge),
            ["weight"] = new DelegateSortBy(StudentsGroup.SortGroupOfStudentsByWeight),
            ["mark"] = new DelegateSortBy(StudentsGroup.SortGroupOfStudentsByMark)
        };
        int markToCompareWithForFiltering;

        public StudentsForm()
        {
            InitializeComponent();
            SetInitialSettingsForComboBoxes();
        }

        private void SetInitialSettingsForComboBoxes()
        {
            AddNewStudentsGroup("KN-21");
            GroupComboBox.SelectedItem = GroupComboBox.Items[0];
            MarkForFilteringComboBox.SelectedItem = MarkForFilteringComboBox.Items[0];
            AddMarkToStudentComboBox.SelectedItem = AddMarkToStudentComboBox.Items[0];
            markToCompareWithForFiltering = int.Parse(MarkForFilteringComboBox.Items[0].ToString());
            MarksComboBox.SelectedItem = MarksComboBox.Items[0];
            EditStudentButton.Enabled = false;
            AddMarkToStudentButton.Enabled = false;
            EditEmployeeButton.Enabled = false;
        }

        private void AddNewStudentsGroup(string nameOfGroup) {
            StudentsGroup newGroup = new StudentsGroup(nameOfGroup);
            newGroup.Notify += SendWarningMail;
            groupsOfStudents.Add(newGroup);
            GroupComboBox.Items.Add(nameOfGroup);
            EditNameOfGroupComboBox.Items.Add(nameOfGroup);
            EmployeeGroupComboBox.Items.Add(nameOfGroup);
            EditEmployeeGroupComboBox.Items.Add(nameOfGroup);
        }

        private void SendWarningMail(Student student, EmployeeOfDeansOffice employee, string nameOfGroup)
        {
            string message = "Dear " + employee.name + ", student of " + nameOfGroup + " group " + student.name + " has bad average mark from C#: " + student.mark.ToString("F", CultureInfo.InvariantCulture);
            MessageBox.Show(message,
                   employee.email,
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning,
                   MessageBoxDefaultButton.Button1);
        }

        private void CreateGroupButton_Click(object sender, EventArgs e)
        {
            string nameOfGroup = GroupNameTextBox.Text;
            if (nameOfGroup == "")
            {
                ShowErrorMessage("You should fill text box to add new group!");
            }
            else if (DoesNameExistsInGroupsOfStudents(nameOfGroup))
            {
                ShowErrorMessage("This group have been created before!");
            }
            else
            {
                AddNewStudentsGroup(nameOfGroup);
            }
            GroupNameTextBox.Text = null;
        }

        private void ShowErrorMessage(string textOfMessage)
        {
            MessageBox.Show(textOfMessage,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
        }

        private bool DoesNameExistsInGroupsOfStudents(string enteredNameOfGroup)
        {
            foreach(StudentsGroup group in groupsOfStudents)
            {
                if (group.nameOfGroup == enteredNameOfGroup)
                {
                    return true;
                }
            }
            return false;
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            if (name == "" || AgeTextBox.Text == "" || WeightTextBox.Text == "") {
                ShowErrorMessage("You should fill all information about student to add him to the group!");
                return;
            }
            int age = int.Parse(AgeTextBox.Text);
            int weight = int.Parse(WeightTextBox.Text);
            int mark = int.Parse(MarksComboBox.SelectedItem.ToString());
            string selectedGroupName = GroupComboBox.SelectedItem.ToString();

            StudentsGroup selectedGroup = groupsOfStudents.Find(group => group.nameOfGroup == selectedGroupName);
            Student student = new Student(name, age, weight, mark);
             
            selectedGroup += student;
            if(mark >= markToCompareWithForFiltering)
            {
                AddStudentToGridView(selectedGroupName, student);
            }
            ClearStudentsTextBoxes();
            MakeStudentToBeEditible(student.id);
            AddStudentToMarksOfStudentsGridView(student);
        }

        private void AddStudentToGridView(string nameOfGroup, Student student)
        {
            StudentsDataGridView.Rows.Add(student.id, nameOfGroup, student.name, student.age, student.weight, student.mark);
        }

        private void MakeStudentToBeEditible(int studentId)
        {
            StudentIdComboBox.Items.Add(studentId);
            AddMarkStudentIdComboBox.Items.Add(studentId);
        }

        private void AddStudentToMarksOfStudentsGridView(Student student)
        {
            MarksOfStudentsDataGridView.Rows.Add(student.id, student.mark);
        }

        private void ClearStudentsTextBoxes()
        {
            NameTextBox.Text = null;
            AgeTextBox.Text = null;
            WeightTextBox.Text = null;
            MarksComboBox.SelectedItem = MarksComboBox.Items[0];
            GroupComboBox.SelectedItem = GroupComboBox.Items[0];
        }

        private void ConfirmSortingPropertyButton_Click(object sender, EventArgs e)
        {
            string enteredPropertyOfSorting = PropertyForSortingByTextBox.Text.ToLower();
            if (doesSortingMethodExist(enteredPropertyOfSorting))
            {
                foreach(StudentsGroup group in groupsOfStudents)
                {
                    methodOfSorting[enteredPropertyOfSorting].Invoke(group);
                }
                StudentsDataGridView.Rows.Clear();
                AddFilteredGroupsToGridView();
            } 
            else
            {
                ShowErrorMessage("There are only age/weight/mark property to sort by!");
            }
        }

        private bool doesSortingMethodExist(string enteredPropertyOfSorting)
        {
            foreach(string methodName in methodOfSorting.Keys)
            {
                if (methodName == enteredPropertyOfSorting)
                {
                    return true;
                }
            }
            return false;
        }

        private void StudentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                const int INDEX_OF_ID_COLUMN = 0;
                const int INDEX_OF_NAME_OF_GROUP_COLUMN = 1;

                string selectedGroupName = senderGrid.Rows[e.RowIndex].Cells[INDEX_OF_NAME_OF_GROUP_COLUMN].Value.ToString();
                int selectedStudentId = int.Parse(senderGrid.Rows[e.RowIndex].Cells[INDEX_OF_ID_COLUMN].Value.ToString());

                StudentsGroup selectedGroup = groupsOfStudents.Find(group => group.nameOfGroup == selectedGroupName);
                Student selectedStudent = selectedGroup.students.Find(student => student.id == selectedStudentId);
                StudentIdComboBox.Items.Remove(selectedStudentId);
                AddMarkStudentIdComboBox.Items.Remove(selectedStudentId);

                foreach (DataGridViewRow row in MarksOfStudentsDataGridView.Rows)
                {
                    if (row.Cells[0].Value.ToString().Equals(selectedStudentId.ToString()))
                    {
                        MarksOfStudentsDataGridView.Rows.Remove(row);
                        break;
                    }
                }

                selectedGroup -= selectedStudent;
                senderGrid.Rows.RemoveAt(e.RowIndex);
                ClearEditStudentFields();
                ClearAddMarkToStudentFields();
            }
        }

        private void AddFilteredGroupsToGridView()
        {
            foreach (StudentsGroup group in groupsOfStudents)
            {
                List<Student> groupOfStudentsFiltered = group.students
                    .Where(student => student.mark >= markToCompareWithForFiltering)
                    .ToList();
                foreach (Student student in groupOfStudentsFiltered)
                { 
                    AddStudentToGridView(group.nameOfGroup, student);
                }
            }
        }

        private void MarkForFilteringComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StudentsDataGridView.Rows.Clear();
            markToCompareWithForFiltering = int.Parse(MarkForFilteringComboBox.SelectedItem.ToString());
            AddFilteredGroupsToGridView();
        }

        private void IntegerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IgnoreNotIntegerInTextBox(e);
        }

        private void IgnoreNotIntegerInTextBox(KeyPressEventArgs e)
        {
            char pressedKeyCharCode = e.KeyChar;
            const int CHARCODE_OF_DELETE_BUTTON = 8;
            const int CHARCODE_OF_ENTER_BUTTON = 13;
            if (!Char.IsDigit(pressedKeyCharCode) &&
                pressedKeyCharCode != CHARCODE_OF_DELETE_BUTTON &&
                pressedKeyCharCode != CHARCODE_OF_ENTER_BUTTON)
            {
                ShowErrorMessage("You should enter integer number!");
                e.Handled = true;
            }
        }

        private void StudentIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentIdComboBox.SelectedIndex > -1) EditStudentButton.Enabled = true;
            else return;

            int selectedStudentId = int.Parse(StudentIdComboBox.SelectedItem.ToString());
            int indexOfSelectedGroup = 0;
            Student selectedStudent = null;
            FindStudentInGroupById(selectedStudentId, ref selectedStudent, ref indexOfSelectedGroup);
            FillTextBoxesWithCurrentStudentInfo(indexOfSelectedGroup, selectedStudent);
        }

        private void FindStudentInGroupById(int selectedStudentId, ref Student selectedStudent, ref int indexOfSelecetedGroup)
        {
            foreach (StudentsGroup group in groupsOfStudents)
            {
                foreach (Student student in group.students)
                {
                    if (student.id == selectedStudentId)
                    {
                        indexOfSelecetedGroup = groupsOfStudents.IndexOf(group);
                        selectedStudent = student;
                        return;
                    }
                }
            }
        }

        private void FillTextBoxesWithCurrentStudentInfo(int indexOfSelectedGroup ,Student student)
        {
            EditNameOfStudentTextBox.Text = student.name.ToString();
            EditAgeOfStudentTextBox.Text = student.age.ToString();
            EditWeightOfStudentTextBox.Text = student.weight.ToString();
            EditNameOfGroupComboBox.SelectedIndex = indexOfSelectedGroup;
        }

        private void EditStudentButton_Click(object sender, EventArgs e)
        {
            string name = EditNameOfStudentTextBox.Text;
            if (name == "" || EditAgeOfStudentTextBox.Text == "" || EditWeightOfStudentTextBox.Text == "")
            {
                ShowErrorMessage("You should fill all field to edit his information!");
                return;
            }
            int age = int.Parse(EditAgeOfStudentTextBox.Text);
            int weight = int.Parse(EditWeightOfStudentTextBox.Text);
            string selectedGroupName = EditNameOfGroupComboBox.SelectedItem.ToString();
            int id = int.Parse(StudentIdComboBox.SelectedItem.ToString());

            StudentsGroup selectedGroup = groupsOfStudents.Find(group => group.nameOfGroup == selectedGroupName);
            Student selectedStudent = selectedGroup.students.Find(student => student.id == id);

            if (selectedStudent == null)
            {
                int indexOfSelectedGroup = 0;
                FindStudentInGroupById(id, ref selectedStudent, ref indexOfSelectedGroup);
                Student editedStudent = new Student(name, age, weight, 0);
                foreach(int mark in selectedStudent.marks)
                {
                    editedStudent.marks.Add(mark);
                }
                selectedGroup += editedStudent;
                selectedGroup.CalculateAverageMarkOfStudent(editedStudent);
                groupsOfStudents[indexOfSelectedGroup] -= selectedStudent;
                selectedGroup.students[selectedGroup.students.Count - 1].id = id;
                studentIdCounter--;
            }
            else
            {
                selectedStudent.name = name;
                selectedStudent.age = age;
                selectedStudent.weight = weight;
            }
            StudentsDataGridView.Rows.Clear();
            ClearEditStudentFields();
            AddFilteredGroupsToGridView();
        }

        private void ClearEditStudentFields()
        {
            EditNameOfStudentTextBox.Text = "";
            EditAgeOfStudentTextBox.Text = "";
            EditWeightOfStudentTextBox.Text = "";
            EditNameOfGroupComboBox.SelectedIndex = -1;
            StudentIdComboBox.SelectedIndex = -1;
            EditStudentButton.Enabled = false;
        }

        private void AddMarkStudentIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AddMarkStudentIdComboBox.SelectedIndex > -1) AddMarkToStudentButton.Enabled = true;
        }

        private void AddMarkToStudentButton_Click(object sender, EventArgs e)
        {
            int selectedStudentId = int.Parse(AddMarkStudentIdComboBox.SelectedItem.ToString());
            int selectedMark = int.Parse(AddMarkToStudentComboBox.SelectedItem.ToString());
            int indexOfSelectedGroup = 0;
            Student selectedStudent = null;
            FindStudentInGroupById(selectedStudentId, ref selectedStudent, ref indexOfSelectedGroup);
            selectedStudent.marks.Add(selectedMark);
            groupsOfStudents[indexOfSelectedGroup].CalculateAverageMarkOfStudent(selectedStudent);

            StudentsDataGridView.Rows.Clear();
            AddFilteredGroupsToGridView();
            ClearAddMarkToStudentFields();

            if (!(DoesColumnHeaderExist("Mark" + selectedStudent.marks.Count())))
            {
                DataGridViewTextBoxColumn newColumn = new DataGridViewTextBoxColumn();
                newColumn.HeaderText = "Mark" + selectedStudent.marks.Count();
                newColumn.Width = 50;
                MarksOfStudentsDataGridView.Columns.Add(newColumn);
            }
            AddMarkToNecessaryCell(selectedStudentId, selectedStudent.marks.Count(), selectedMark);
        }

        private void ClearAddMarkToStudentFields()
        {
            AddMarkStudentIdComboBox.SelectedIndex = -1;
            AddMarkToStudentComboBox.SelectedIndex = 0;
            AddMarkToStudentButton.Enabled = false;
        }


        private bool DoesColumnHeaderExist(string columnName)
        {
            foreach (DataGridViewColumn column in MarksOfStudentsDataGridView.Columns)
            {
                if (column.HeaderText == columnName) return true;
            }
            return false;
        }

        private void AddMarkToNecessaryCell(int studentId, int serialNumberOfMark, int mark)
        {
            foreach (DataGridViewRow row in MarksOfStudentsDataGridView.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(studentId.ToString()))
                {
                    MarksOfStudentsDataGridView.Rows[row.Index].Cells[serialNumberOfMark].Value = mark;
                    break;
                }
            }
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            string name = EmployeeNameTextBox.Text;
            string email = EmployeeEmailTextBox.Text;
            if (name == "" || email == "")
            {
                ShowErrorMessage("You should fill all information about employee to add him!");
                return;
            }
            string selectedGroupName = EmployeeGroupComboBox.SelectedItem.ToString();

            StudentsGroup selectedGroup = groupsOfStudents.Find(group => group.nameOfGroup == selectedGroupName);
            EmployeeOfDeansOffice employee = new EmployeeOfDeansOffice(name, email);

            selectedGroup += employee;

            AddEmployeeToGridView(selectedGroupName, employee);
            ClearEmployeeTextBoxes();
            MakeEmployeeToBeEditible(employee.id);
        }


        private void AddEmployeeToGridView(string group, EmployeeOfDeansOffice employee)
        {
            EmployeesDataGridView.Rows.Add(employee.id, group, employee.name, employee.email);
        }


        private void ClearEmployeeTextBoxes()
        {
            EmployeeNameTextBox.Text = "";
            EmployeeEmailTextBox.Text = "";
            EmployeeGroupComboBox.SelectedIndex = 0;
        }

        private void MakeEmployeeToBeEditible(int employeeId)
        {
            EmployeeIdComboBox.Items.Add(employeeId);
        }


        private void ClearEditEmployeeFields()
        {
            EditEmployeeNameTextBox.Text = "";
            EditEmployeeEmailTextBox.Text = "";
            EditEmployeeGroupComboBox.SelectedIndex = -1;
            EmployeeIdComboBox.SelectedIndex = -1;
            EditEmployeeButton.Enabled = false;
        }

        private void EmployeeIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EmployeeIdComboBox.SelectedIndex > -1) EditEmployeeButton.Enabled = true;
            else return;

            int selectedEmployeeId = int.Parse(EmployeeIdComboBox.SelectedItem.ToString());
            int indexOfSelectedGroup = 0;
            EmployeeOfDeansOffice selectedEmployee = null;
            FindEmployeeInGroupById(selectedEmployeeId, ref selectedEmployee, ref indexOfSelectedGroup);
            FillTextBoxesWithCurrentEmployeeInfo(indexOfSelectedGroup, selectedEmployee);
        }

        private void FindEmployeeInGroupById(int selectedEmployeeId, ref EmployeeOfDeansOffice selectedEmployee, ref int indexOfSelecetedGroup)
        {
            foreach (StudentsGroup group in groupsOfStudents)
            {
                foreach (EmployeeOfDeansOffice employee in group.employeesOfDeansOffice)
                {
                    if (employee.id == selectedEmployeeId)
                    {
                        indexOfSelecetedGroup = groupsOfStudents.IndexOf(group);
                        selectedEmployee = employee;
                        return;
                    }
                }
            }
        }

        private void FillTextBoxesWithCurrentEmployeeInfo(int indexOfSelectedGroup, EmployeeOfDeansOffice selectedEmployee)
        {
            EditEmployeeNameTextBox.Text = selectedEmployee.name;
            EditEmployeeEmailTextBox.Text = selectedEmployee.email;
            EditEmployeeGroupComboBox.SelectedIndex = indexOfSelectedGroup;
        }

        private void EditEmployeeButton_Click(object sender, EventArgs e)
        {
            string name = EditEmployeeNameTextBox.Text;
            string email = EditEmployeeEmailTextBox.Text;
            if (name == "" || email == "")
            {
                ShowErrorMessage("You should fill all information about employee to edit his info!");
                return;
            }
            string selectedGroupName = EditEmployeeGroupComboBox.SelectedItem.ToString();
            int id = int.Parse(EmployeeIdComboBox.SelectedItem.ToString());

            StudentsGroup selectedGroup = groupsOfStudents.Find(group => group.nameOfGroup == selectedGroupName);
            EmployeeOfDeansOffice selectedEmployee = selectedGroup.employeesOfDeansOffice.Find(employee => employee.id == id);

            if (selectedEmployee == null)
            {
                int indexOfSelectedGroup = 0;
                FindEmployeeInGroupById(id, ref selectedEmployee, ref indexOfSelectedGroup);
                EmployeeOfDeansOffice editedEmployee = new EmployeeOfDeansOffice(name, email);
                selectedGroup += selectedEmployee;
                groupsOfStudents[indexOfSelectedGroup] -= selectedEmployee;
                selectedGroup.employeesOfDeansOffice[selectedGroup.employeesOfDeansOffice.Count - 1].id = id;
                employeeIdCounter--;
            }
            else
            {
                selectedEmployee.name = name;
                selectedEmployee.email = email;
            }
            EmployeesDataGridView.Rows.Clear();
            AddEmployeesToGridView();
            ClearEditEmployeeFields();
        }

        private void AddEmployeesToGridView()
        {
            foreach(StudentsGroup group in groupsOfStudents)
            {
                foreach(EmployeeOfDeansOffice employee in group.employeesOfDeansOffice)
                {
                    AddEmployeeToGridView(group.nameOfGroup, employee);
                }
            }
        }

        private void EmployeesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                const int INDEX_OF_ID_COLUMN = 0;
                const int INDEX_OF_NAME_OF_GROUP_COLUMN = 1;

                string selectedGroupName = senderGrid.Rows[e.RowIndex].Cells[INDEX_OF_NAME_OF_GROUP_COLUMN].Value.ToString();
                int selectedEmployeeId = int.Parse(senderGrid.Rows[e.RowIndex].Cells[INDEX_OF_ID_COLUMN].Value.ToString());

                StudentsGroup selectedGroup = groupsOfStudents.Find(group => group.nameOfGroup == selectedGroupName);
                EmployeeOfDeansOffice selectedEmployee = selectedGroup.employeesOfDeansOffice.Find(employee => employee.id == selectedEmployeeId);
                EmployeeIdComboBox.Items.Remove(selectedEmployeeId);

                selectedGroup -= selectedEmployee;
                senderGrid.Rows.RemoveAt(e.RowIndex);
                ClearEditEmployeeFields();
            }
        }
    }
}