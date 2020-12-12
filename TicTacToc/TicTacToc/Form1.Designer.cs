namespace TicTacToc
{
    partial class TicTacTocForm
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
            this.TicTacTocPanel = new System.Windows.Forms.Panel();
            this.ChosingLevelGroupBox = new System.Windows.Forms.GroupBox();
            this.Level3RadioButton = new System.Windows.Forms.RadioButton();
            this.Level2RadioButton = new System.Windows.Forms.RadioButton();
            this.Level1RadioButton = new System.Windows.Forms.RadioButton();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.ChosingLevelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TicTacTocPanel
            // 
            this.TicTacTocPanel.Location = new System.Drawing.Point(171, 12);
            this.TicTacTocPanel.Margin = new System.Windows.Forms.Padding(2);
            this.TicTacTocPanel.Name = "TicTacTocPanel";
            this.TicTacTocPanel.Size = new System.Drawing.Size(450, 450);
            this.TicTacTocPanel.TabIndex = 0;
            // 
            // ChosingLevelGroupBox
            // 
            this.ChosingLevelGroupBox.Controls.Add(this.Level3RadioButton);
            this.ChosingLevelGroupBox.Controls.Add(this.Level2RadioButton);
            this.ChosingLevelGroupBox.Controls.Add(this.Level1RadioButton);
            this.ChosingLevelGroupBox.Location = new System.Drawing.Point(6, 12);
            this.ChosingLevelGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ChosingLevelGroupBox.Name = "ChosingLevelGroupBox";
            this.ChosingLevelGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ChosingLevelGroupBox.Size = new System.Drawing.Size(161, 155);
            this.ChosingLevelGroupBox.TabIndex = 0;
            this.ChosingLevelGroupBox.TabStop = false;
            this.ChosingLevelGroupBox.Text = "Levels";
            // 
            // Level3RadioButton
            // 
            this.Level3RadioButton.AutoSize = true;
            this.Level3RadioButton.Location = new System.Drawing.Point(15, 111);
            this.Level3RadioButton.Name = "Level3RadioButton";
            this.Level3RadioButton.Size = new System.Drawing.Size(60, 17);
            this.Level3RadioButton.TabIndex = 0;
            this.Level3RadioButton.TabStop = true;
            this.Level3RadioButton.Text = "Level 3";
            this.Level3RadioButton.UseVisualStyleBackColor = true;
            // 
            // Level2RadioButton
            // 
            this.Level2RadioButton.AutoSize = true;
            this.Level2RadioButton.Location = new System.Drawing.Point(15, 70);
            this.Level2RadioButton.Name = "Level2RadioButton";
            this.Level2RadioButton.Size = new System.Drawing.Size(60, 17);
            this.Level2RadioButton.TabIndex = 0;
            this.Level2RadioButton.TabStop = true;
            this.Level2RadioButton.Text = "Level 2";
            this.Level2RadioButton.UseVisualStyleBackColor = true;
            // 
            // Level1RadioButton
            // 
            this.Level1RadioButton.AutoSize = true;
            this.Level1RadioButton.Location = new System.Drawing.Point(15, 31);
            this.Level1RadioButton.Name = "Level1RadioButton";
            this.Level1RadioButton.Size = new System.Drawing.Size(60, 17);
            this.Level1RadioButton.TabIndex = 0;
            this.Level1RadioButton.TabStop = true;
            this.Level1RadioButton.Text = "Level 1";
            this.Level1RadioButton.UseVisualStyleBackColor = true;
            // 
            // StartGameButton
            // 
            this.StartGameButton.Location = new System.Drawing.Point(40, 172);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(75, 23);
            this.StartGameButton.TabIndex = 0;
            this.StartGameButton.Text = "Start Game";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // TicTacTocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 481);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.ChosingLevelGroupBox);
            this.Controls.Add(this.TicTacTocPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TicTacTocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toc Game";
            this.ChosingLevelGroupBox.ResumeLayout(false);
            this.ChosingLevelGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TicTacTocPanel;
        private System.Windows.Forms.GroupBox ChosingLevelGroupBox;
        private System.Windows.Forms.RadioButton Level3RadioButton;
        private System.Windows.Forms.RadioButton Level2RadioButton;
        private System.Windows.Forms.RadioButton Level1RadioButton;
        private System.Windows.Forms.Button StartGameButton;
    }
}

