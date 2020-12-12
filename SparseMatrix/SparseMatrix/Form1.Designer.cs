namespace SparseMatrix
{
    partial class SparseMatrix
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddNewMatrixButton = new System.Windows.Forms.Button();
            this.NewMatrixDefaultValueTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NewMatrixRangesOfDimensionsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewMatrixNumberOfDimesionsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NewMatrixNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ShowAllMatricesButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DeleteMatrixNyNameComboBox = new System.Windows.Forms.ComboBox();
            this.DeleteMatrixByNameButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DeleteAllMatricesTextBox = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RenameMatrixByOldNameComboBox = new System.Windows.Forms.ComboBox();
            this.RenameMatrixButton = new System.Windows.Forms.Button();
            this.NewNameOfMatrixToRenameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ShowMatrixByNameComboBox = new System.Windows.Forms.ComboBox();
            this.ShowMatrixByNameButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CreateCloneOfMatrixByNameComboBox = new System.Windows.Forms.ComboBox();
            this.CloneMatrixButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.AddValueToMatrixButton = new System.Windows.Forms.Button();
            this.AddNewValueToMatrixByNameComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ValueForMatrixCellTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.IndexesOfCellToAddValueTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddNewMatrixButton);
            this.groupBox1.Controls.Add(this.NewMatrixDefaultValueTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NewMatrixRangesOfDimensionsTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NewMatrixNumberOfDimesionsTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NewMatrixNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add matrix";
            // 
            // AddNewMatrixButton
            // 
            this.AddNewMatrixButton.Location = new System.Drawing.Point(6, 145);
            this.AddNewMatrixButton.Name = "AddNewMatrixButton";
            this.AddNewMatrixButton.Size = new System.Drawing.Size(185, 20);
            this.AddNewMatrixButton.TabIndex = 4;
            this.AddNewMatrixButton.Text = "Add";
            this.AddNewMatrixButton.UseVisualStyleBackColor = true;
            this.AddNewMatrixButton.Click += new System.EventHandler(this.AddNewMatrixButton_Click);
            // 
            // NewMatrixDefaultValueTextBox
            // 
            this.NewMatrixDefaultValueTextBox.Location = new System.Drawing.Point(123, 119);
            this.NewMatrixDefaultValueTextBox.Name = "NewMatrixDefaultValueTextBox";
            this.NewMatrixDefaultValueTextBox.Size = new System.Drawing.Size(68, 20);
            this.NewMatrixDefaultValueTextBox.TabIndex = 1;
            this.NewMatrixDefaultValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IgnoreNotNumbers_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Default value";
            // 
            // NewMatrixRangesOfDimensionsTextBox
            // 
            this.NewMatrixRangesOfDimensionsTextBox.Location = new System.Drawing.Point(6, 90);
            this.NewMatrixRangesOfDimensionsTextBox.Name = "NewMatrixRangesOfDimensionsTextBox";
            this.NewMatrixRangesOfDimensionsTextBox.Size = new System.Drawing.Size(185, 20);
            this.NewMatrixRangesOfDimensionsTextBox.TabIndex = 1;
            this.NewMatrixRangesOfDimensionsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewMatrixRangesOfDimensionsTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ranges of dimensions (enter with space between)";
            // 
            // NewMatrixNumberOfDimesionsTextBox
            // 
            this.NewMatrixNumberOfDimesionsTextBox.Location = new System.Drawing.Point(123, 35);
            this.NewMatrixNumberOfDimesionsTextBox.Name = "NewMatrixNumberOfDimesionsTextBox";
            this.NewMatrixNumberOfDimesionsTextBox.Size = new System.Drawing.Size(68, 20);
            this.NewMatrixNumberOfDimesionsTextBox.TabIndex = 1;
            this.NewMatrixNumberOfDimesionsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IgnoreNonPositiveNumbers_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number of dimensions";
            // 
            // NewMatrixNameTextBox
            // 
            this.NewMatrixNameTextBox.Location = new System.Drawing.Point(123, 9);
            this.NewMatrixNameTextBox.Name = "NewMatrixNameTextBox";
            this.NewMatrixNameTextBox.Size = new System.Drawing.Size(68, 20);
            this.NewMatrixNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name (optional)";
            // 
            // ShowAllMatricesButton
            // 
            this.ShowAllMatricesButton.Location = new System.Drawing.Point(12, 419);
            this.ShowAllMatricesButton.Name = "ShowAllMatricesButton";
            this.ShowAllMatricesButton.Size = new System.Drawing.Size(197, 25);
            this.ShowAllMatricesButton.TabIndex = 1;
            this.ShowAllMatricesButton.Text = "Show all matrices";
            this.ShowAllMatricesButton.UseVisualStyleBackColor = true;
            this.ShowAllMatricesButton.Click += new System.EventHandler(this.ShowAllMatricesButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DeleteMatrixNyNameComboBox);
            this.groupBox2.Controls.Add(this.DeleteMatrixByNameButton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 85);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete matrix by name";
            // 
            // DeleteMatrixNyNameComboBox
            // 
            this.DeleteMatrixNyNameComboBox.FormattingEnabled = true;
            this.DeleteMatrixNyNameComboBox.Location = new System.Drawing.Point(69, 22);
            this.DeleteMatrixNyNameComboBox.Name = "DeleteMatrixNyNameComboBox";
            this.DeleteMatrixNyNameComboBox.Size = new System.Drawing.Size(122, 21);
            this.DeleteMatrixNyNameComboBox.TabIndex = 9;
            // 
            // DeleteMatrixByNameButton
            // 
            this.DeleteMatrixByNameButton.Location = new System.Drawing.Point(6, 49);
            this.DeleteMatrixByNameButton.Name = "DeleteMatrixByNameButton";
            this.DeleteMatrixByNameButton.Size = new System.Drawing.Size(185, 23);
            this.DeleteMatrixByNameButton.TabIndex = 4;
            this.DeleteMatrixByNameButton.Text = "Delete";
            this.DeleteMatrixByNameButton.UseVisualStyleBackColor = true;
            this.DeleteMatrixByNameButton.Click += new System.EventHandler(this.DeleteMatrixByNameButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Name";
            // 
            // DeleteAllMatricesTextBox
            // 
            this.DeleteAllMatricesTextBox.Location = new System.Drawing.Point(12, 397);
            this.DeleteAllMatricesTextBox.Name = "DeleteAllMatricesTextBox";
            this.DeleteAllMatricesTextBox.Size = new System.Drawing.Size(197, 20);
            this.DeleteAllMatricesTextBox.TabIndex = 3;
            this.DeleteAllMatricesTextBox.Text = "Delete all matrices";
            this.DeleteAllMatricesTextBox.UseVisualStyleBackColor = true;
            this.DeleteAllMatricesTextBox.Click += new System.EventHandler(this.DeleteAllMatricesTextBox_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RenameMatrixByOldNameComboBox);
            this.groupBox3.Controls.Add(this.RenameMatrixButton);
            this.groupBox3.Controls.Add(this.NewNameOfMatrixToRenameTextBox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(197, 99);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rename matrix";
            // 
            // RenameMatrixByOldNameComboBox
            // 
            this.RenameMatrixByOldNameComboBox.FormattingEnabled = true;
            this.RenameMatrixByOldNameComboBox.Location = new System.Drawing.Point(69, 20);
            this.RenameMatrixByOldNameComboBox.Name = "RenameMatrixByOldNameComboBox";
            this.RenameMatrixByOldNameComboBox.Size = new System.Drawing.Size(122, 21);
            this.RenameMatrixByOldNameComboBox.TabIndex = 10;
            // 
            // RenameMatrixButton
            // 
            this.RenameMatrixButton.Location = new System.Drawing.Point(9, 73);
            this.RenameMatrixButton.Name = "RenameMatrixButton";
            this.RenameMatrixButton.Size = new System.Drawing.Size(182, 20);
            this.RenameMatrixButton.TabIndex = 5;
            this.RenameMatrixButton.Text = "Rename";
            this.RenameMatrixButton.UseVisualStyleBackColor = true;
            this.RenameMatrixButton.Click += new System.EventHandler(this.RenameMatrixButton_Click);
            // 
            // NewNameOfMatrixToRenameTextBox
            // 
            this.NewNameOfMatrixToRenameTextBox.Location = new System.Drawing.Point(69, 47);
            this.NewNameOfMatrixToRenameTextBox.Name = "NewNameOfMatrixToRenameTextBox";
            this.NewNameOfMatrixToRenameTextBox.Size = new System.Drawing.Size(122, 20);
            this.NewNameOfMatrixToRenameTextBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "New name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Old name";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ShowMatrixByNameComboBox);
            this.groupBox4.Controls.Add(this.ShowMatrixByNameButton);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(215, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(218, 78);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Show matrix by name";
            // 
            // ShowMatrixByNameComboBox
            // 
            this.ShowMatrixByNameComboBox.FormattingEnabled = true;
            this.ShowMatrixByNameComboBox.Location = new System.Drawing.Point(76, 19);
            this.ShowMatrixByNameComboBox.Name = "ShowMatrixByNameComboBox";
            this.ShowMatrixByNameComboBox.Size = new System.Drawing.Size(136, 21);
            this.ShowMatrixByNameComboBox.TabIndex = 11;
            // 
            // ShowMatrixByNameButton
            // 
            this.ShowMatrixByNameButton.Location = new System.Drawing.Point(9, 50);
            this.ShowMatrixByNameButton.Name = "ShowMatrixByNameButton";
            this.ShowMatrixByNameButton.Size = new System.Drawing.Size(203, 20);
            this.ShowMatrixByNameButton.TabIndex = 6;
            this.ShowMatrixByNameButton.Text = "Show matrix";
            this.ShowMatrixByNameButton.UseVisualStyleBackColor = true;
            this.ShowMatrixByNameButton.Click += new System.EventHandler(this.ShowMatrixByNameButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Name";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CreateCloneOfMatrixByNameComboBox);
            this.groupBox5.Controls.Add(this.CloneMatrixButton);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Location = new System.Drawing.Point(215, 96);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(218, 85);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Create clone of";
            // 
            // CreateCloneOfMatrixByNameComboBox
            // 
            this.CreateCloneOfMatrixByNameComboBox.FormattingEnabled = true;
            this.CreateCloneOfMatrixByNameComboBox.Location = new System.Drawing.Point(76, 18);
            this.CreateCloneOfMatrixByNameComboBox.Name = "CreateCloneOfMatrixByNameComboBox";
            this.CreateCloneOfMatrixByNameComboBox.Size = new System.Drawing.Size(136, 21);
            this.CreateCloneOfMatrixByNameComboBox.TabIndex = 11;
            // 
            // CloneMatrixButton
            // 
            this.CloneMatrixButton.Location = new System.Drawing.Point(9, 56);
            this.CloneMatrixButton.Name = "CloneMatrixButton";
            this.CloneMatrixButton.Size = new System.Drawing.Size(203, 23);
            this.CloneMatrixButton.TabIndex = 7;
            this.CloneMatrixButton.Text = "Clone";
            this.CloneMatrixButton.UseVisualStyleBackColor = true;
            this.CloneMatrixButton.Click += new System.EventHandler(this.CloneMatrixButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Matrix name";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(439, 12);
            this.OutputTextBox.Multiline = true;
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.ReadOnly = true;
            this.OutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OutputTextBox.Size = new System.Drawing.Size(317, 437);
            this.OutputTextBox.TabIndex = 7;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.IndexesOfCellToAddValueTextBox);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.ValueForMatrixCellTextBox);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.AddValueToMatrixButton);
            this.groupBox6.Controls.Add(this.AddNewValueToMatrixByNameComboBox);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Location = new System.Drawing.Point(215, 186);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(218, 147);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Add value into matrix";
            // 
            // AddValueToMatrixButton
            // 
            this.AddValueToMatrixButton.Location = new System.Drawing.Point(9, 120);
            this.AddValueToMatrixButton.Name = "AddValueToMatrixButton";
            this.AddValueToMatrixButton.Size = new System.Drawing.Size(203, 20);
            this.AddValueToMatrixButton.TabIndex = 12;
            this.AddValueToMatrixButton.Text = "Add";
            this.AddValueToMatrixButton.UseVisualStyleBackColor = true;
            this.AddValueToMatrixButton.Click += new System.EventHandler(this.AddValueToMatrixButton_Click);
            // 
            // AddNewValueToMatrixByNameComboBox
            // 
            this.AddNewValueToMatrixByNameComboBox.FormattingEnabled = true;
            this.AddNewValueToMatrixByNameComboBox.Location = new System.Drawing.Point(72, 17);
            this.AddNewValueToMatrixByNameComboBox.Name = "AddNewValueToMatrixByNameComboBox";
            this.AddNewValueToMatrixByNameComboBox.Size = new System.Drawing.Size(136, 21);
            this.AddNewValueToMatrixByNameComboBox.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Matrix name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Value";
            // 
            // ValueForMatrixCellTextBox
            // 
            this.ValueForMatrixCellTextBox.Location = new System.Drawing.Point(72, 42);
            this.ValueForMatrixCellTextBox.Name = "ValueForMatrixCellTextBox";
            this.ValueForMatrixCellTextBox.Size = new System.Drawing.Size(136, 20);
            this.ValueForMatrixCellTextBox.TabIndex = 14;
            this.ValueForMatrixCellTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IgnoreNotNumbers_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Indexes separeted by space";
            // 
            // IndexesOfCellToAddValueTextBox
            // 
            this.IndexesOfCellToAddValueTextBox.Location = new System.Drawing.Point(9, 94);
            this.IndexesOfCellToAddValueTextBox.Name = "IndexesOfCellToAddValueTextBox";
            this.IndexesOfCellToAddValueTextBox.Size = new System.Drawing.Size(199, 20);
            this.IndexesOfCellToAddValueTextBox.TabIndex = 16;
            this.IndexesOfCellToAddValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddValueIntoMatrixRangexTextBox_KeyPress);
            // 
            // SparseMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 460);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.DeleteAllMatricesTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ShowAllMatricesButton);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SparseMatrix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sparse Matrix";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox NewMatrixRangesOfDimensionsTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewMatrixNumberOfDimesionsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NewMatrixNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddNewMatrixButton;
        private System.Windows.Forms.TextBox NewMatrixDefaultValueTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ShowAllMatricesButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button DeleteMatrixByNameButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DeleteAllMatricesTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button RenameMatrixButton;
        private System.Windows.Forms.TextBox NewNameOfMatrixToRenameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ShowMatrixByNameButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button CloneMatrixButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox DeleteMatrixNyNameComboBox;
        private System.Windows.Forms.ComboBox RenameMatrixByOldNameComboBox;
        private System.Windows.Forms.ComboBox ShowMatrixByNameComboBox;
        private System.Windows.Forms.ComboBox CreateCloneOfMatrixByNameComboBox;
        private System.Windows.Forms.ComboBox AddNewValueToMatrixByNameComboBox;
        private System.Windows.Forms.Button AddValueToMatrixButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ValueForMatrixCellTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox IndexesOfCellToAddValueTextBox;
    }
}

