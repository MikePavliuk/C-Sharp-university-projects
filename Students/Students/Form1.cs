using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    public partial class StudentsForm : Form
    {
        static int idCounter = 0;

        class Student
        {
            public int id;
            public string name;
            public int age;
            public int weight;
            public int mark;

            public Student(string name, int age, int weight, int mark)
            {
                this.name = name;
                this.age = age;
                this.weight = weight;
                this.mark = mark;
                id = ++idCounter;
            }
        }

        class StudentsGroup
        {
            public string nameOfGroup;
            public List<Student> students = new List<Student>();

            public StudentsGroup(string nameOfGroup) {
                this.nameOfGroup = nameOfGroup;
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

            public static void SortGroupOfStudentsByAge(StudentsGroup group)
            {
                group.students.Sort(delegate(Student student1, Student student2)
                {
                    return student1.age.CompareTo(student2.age);
                });
            }
            public static void SortGroupOfStudentsByWeight(StudentsGroup group)
            {
                group.students.Sort(delegate(Student student1, Student student2)
                {
                    return student1.weight.CompareTo(student2.weight);
                });
            }

            public static void SortGroupOfStudentsByMark(StudentsGroup group)
            {
                group.students.Sort(delegate(Student student1, Student student2)
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
            markToCompareWithForFiltering = int.Parse(MarkForFilteringComboBox.Items[0].ToString());
            MarksComboBox.SelectedItem = MarksComboBox.Items[0];
        }

        private void AddNewStudentsGroup(string nameOfGroup) {
            groupsOfStudents.Add(new StudentsGroup(nameOfGroup));
            GroupComboBox.Items.Add(nameOfGroup);
        }

        private void CreateGroupButton_Click(object sender, EventArgs e)
        {
            string nameOfGroup = GroupNameTextBox.Text;
            if (nameOfGroup == "")
            {
                ShowErrorMessage("You should fill text box to add new group!");
            }
            else if (doesNameExistsInGroupsOfStudents(nameOfGroup))
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

        private bool doesNameExistsInGroupsOfStudents(string enteredNameOfGroup)
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
        }

        private void AddStudentToGridView(string nameOfGroup, Student student)
        {
            StudentsDataGridView.Rows.Add(student.id, nameOfGroup, student.name, student.age, student.weight, student.mark);
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

                selectedGroup.students.Remove(selectedStudent);
                senderGrid.Rows.RemoveAt(e.RowIndex);
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

        private void AgeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IgnoreNotIntegerInTextBox(e);
        }

        private void WeightTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}