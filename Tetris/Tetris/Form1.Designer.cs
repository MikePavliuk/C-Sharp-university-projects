namespace Tetris
{
    partial class TetrisForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TetrisForm));
            this.TetrisTimer = new System.Windows.Forms.Timer(this.components);
            this.NextShapePictureBox = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.NextShapeLabel = new System.Windows.Forms.Label();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.ArrowsPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InstructionGroupBox = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NextShapePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowsPictureBox)).BeginInit();
            this.InstructionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextShapePictureBox
            // 
            this.NextShapePictureBox.Location = new System.Drawing.Point(421, 195);
            this.NextShapePictureBox.Name = "NextShapePictureBox";
            this.NextShapePictureBox.Size = new System.Drawing.Size(100, 100);
            this.NextShapePictureBox.TabIndex = 0;
            this.NextShapePictureBox.TabStop = false;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScoreLabel.Location = new System.Drawing.Point(416, 55);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(72, 30);
            this.ScoreLabel.TabIndex = 2;
            this.ScoreLabel.Text = "Score";
            // 
            // NextShapeLabel
            // 
            this.NextShapeLabel.AutoSize = true;
            this.NextShapeLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NextShapeLabel.Location = new System.Drawing.Point(417, 169);
            this.NextShapeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NextShapeLabel.Name = "NextShapeLabel";
            this.NextShapeLabel.Size = new System.Drawing.Size(103, 23);
            this.NextShapeLabel.TabIndex = 7;
            this.NextShapeLabel.Text = "Next Shape";
            // 
            // StartGameButton
            // 
            this.StartGameButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StartGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartGameButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.StartGameButton.Location = new System.Drawing.Point(192, 386);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(181, 78);
            this.StartGameButton.TabIndex = 8;
            this.StartGameButton.Text = "START GAME";
            this.StartGameButton.UseVisualStyleBackColor = false;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // ArrowsPictureBox
            // 
            this.ArrowsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ArrowsPictureBox.Image")));
            this.ArrowsPictureBox.Location = new System.Drawing.Point(185, 33);
            this.ArrowsPictureBox.Name = "ArrowsPictureBox";
            this.ArrowsPictureBox.Size = new System.Drawing.Size(188, 104);
            this.ArrowsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ArrowsPictureBox.TabIndex = 10;
            this.ArrowsPictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 11;
            // 
            // InstructionGroupBox
            // 
            this.InstructionGroupBox.Controls.Add(this.label9);
            this.InstructionGroupBox.Controls.Add(this.label8);
            this.InstructionGroupBox.Controls.Add(this.StartGameButton);
            this.InstructionGroupBox.Controls.Add(this.label7);
            this.InstructionGroupBox.Controls.Add(this.label6);
            this.InstructionGroupBox.Controls.Add(this.label5);
            this.InstructionGroupBox.Controls.Add(this.label4);
            this.InstructionGroupBox.Controls.Add(this.label3);
            this.InstructionGroupBox.Controls.Add(this.label1);
            this.InstructionGroupBox.Controls.Add(this.ArrowsPictureBox);
            this.InstructionGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InstructionGroupBox.Location = new System.Drawing.Point(12, 12);
            this.InstructionGroupBox.Name = "InstructionGroupBox";
            this.InstructionGroupBox.Size = new System.Drawing.Size(553, 470);
            this.InstructionGroupBox.TabIndex = 12;
            this.InstructionGroupBox.TabStop = false;
            this.InstructionGroupBox.Text = "Instruction";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(363, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "Key \"E\" - end current game and go the menu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "Key \"P\" - pause the game";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(430, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Key \"Space\" - move shape immediately to the bottom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(309, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Arrow key \"Right\" - move shape right";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(294, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Arrow key \"Left\" - move shape left";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Arrow key \"Down\" - move shape down";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Arrow key \"Up\" - rotate shape";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(136, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "We use arrow keys to move shape.";
            // 
            // TetrisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 494);
            this.Controls.Add(this.InstructionGroupBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NextShapeLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.NextShapePictureBox);
            this.DoubleBuffered = true;
            this.Name = "TetrisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PaintField);
            ((System.ComponentModel.ISupportInitialize)(this.NextShapePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowsPictureBox)).EndInit();
            this.InstructionGroupBox.ResumeLayout(false);
            this.InstructionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TetrisTimer;
        private System.Windows.Forms.PictureBox NextShapePictureBox;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label NextShapeLabel;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.PictureBox ArrowsPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox InstructionGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

