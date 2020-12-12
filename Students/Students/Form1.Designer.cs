namespace Students
{
    partial class StudentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentsDataGridView = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteStudentButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.StudentGroupBox = new System.Windows.Forms.GroupBox();
            this.MarksComboBox = new System.Windows.Forms.ComboBox();
            this.GroupComboBox = new System.Windows.Forms.ComboBox();
            this.NameOfGroup = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.MarkLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.GroupsGroupBox = new System.Windows.Forms.GroupBox();
            this.CreateGroupButton = new System.Windows.Forms.Button();
            this.GroupNameTextBox = new System.Windows.Forms.TextBox();
            this.TableSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.MarkForFilteringComboBox = new System.Windows.Forms.ComboBox();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.ConfirmSortingPropertyButton = new System.Windows.Forms.Button();
            this.PropertyForSortingByTextBox = new System.Windows.Forms.TextBox();
            this.SortByLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).BeginInit();
            this.StudentGroupBox.SuspendLayout();
            this.GroupsGroupBox.SuspendLayout();
            this.TableSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentsDataGridView
            // 
            this.StudentsDataGridView.AllowUserToAddRows = false;
            this.StudentsDataGridView.AllowUserToResizeColumns = false;
            this.StudentsDataGridView.AllowUserToResizeRows = false;
            this.StudentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.GroupColumn,
            this.NameColumn,
            this.AgeColumn,
            this.WeightColumn,
            this.MarkColumn,
            this.DeleteStudentButton});
            this.StudentsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.StudentsDataGridView.Location = new System.Drawing.Point(190, 6);
            this.StudentsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.StudentsDataGridView.Name = "StudentsDataGridView";
            this.StudentsDataGridView.ReadOnly = true;
            this.StudentsDataGridView.RowHeadersWidth = 82;
            this.StudentsDataGridView.RowTemplate.Height = 33;
            this.StudentsDataGridView.Size = new System.Drawing.Size(635, 466);
            this.StudentsDataGridView.TabIndex = 0;
            this.StudentsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsDataGridView_CellContentClick);
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.MinimumWidth = 10;
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Width = 50;
            // 
            // GroupColumn
            // 
            this.GroupColumn.HeaderText = "Group";
            this.GroupColumn.MinimumWidth = 10;
            this.GroupColumn.Name = "GroupColumn";
            this.GroupColumn.ReadOnly = true;
            this.GroupColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GroupColumn.Width = 80;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.MinimumWidth = 10;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AgeColumn
            // 
            this.AgeColumn.HeaderText = "Age";
            this.AgeColumn.MinimumWidth = 10;
            this.AgeColumn.Name = "AgeColumn";
            this.AgeColumn.ReadOnly = true;
            this.AgeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AgeColumn.Width = 80;
            // 
            // WeightColumn
            // 
            this.WeightColumn.HeaderText = "Weight";
            this.WeightColumn.MinimumWidth = 10;
            this.WeightColumn.Name = "WeightColumn";
            this.WeightColumn.ReadOnly = true;
            this.WeightColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WeightColumn.Width = 80;
            // 
            // MarkColumn
            // 
            this.MarkColumn.HeaderText = "Mark from C#";
            this.MarkColumn.MinimumWidth = 10;
            this.MarkColumn.Name = "MarkColumn";
            this.MarkColumn.ReadOnly = true;
            this.MarkColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.MarkColumn.Width = 80;
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.HeaderText = "Action";
            this.DeleteStudentButton.MinimumWidth = 10;
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.ReadOnly = true;
            this.DeleteStudentButton.Text = "Delete";
            this.DeleteStudentButton.UseColumnTextForButtonValue = true;
            this.DeleteStudentButton.Width = 80;
            // 
            // StudentGroupBox
            // 
            this.StudentGroupBox.Controls.Add(this.MarksComboBox);
            this.StudentGroupBox.Controls.Add(this.GroupComboBox);
            this.StudentGroupBox.Controls.Add(this.NameOfGroup);
            this.StudentGroupBox.Controls.Add(this.WeightTextBox);
            this.StudentGroupBox.Controls.Add(this.AgeTextBox);
            this.StudentGroupBox.Controls.Add(this.NameTextBox);
            this.StudentGroupBox.Controls.Add(this.MarkLabel);
            this.StudentGroupBox.Controls.Add(this.WeightLabel);
            this.StudentGroupBox.Controls.Add(this.AgeLabel);
            this.StudentGroupBox.Controls.Add(this.NameLabel);
            this.StudentGroupBox.Location = new System.Drawing.Point(6, 83);
            this.StudentGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.StudentGroupBox.Name = "StudentGroupBox";
            this.StudentGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.StudentGroupBox.Size = new System.Drawing.Size(180, 150);
            this.StudentGroupBox.TabIndex = 1;
            this.StudentGroupBox.TabStop = false;
            this.StudentGroupBox.Text = "Information about student";
            // 
            // MarksComboBox
            // 
            this.MarksComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarksComboBox.FormattingEnabled = true;
            this.MarksComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.MarksComboBox.Location = new System.Drawing.Point(87, 92);
            this.MarksComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.MarksComboBox.Name = "MarksComboBox";
            this.MarksComboBox.Size = new System.Drawing.Size(83, 21);
            this.MarksComboBox.TabIndex = 9;
            // 
            // GroupComboBox
            // 
            this.GroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupComboBox.FormattingEnabled = true;
            this.GroupComboBox.Location = new System.Drawing.Point(87, 118);
            this.GroupComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.GroupComboBox.Name = "GroupComboBox";
            this.GroupComboBox.Size = new System.Drawing.Size(83, 21);
            this.GroupComboBox.TabIndex = 6;
            // 
            // NameOfGroup
            // 
            this.NameOfGroup.AutoSize = true;
            this.NameOfGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.NameOfGroup.Location = new System.Drawing.Point(3, 121);
            this.NameOfGroup.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameOfGroup.Name = "NameOfGroup";
            this.NameOfGroup.Size = new System.Drawing.Size(77, 13);
            this.NameOfGroup.TabIndex = 3;
            this.NameOfGroup.Text = "Name of group";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(87, 69);
            this.WeightTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(83, 20);
            this.WeightTextBox.TabIndex = 2;
            this.WeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WeightTextBox_KeyPress);
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(87, 44);
            this.AgeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(83, 20);
            this.AgeTextBox.TabIndex = 2;
            this.AgeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AgeTextBox_KeyPress);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(87, 21);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(83, 20);
            this.NameTextBox.TabIndex = 2;
            // 
            // MarkLabel
            // 
            this.MarkLabel.AutoSize = true;
            this.MarkLabel.Location = new System.Drawing.Point(2, 95);
            this.MarkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MarkLabel.Name = "MarkLabel";
            this.MarkLabel.Size = new System.Drawing.Size(71, 13);
            this.MarkLabel.TabIndex = 2;
            this.MarkLabel.Text = "Mark from C#";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(3, 71);
            this.WeightLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(41, 13);
            this.WeightLabel.TabIndex = 2;
            this.WeightLabel.Text = "Weight";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(3, 47);
            this.AgeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(26, 13);
            this.AgeLabel.TabIndex = 2;
            this.AgeLabel.Text = "Age";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 22);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name";
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(90, 237);
            this.AddStudentButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(84, 20);
            this.AddStudentButton.TabIndex = 2;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudentButton_Click);
            // 
            // GroupsGroupBox
            // 
            this.GroupsGroupBox.Controls.Add(this.CreateGroupButton);
            this.GroupsGroupBox.Controls.Add(this.GroupNameTextBox);
            this.GroupsGroupBox.Location = new System.Drawing.Point(6, 6);
            this.GroupsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.GroupsGroupBox.Name = "GroupsGroupBox";
            this.GroupsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.GroupsGroupBox.Size = new System.Drawing.Size(180, 57);
            this.GroupsGroupBox.TabIndex = 5;
            this.GroupsGroupBox.TabStop = false;
            this.GroupsGroupBox.Text = "Group";
            // 
            // CreateGroupButton
            // 
            this.CreateGroupButton.Location = new System.Drawing.Point(94, 21);
            this.CreateGroupButton.Margin = new System.Windows.Forms.Padding(2);
            this.CreateGroupButton.Name = "CreateGroupButton";
            this.CreateGroupButton.Size = new System.Drawing.Size(74, 20);
            this.CreateGroupButton.TabIndex = 6;
            this.CreateGroupButton.Text = "Create group";
            this.CreateGroupButton.UseVisualStyleBackColor = true;
            this.CreateGroupButton.Click += new System.EventHandler(this.CreateGroupButton_Click);
            // 
            // GroupNameTextBox
            // 
            this.GroupNameTextBox.Location = new System.Drawing.Point(6, 21);
            this.GroupNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GroupNameTextBox.Name = "GroupNameTextBox";
            this.GroupNameTextBox.Size = new System.Drawing.Size(70, 20);
            this.GroupNameTextBox.TabIndex = 6;
            // 
            // TableSettingsGroupBox
            // 
            this.TableSettingsGroupBox.Controls.Add(this.MarkForFilteringComboBox);
            this.TableSettingsGroupBox.Controls.Add(this.FilterLabel);
            this.TableSettingsGroupBox.Controls.Add(this.ConfirmSortingPropertyButton);
            this.TableSettingsGroupBox.Controls.Add(this.PropertyForSortingByTextBox);
            this.TableSettingsGroupBox.Controls.Add(this.SortByLabel);
            this.TableSettingsGroupBox.Location = new System.Drawing.Point(6, 262);
            this.TableSettingsGroupBox.Name = "TableSettingsGroupBox";
            this.TableSettingsGroupBox.Size = new System.Drawing.Size(180, 153);
            this.TableSettingsGroupBox.TabIndex = 6;
            this.TableSettingsGroupBox.TabStop = false;
            this.TableSettingsGroupBox.Text = "Table";
            // 
            // MarkForFilteringComboBox
            // 
            this.MarkForFilteringComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarkForFilteringComboBox.FormattingEnabled = true;
            this.MarkForFilteringComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.MarkForFilteringComboBox.Location = new System.Drawing.Point(87, 116);
            this.MarkForFilteringComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.MarkForFilteringComboBox.Name = "MarkForFilteringComboBox";
            this.MarkForFilteringComboBox.Size = new System.Drawing.Size(81, 21);
            this.MarkForFilteringComboBox.TabIndex = 8;
            this.MarkForFilteringComboBox.SelectedIndexChanged += new System.EventHandler(this.MarkForFilteringComboBox_SelectedIndexChanged);
            // 
            // FilterLabel
            // 
            this.FilterLabel.Location = new System.Drawing.Point(3, 84);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(177, 30);
            this.FilterLabel.TabIndex = 7;
            this.FilterLabel.Text = "Show students with equal or higher mark than";
            // 
            // ConfirmSortingPropertyButton
            // 
            this.ConfirmSortingPropertyButton.Location = new System.Drawing.Point(93, 41);
            this.ConfirmSortingPropertyButton.Name = "ConfirmSortingPropertyButton";
            this.ConfirmSortingPropertyButton.Size = new System.Drawing.Size(75, 20);
            this.ConfirmSortingPropertyButton.TabIndex = 7;
            this.ConfirmSortingPropertyButton.Text = "Sort";
            this.ConfirmSortingPropertyButton.UseVisualStyleBackColor = true;
            this.ConfirmSortingPropertyButton.Click += new System.EventHandler(this.ConfirmSortingPropertyButton_Click);
            // 
            // PropertyForSortingByTextBox
            // 
            this.PropertyForSortingByTextBox.Location = new System.Drawing.Point(6, 41);
            this.PropertyForSortingByTextBox.Name = "PropertyForSortingByTextBox";
            this.PropertyForSortingByTextBox.Size = new System.Drawing.Size(81, 20);
            this.PropertyForSortingByTextBox.TabIndex = 7;
            // 
            // SortByLabel
            // 
            this.SortByLabel.AutoSize = true;
            this.SortByLabel.Location = new System.Drawing.Point(3, 25);
            this.SortByLabel.Name = "SortByLabel";
            this.SortByLabel.Size = new System.Drawing.Size(153, 13);
            this.SortByLabel.TabIndex = 7;
            this.SortByLabel.Text = "Sort students of same group by";
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 478);
            this.Controls.Add(this.TableSettingsGroupBox);
            this.Controls.Add(this.GroupsGroupBox);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.StudentGroupBox);
            this.Controls.Add(this.StudentsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students Form";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDataGridView)).EndInit();
            this.StudentGroupBox.ResumeLayout(false);
            this.StudentGroupBox.PerformLayout();
            this.GroupsGroupBox.ResumeLayout(false);
            this.GroupsGroupBox.PerformLayout();
            this.TableSettingsGroupBox.ResumeLayout(false);
            this.TableSettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentsDataGridView;
        private System.Windows.Forms.GroupBox StudentGroupBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label MarkLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Label NameOfGroup;
        private System.Windows.Forms.ComboBox GroupComboBox;
        private System.Windows.Forms.GroupBox GroupsGroupBox;
        private System.Windows.Forms.Button CreateGroupButton;
        private System.Windows.Forms.TextBox GroupNameTextBox;
        private System.Windows.Forms.GroupBox TableSettingsGroupBox;
        private System.Windows.Forms.Label SortByLabel;
        private System.Windows.Forms.TextBox PropertyForSortingByTextBox;
        private System.Windows.Forms.Button ConfirmSortingPropertyButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AgeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteStudentButton;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.ComboBox MarkForFilteringComboBox;
        private System.Windows.Forms.ComboBox MarksComboBox;
    }
}

