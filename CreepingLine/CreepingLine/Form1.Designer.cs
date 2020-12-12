namespace CreepingLine
{
    partial class CreepingLineForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CreepingLineTextBox = new System.Windows.Forms.TextBox();
            this.RunCreepingLineButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SpeedComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CharecterToConstructTextBox = new System.Windows.Forms.TextBox();
            this.ConstructCharecterButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter text:";
            // 
            // CreepingLineTextBox
            // 
            this.CreepingLineTextBox.Location = new System.Drawing.Point(69, 32);
            this.CreepingLineTextBox.Name = "CreepingLineTextBox";
            this.CreepingLineTextBox.Size = new System.Drawing.Size(119, 20);
            this.CreepingLineTextBox.TabIndex = 1;
            // 
            // RunCreepingLineButton
            // 
            this.RunCreepingLineButton.Location = new System.Drawing.Point(194, 31);
            this.RunCreepingLineButton.Name = "RunCreepingLineButton";
            this.RunCreepingLineButton.Size = new System.Drawing.Size(104, 21);
            this.RunCreepingLineButton.TabIndex = 2;
            this.RunCreepingLineButton.Text = "Run creeping line";
            this.RunCreepingLineButton.UseVisualStyleBackColor = true;
            this.RunCreepingLineButton.Click += new System.EventHandler(this.RunCreepingLineButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Speed of creeping line";
            // 
            // SpeedComboBox
            // 
            this.SpeedComboBox.FormattingEnabled = true;
            this.SpeedComboBox.Location = new System.Drawing.Point(127, 4);
            this.SpeedComboBox.Name = "SpeedComboBox";
            this.SpeedComboBox.Size = new System.Drawing.Size(97, 21);
            this.SpeedComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 53);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter charecter, that will have appearence from panel on the right. Note, that it" +
    " will be no difference between lower and uppercase letter";
            // 
            // CharecterToConstructTextBox
            // 
            this.CharecterToConstructTextBox.Location = new System.Drawing.Point(15, 358);
            this.CharecterToConstructTextBox.MaxLength = 1;
            this.CharecterToConstructTextBox.Name = "CharecterToConstructTextBox";
            this.CharecterToConstructTextBox.Size = new System.Drawing.Size(69, 20);
            this.CharecterToConstructTextBox.TabIndex = 6;
            // 
            // ConstructCharecterButton
            // 
            this.ConstructCharecterButton.Location = new System.Drawing.Point(11, 394);
            this.ConstructCharecterButton.Name = "ConstructCharecterButton";
            this.ConstructCharecterButton.Size = new System.Drawing.Size(110, 23);
            this.ConstructCharecterButton.TabIndex = 7;
            this.ConstructCharecterButton.Text = "Construct charecter";
            this.ConstructCharecterButton.UseVisualStyleBackColor = true;
            this.ConstructCharecterButton.Click += new System.EventHandler(this.ConstructCharecterButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(649, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Note, that all undefined symbols will have just black filled rectangle view and c" +
    "reeping line displays all symbols in text in uppercase-format";
            // 
            // CreepingLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 474);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConstructCharecterButton);
            this.Controls.Add(this.CharecterToConstructTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SpeedComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RunCreepingLineButton);
            this.Controls.Add(this.CreepingLineTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CreepingLineForm";
            this.Text = "Creeping line";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CreepingLineTextBox;
        private System.Windows.Forms.Button RunCreepingLineButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SpeedComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CharecterToConstructTextBox;
        private System.Windows.Forms.Button ConstructCharecterButton;
        private System.Windows.Forms.Label label4;
    }
}

