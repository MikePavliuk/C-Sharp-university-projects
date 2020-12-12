namespace LissajousCurve
{
    partial class LissajousCurveForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.ParametricEquationXGroupBox = new System.Windows.Forms.GroupBox();
            this.ParametricEquationXHzLabel = new System.Windows.Forms.Label();
            this.ParametricEquationXFrequencyValueLabel = new System.Windows.Forms.Label();
            this.ParametricEquationXFrequencyTrackBar = new System.Windows.Forms.TrackBar();
            this.ParametricEquationXGradusLabel = new System.Windows.Forms.Label();
            this.ParametricEquationXPhaseTextBox = new System.Windows.Forms.TextBox();
            this.ParametricEquationXAmplitudeTextBox = new System.Windows.Forms.TextBox();
            this.ParametricEquationXPhaseLabel = new System.Windows.Forms.Label();
            this.ParametricEquationXFrequencyLabel = new System.Windows.Forms.Label();
            this.ParametricEquationXAmplitudeLabel = new System.Windows.Forms.Label();
            this.ParametricEquationYGroupBox = new System.Windows.Forms.GroupBox();
            this.ParametricEquationYFrequencyValueLabel = new System.Windows.Forms.Label();
            this.ParametricEquationYFrequencyTrackBar = new System.Windows.Forms.TrackBar();
            this.ParametricEquationYHzLabel = new System.Windows.Forms.Label();
            this.ParametricEquationYAmplitudeTextBox = new System.Windows.Forms.TextBox();
            this.ParametricEquationYFrequencyLabel = new System.Windows.Forms.Label();
            this.ParametricEquationYAmplitudeLabel = new System.Windows.Forms.Label();
            this.DrawLissajousCurveButton = new System.Windows.Forms.Button();
            this.LissajousCurveChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ClearChartAreaButton = new System.Windows.Forms.Button();
            this.ParametricEquationXGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParametricEquationXFrequencyTrackBar)).BeginInit();
            this.ParametricEquationYGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParametricEquationYFrequencyTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LissajousCurveChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.TabIndex = 0;
            // 
            // ParametricEquationXGroupBox
            // 
            this.ParametricEquationXGroupBox.Controls.Add(this.ParametricEquationXHzLabel);
            this.ParametricEquationXGroupBox.Controls.Add(this.ParametricEquationXFrequencyValueLabel);
            this.ParametricEquationXGroupBox.Controls.Add(this.ParametricEquationXFrequencyTrackBar);
            this.ParametricEquationXGroupBox.Controls.Add(this.ParametricEquationXGradusLabel);
            this.ParametricEquationXGroupBox.Controls.Add(this.ParametricEquationXPhaseTextBox);
            this.ParametricEquationXGroupBox.Controls.Add(this.ParametricEquationXAmplitudeTextBox);
            this.ParametricEquationXGroupBox.Controls.Add(this.ParametricEquationXPhaseLabel);
            this.ParametricEquationXGroupBox.Controls.Add(this.ParametricEquationXFrequencyLabel);
            this.ParametricEquationXGroupBox.Controls.Add(this.ParametricEquationXAmplitudeLabel);
            this.ParametricEquationXGroupBox.Location = new System.Drawing.Point(16, 17);
            this.ParametricEquationXGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParametricEquationXGroupBox.Name = "ParametricEquationXGroupBox";
            this.ParametricEquationXGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParametricEquationXGroupBox.Size = new System.Drawing.Size(507, 207);
            this.ParametricEquationXGroupBox.TabIndex = 1;
            this.ParametricEquationXGroupBox.TabStop = false;
            this.ParametricEquationXGroupBox.Text = "Parametric Equation X";
            // 
            // ParametricEquationXHzLabel
            // 
            this.ParametricEquationXHzLabel.AutoSize = true;
            this.ParametricEquationXHzLabel.Location = new System.Drawing.Point(465, 97);
            this.ParametricEquationXHzLabel.Name = "ParametricEquationXHzLabel";
            this.ParametricEquationXHzLabel.Size = new System.Drawing.Size(45, 30);
            this.ParametricEquationXHzLabel.TabIndex = 8;
            this.ParametricEquationXHzLabel.Text = "Hz";
            // 
            // ParametricEquationXFrequencyValueLabel
            // 
            this.ParametricEquationXFrequencyValueLabel.AutoSize = true;
            this.ParametricEquationXFrequencyValueLabel.Location = new System.Drawing.Point(437, 97);
            this.ParametricEquationXFrequencyValueLabel.Name = "ParametricEquationXFrequencyValueLabel";
            this.ParametricEquationXFrequencyValueLabel.Size = new System.Drawing.Size(27, 30);
            this.ParametricEquationXFrequencyValueLabel.TabIndex = 5;
            this.ParametricEquationXFrequencyValueLabel.Text = "1";
            // 
            // ParametricEquationXFrequencyTrackBar
            // 
            this.ParametricEquationXFrequencyTrackBar.Location = new System.Drawing.Point(8, 122);
            this.ParametricEquationXFrequencyTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParametricEquationXFrequencyTrackBar.Maximum = 100;
            this.ParametricEquationXFrequencyTrackBar.Minimum = 1;
            this.ParametricEquationXFrequencyTrackBar.Name = "ParametricEquationXFrequencyTrackBar";
            this.ParametricEquationXFrequencyTrackBar.Size = new System.Drawing.Size(483, 90);
            this.ParametricEquationXFrequencyTrackBar.TabIndex = 3;
            this.ParametricEquationXFrequencyTrackBar.Value = 6;
            this.ParametricEquationXFrequencyTrackBar.ValueChanged += new System.EventHandler(this.ParametricEquationXFrequencyTrackBar_ValueChanged);
            // 
            // ParametricEquationXGradusLabel
            // 
            this.ParametricEquationXGradusLabel.AutoSize = true;
            this.ParametricEquationXGradusLabel.Location = new System.Drawing.Point(235, 60);
            this.ParametricEquationXGradusLabel.Name = "ParametricEquationXGradusLabel";
            this.ParametricEquationXGradusLabel.Size = new System.Drawing.Size(23, 30);
            this.ParametricEquationXGradusLabel.TabIndex = 7;
            this.ParametricEquationXGradusLabel.Text = "°";
            // 
            // ParametricEquationXPhaseTextBox
            // 
            this.ParametricEquationXPhaseTextBox.Location = new System.Drawing.Point(116, 57);
            this.ParametricEquationXPhaseTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParametricEquationXPhaseTextBox.Name = "ParametricEquationXPhaseTextBox";
            this.ParametricEquationXPhaseTextBox.Size = new System.Drawing.Size(116, 37);
            this.ParametricEquationXPhaseTextBox.TabIndex = 2;
            this.ParametricEquationXPhaseTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParametricEquationTextBox_KeyPress);
            this.ParametricEquationXPhaseTextBox.Leave += new System.EventHandler(this.ParametricEquationXPhaseTextBox_Leave);
            // 
            // ParametricEquationXAmplitudeTextBox
            // 
            this.ParametricEquationXAmplitudeTextBox.Location = new System.Drawing.Point(116, 25);
            this.ParametricEquationXAmplitudeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParametricEquationXAmplitudeTextBox.Name = "ParametricEquationXAmplitudeTextBox";
            this.ParametricEquationXAmplitudeTextBox.Size = new System.Drawing.Size(116, 37);
            this.ParametricEquationXAmplitudeTextBox.TabIndex = 1;
            this.ParametricEquationXAmplitudeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParametricEquationTextBox_KeyPress);
            // 
            // ParametricEquationXPhaseLabel
            // 
            this.ParametricEquationXPhaseLabel.AutoSize = true;
            this.ParametricEquationXPhaseLabel.Location = new System.Drawing.Point(4, 60);
            this.ParametricEquationXPhaseLabel.Name = "ParametricEquationXPhaseLabel";
            this.ParametricEquationXPhaseLabel.Size = new System.Drawing.Size(85, 30);
            this.ParametricEquationXPhaseLabel.TabIndex = 3;
            this.ParametricEquationXPhaseLabel.Text = "Phase";
            // 
            // ParametricEquationXFrequencyLabel
            // 
            this.ParametricEquationXFrequencyLabel.AutoSize = true;
            this.ParametricEquationXFrequencyLabel.Location = new System.Drawing.Point(4, 97);
            this.ParametricEquationXFrequencyLabel.Name = "ParametricEquationXFrequencyLabel";
            this.ParametricEquationXFrequencyLabel.Size = new System.Drawing.Size(134, 30);
            this.ParametricEquationXFrequencyLabel.TabIndex = 3;
            this.ParametricEquationXFrequencyLabel.Text = "Frequency";
            // 
            // ParametricEquationXAmplitudeLabel
            // 
            this.ParametricEquationXAmplitudeLabel.AutoSize = true;
            this.ParametricEquationXAmplitudeLabel.Location = new System.Drawing.Point(4, 26);
            this.ParametricEquationXAmplitudeLabel.Name = "ParametricEquationXAmplitudeLabel";
            this.ParametricEquationXAmplitudeLabel.Size = new System.Drawing.Size(127, 30);
            this.ParametricEquationXAmplitudeLabel.TabIndex = 3;
            this.ParametricEquationXAmplitudeLabel.Text = "Amplitude";
            // 
            // ParametricEquationYGroupBox
            // 
            this.ParametricEquationYGroupBox.Controls.Add(this.ParametricEquationYFrequencyValueLabel);
            this.ParametricEquationYGroupBox.Controls.Add(this.ParametricEquationYFrequencyTrackBar);
            this.ParametricEquationYGroupBox.Controls.Add(this.ParametricEquationYHzLabel);
            this.ParametricEquationYGroupBox.Controls.Add(this.ParametricEquationYAmplitudeTextBox);
            this.ParametricEquationYGroupBox.Controls.Add(this.ParametricEquationYFrequencyLabel);
            this.ParametricEquationYGroupBox.Controls.Add(this.ParametricEquationYAmplitudeLabel);
            this.ParametricEquationYGroupBox.Location = new System.Drawing.Point(8, 236);
            this.ParametricEquationYGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParametricEquationYGroupBox.Name = "ParametricEquationYGroupBox";
            this.ParametricEquationYGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParametricEquationYGroupBox.Size = new System.Drawing.Size(513, 164);
            this.ParametricEquationYGroupBox.TabIndex = 2;
            this.ParametricEquationYGroupBox.TabStop = false;
            this.ParametricEquationYGroupBox.Text = "Parametric Equation Y";
            // 
            // ParametricEquationYFrequencyValueLabel
            // 
            this.ParametricEquationYFrequencyValueLabel.AutoSize = true;
            this.ParametricEquationYFrequencyValueLabel.Location = new System.Drawing.Point(444, 62);
            this.ParametricEquationYFrequencyValueLabel.Name = "ParametricEquationYFrequencyValueLabel";
            this.ParametricEquationYFrequencyValueLabel.Size = new System.Drawing.Size(27, 30);
            this.ParametricEquationYFrequencyValueLabel.TabIndex = 9;
            this.ParametricEquationYFrequencyValueLabel.Text = "1";
            // 
            // ParametricEquationYFrequencyTrackBar
            // 
            this.ParametricEquationYFrequencyTrackBar.Location = new System.Drawing.Point(4, 91);
            this.ParametricEquationYFrequencyTrackBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParametricEquationYFrequencyTrackBar.Maximum = 100;
            this.ParametricEquationYFrequencyTrackBar.Minimum = 1;
            this.ParametricEquationYFrequencyTrackBar.Name = "ParametricEquationYFrequencyTrackBar";
            this.ParametricEquationYFrequencyTrackBar.Size = new System.Drawing.Size(505, 90);
            this.ParametricEquationYFrequencyTrackBar.TabIndex = 5;
            this.ParametricEquationYFrequencyTrackBar.Value = 9;
            this.ParametricEquationYFrequencyTrackBar.ValueChanged += new System.EventHandler(this.ParametricEquationYFrequencyTrackBar_ValueChanged);
            // 
            // ParametricEquationYHzLabel
            // 
            this.ParametricEquationYHzLabel.AutoSize = true;
            this.ParametricEquationYHzLabel.Location = new System.Drawing.Point(472, 62);
            this.ParametricEquationYHzLabel.Name = "ParametricEquationYHzLabel";
            this.ParametricEquationYHzLabel.Size = new System.Drawing.Size(45, 30);
            this.ParametricEquationYHzLabel.TabIndex = 3;
            this.ParametricEquationYHzLabel.Text = "Hz";
            // 
            // ParametricEquationYAmplitudeTextBox
            // 
            this.ParametricEquationYAmplitudeTextBox.Location = new System.Drawing.Point(116, 22);
            this.ParametricEquationYAmplitudeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParametricEquationYAmplitudeTextBox.Name = "ParametricEquationYAmplitudeTextBox";
            this.ParametricEquationYAmplitudeTextBox.Size = new System.Drawing.Size(116, 37);
            this.ParametricEquationYAmplitudeTextBox.TabIndex = 4;
            this.ParametricEquationYAmplitudeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ParametricEquationTextBox_KeyPress);
            // 
            // ParametricEquationYFrequencyLabel
            // 
            this.ParametricEquationYFrequencyLabel.AutoSize = true;
            this.ParametricEquationYFrequencyLabel.Location = new System.Drawing.Point(4, 62);
            this.ParametricEquationYFrequencyLabel.Name = "ParametricEquationYFrequencyLabel";
            this.ParametricEquationYFrequencyLabel.Size = new System.Drawing.Size(134, 30);
            this.ParametricEquationYFrequencyLabel.TabIndex = 3;
            this.ParametricEquationYFrequencyLabel.Text = "Frequency";
            // 
            // ParametricEquationYAmplitudeLabel
            // 
            this.ParametricEquationYAmplitudeLabel.AutoSize = true;
            this.ParametricEquationYAmplitudeLabel.Location = new System.Drawing.Point(4, 26);
            this.ParametricEquationYAmplitudeLabel.Name = "ParametricEquationYAmplitudeLabel";
            this.ParametricEquationYAmplitudeLabel.Size = new System.Drawing.Size(127, 30);
            this.ParametricEquationYAmplitudeLabel.TabIndex = 3;
            this.ParametricEquationYAmplitudeLabel.Text = "Amplitude";
            // 
            // DrawLissajousCurveButton
            // 
            this.DrawLissajousCurveButton.Location = new System.Drawing.Point(336, 437);
            this.DrawLissajousCurveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DrawLissajousCurveButton.Name = "DrawLissajousCurveButton";
            this.DrawLissajousCurveButton.Size = new System.Drawing.Size(185, 32);
            this.DrawLissajousCurveButton.TabIndex = 7;
            this.DrawLissajousCurveButton.Text = "Draw Lissajous Curve";
            this.DrawLissajousCurveButton.UseVisualStyleBackColor = true;
            this.DrawLissajousCurveButton.Click += new System.EventHandler(this.DrawLissajousCurveButton_Click);
            // 
            // LissajousCurveChart
            // 
            chartArea1.Name = "LissajousCurveChartArea";
            this.LissajousCurveChart.ChartAreas.Add(chartArea1);
            this.LissajousCurveChart.Location = new System.Drawing.Point(560, 17);
            this.LissajousCurveChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LissajousCurveChart.Name = "LissajousCurveChart";
            series1.ChartArea = "LissajousCurveChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "LissajousCurveSeries";
            this.LissajousCurveChart.Series.Add(series1);
            this.LissajousCurveChart.Size = new System.Drawing.Size(667, 615);
            this.LissajousCurveChart.TabIndex = 4;
            this.LissajousCurveChart.Text = "Lissajous Curve";
            // 
            // ClearChartAreaButton
            // 
            this.ClearChartAreaButton.Location = new System.Drawing.Point(8, 437);
            this.ClearChartAreaButton.Name = "ClearChartAreaButton";
            this.ClearChartAreaButton.Size = new System.Drawing.Size(100, 32);
            this.ClearChartAreaButton.TabIndex = 6;
            this.ClearChartAreaButton.Text = "Clear Chart";
            this.ClearChartAreaButton.UseVisualStyleBackColor = true;
            this.ClearChartAreaButton.Click += new System.EventHandler(this.ClearChartAreaButton_Click);
            // 
            // LissajousCurveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1245, 647);
            this.Controls.Add(this.ClearChartAreaButton);
            this.Controls.Add(this.LissajousCurveChart);
            this.Controls.Add(this.DrawLissajousCurveButton);
            this.Controls.Add(this.ParametricEquationYGroupBox);
            this.Controls.Add(this.ParametricEquationXGroupBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LissajousCurveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LissajousCurve";
            this.ParametricEquationXGroupBox.ResumeLayout(false);
            this.ParametricEquationXGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParametricEquationXFrequencyTrackBar)).EndInit();
            this.ParametricEquationYGroupBox.ResumeLayout(false);
            this.ParametricEquationYGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ParametricEquationYFrequencyTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LissajousCurveChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ParametricEquationXGroupBox;
        private System.Windows.Forms.Label ParametricEquationXGradusLabel;
        private System.Windows.Forms.TextBox ParametricEquationXPhaseTextBox;
        private System.Windows.Forms.TextBox ParametricEquationXAmplitudeTextBox;
        private System.Windows.Forms.Label ParametricEquationXPhaseLabel;
        private System.Windows.Forms.Label ParametricEquationXFrequencyLabel;
        private System.Windows.Forms.Label ParametricEquationXAmplitudeLabel;
        private System.Windows.Forms.GroupBox ParametricEquationYGroupBox;
        private System.Windows.Forms.Label ParametricEquationYHzLabel;
        private System.Windows.Forms.TextBox ParametricEquationYAmplitudeTextBox;
        private System.Windows.Forms.Label ParametricEquationYFrequencyLabel;
        private System.Windows.Forms.Label ParametricEquationYAmplitudeLabel;
        private System.Windows.Forms.Button DrawLissajousCurveButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart LissajousCurveChart;
        private System.Windows.Forms.Label ParametricEquationXHzLabel;
        private System.Windows.Forms.Label ParametricEquationXFrequencyValueLabel;
        private System.Windows.Forms.TrackBar ParametricEquationXFrequencyTrackBar;
        private System.Windows.Forms.TrackBar ParametricEquationYFrequencyTrackBar;
        private System.Windows.Forms.Label ParametricEquationYFrequencyValueLabel;
        private System.Windows.Forms.Button ClearChartAreaButton;
    }
}

