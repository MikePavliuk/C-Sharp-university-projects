namespace Interpolation
{
    partial class InterpolationForm
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.InterpolationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PointsToShowGroupBox = new System.Windows.Forms.GroupBox();
            this.HermiteInterpolationCheckBox = new System.Windows.Forms.CheckBox();
            this.LinearInterpolationCheckBox = new System.Windows.Forms.CheckBox();
            this.DefaultPointsCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowPointsButton = new System.Windows.Forms.Button();
            this.SinusoidalWaveParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.FrequencyTextBox = new System.Windows.Forms.TextBox();
            this.AmplitudeTextBox = new System.Windows.Forms.TextBox();
            this.FrequencyLabel = new System.Windows.Forms.Label();
            this.AmplitudeLabel = new System.Windows.Forms.Label();
            this.NumberOfPointsPerSegmentLabel = new System.Windows.Forms.Label();
            this.ParametersForInterpolationGroupBox = new System.Windows.Forms.GroupBox();
            this.NumberOfInputPointsTextBox = new System.Windows.Forms.TextBox();
            this.NumberOfPointsPerSegmentTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfirmParametersForChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.InterpolationChart)).BeginInit();
            this.PointsToShowGroupBox.SuspendLayout();
            this.SinusoidalWaveParametersGroupBox.SuspendLayout();
            this.ParametersForInterpolationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InterpolationChart
            // 
            chartArea1.Name = "ChartArea1";
            this.InterpolationChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.InterpolationChart.Legends.Add(legend1);
            this.InterpolationChart.Location = new System.Drawing.Point(229, 11);
            this.InterpolationChart.Margin = new System.Windows.Forms.Padding(2);
            this.InterpolationChart.Name = "InterpolationChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "Linear Interpolation";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Hermite Interpolation";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.MarkerSize = 10;
            series3.Name = "Default Points";
            series3.YValuesPerPoint = 2;
            this.InterpolationChart.Series.Add(series1);
            this.InterpolationChart.Series.Add(series2);
            this.InterpolationChart.Series.Add(series3);
            this.InterpolationChart.Size = new System.Drawing.Size(600, 624);
            this.InterpolationChart.TabIndex = 0;
            this.InterpolationChart.Text = "Interpolation Chart";
            // 
            // PointsToShowGroupBox
            // 
            this.PointsToShowGroupBox.Controls.Add(this.HermiteInterpolationCheckBox);
            this.PointsToShowGroupBox.Controls.Add(this.LinearInterpolationCheckBox);
            this.PointsToShowGroupBox.Controls.Add(this.DefaultPointsCheckBox);
            this.PointsToShowGroupBox.Location = new System.Drawing.Point(12, 11);
            this.PointsToShowGroupBox.Name = "PointsToShowGroupBox";
            this.PointsToShowGroupBox.Size = new System.Drawing.Size(200, 100);
            this.PointsToShowGroupBox.TabIndex = 1;
            this.PointsToShowGroupBox.TabStop = false;
            this.PointsToShowGroupBox.Text = "Points to show";
            // 
            // HermiteInterpolationCheckBox
            // 
            this.HermiteInterpolationCheckBox.AutoSize = true;
            this.HermiteInterpolationCheckBox.Location = new System.Drawing.Point(6, 65);
            this.HermiteInterpolationCheckBox.Name = "HermiteInterpolationCheckBox";
            this.HermiteInterpolationCheckBox.Size = new System.Drawing.Size(123, 17);
            this.HermiteInterpolationCheckBox.TabIndex = 2;
            this.HermiteInterpolationCheckBox.Text = "Hermite Interpolation";
            this.HermiteInterpolationCheckBox.UseVisualStyleBackColor = true;
            // 
            // LinearInterpolationCheckBox
            // 
            this.LinearInterpolationCheckBox.AutoSize = true;
            this.LinearInterpolationCheckBox.Location = new System.Drawing.Point(6, 42);
            this.LinearInterpolationCheckBox.Name = "LinearInterpolationCheckBox";
            this.LinearInterpolationCheckBox.Size = new System.Drawing.Size(116, 17);
            this.LinearInterpolationCheckBox.TabIndex = 2;
            this.LinearInterpolationCheckBox.Text = "Linear Interpolation";
            this.LinearInterpolationCheckBox.UseVisualStyleBackColor = true;
            // 
            // DefaultPointsCheckBox
            // 
            this.DefaultPointsCheckBox.AutoSize = true;
            this.DefaultPointsCheckBox.Location = new System.Drawing.Point(6, 19);
            this.DefaultPointsCheckBox.Name = "DefaultPointsCheckBox";
            this.DefaultPointsCheckBox.Size = new System.Drawing.Size(89, 17);
            this.DefaultPointsCheckBox.TabIndex = 2;
            this.DefaultPointsCheckBox.Text = "DefaultPoints";
            this.DefaultPointsCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShowPointsButton
            // 
            this.ShowPointsButton.Location = new System.Drawing.Point(137, 117);
            this.ShowPointsButton.Name = "ShowPointsButton";
            this.ShowPointsButton.Size = new System.Drawing.Size(75, 23);
            this.ShowPointsButton.TabIndex = 2;
            this.ShowPointsButton.Text = "Show";
            this.ShowPointsButton.UseVisualStyleBackColor = true;
            this.ShowPointsButton.Click += new System.EventHandler(this.ShowPointsButton_Click);
            // 
            // SinusoidalWaveParametersGroupBox
            // 
            this.SinusoidalWaveParametersGroupBox.Controls.Add(this.FrequencyTextBox);
            this.SinusoidalWaveParametersGroupBox.Controls.Add(this.AmplitudeTextBox);
            this.SinusoidalWaveParametersGroupBox.Controls.Add(this.FrequencyLabel);
            this.SinusoidalWaveParametersGroupBox.Controls.Add(this.AmplitudeLabel);
            this.SinusoidalWaveParametersGroupBox.Location = new System.Drawing.Point(12, 182);
            this.SinusoidalWaveParametersGroupBox.Name = "SinusoidalWaveParametersGroupBox";
            this.SinusoidalWaveParametersGroupBox.Size = new System.Drawing.Size(200, 85);
            this.SinusoidalWaveParametersGroupBox.TabIndex = 3;
            this.SinusoidalWaveParametersGroupBox.TabStop = false;
            this.SinusoidalWaveParametersGroupBox.Text = "Parameters for sinusoidal wave";
            // 
            // FrequencyTextBox
            // 
            this.FrequencyTextBox.Location = new System.Drawing.Point(94, 51);
            this.FrequencyTextBox.Name = "FrequencyTextBox";
            this.FrequencyTextBox.Size = new System.Drawing.Size(100, 20);
            this.FrequencyTextBox.TabIndex = 9;
            this.FrequencyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // AmplitudeTextBox
            // 
            this.AmplitudeTextBox.Location = new System.Drawing.Point(94, 25);
            this.AmplitudeTextBox.Name = "AmplitudeTextBox";
            this.AmplitudeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AmplitudeTextBox.TabIndex = 9;
            this.AmplitudeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // FrequencyLabel
            // 
            this.FrequencyLabel.AutoSize = true;
            this.FrequencyLabel.Location = new System.Drawing.Point(6, 51);
            this.FrequencyLabel.Name = "FrequencyLabel";
            this.FrequencyLabel.Size = new System.Drawing.Size(57, 13);
            this.FrequencyLabel.TabIndex = 4;
            this.FrequencyLabel.Text = "Frequency";
            // 
            // AmplitudeLabel
            // 
            this.AmplitudeLabel.AutoSize = true;
            this.AmplitudeLabel.Location = new System.Drawing.Point(6, 25);
            this.AmplitudeLabel.Name = "AmplitudeLabel";
            this.AmplitudeLabel.Size = new System.Drawing.Size(53, 13);
            this.AmplitudeLabel.TabIndex = 4;
            this.AmplitudeLabel.Text = "Amplitude";
            // 
            // NumberOfPointsPerSegmentLabel
            // 
            this.NumberOfPointsPerSegmentLabel.AutoSize = true;
            this.NumberOfPointsPerSegmentLabel.Location = new System.Drawing.Point(3, 25);
            this.NumberOfPointsPerSegmentLabel.Name = "NumberOfPointsPerSegmentLabel";
            this.NumberOfPointsPerSegmentLabel.Size = new System.Drawing.Size(148, 13);
            this.NumberOfPointsPerSegmentLabel.TabIndex = 5;
            this.NumberOfPointsPerSegmentLabel.Text = "Number of points per segment";
            // 
            // ParametersForInterpolationGroupBox
            // 
            this.ParametersForInterpolationGroupBox.Controls.Add(this.NumberOfInputPointsTextBox);
            this.ParametersForInterpolationGroupBox.Controls.Add(this.NumberOfPointsPerSegmentTextBox);
            this.ParametersForInterpolationGroupBox.Controls.Add(this.label1);
            this.ParametersForInterpolationGroupBox.Controls.Add(this.NumberOfPointsPerSegmentLabel);
            this.ParametersForInterpolationGroupBox.Location = new System.Drawing.Point(12, 273);
            this.ParametersForInterpolationGroupBox.Name = "ParametersForInterpolationGroupBox";
            this.ParametersForInterpolationGroupBox.Size = new System.Drawing.Size(200, 80);
            this.ParametersForInterpolationGroupBox.TabIndex = 7;
            this.ParametersForInterpolationGroupBox.TabStop = false;
            this.ParametersForInterpolationGroupBox.Text = "Parameters for interpolation";
            // 
            // NumberOfInputPointsTextBox
            // 
            this.NumberOfInputPointsTextBox.Location = new System.Drawing.Point(157, 45);
            this.NumberOfInputPointsTextBox.Name = "NumberOfInputPointsTextBox";
            this.NumberOfInputPointsTextBox.Size = new System.Drawing.Size(37, 20);
            this.NumberOfInputPointsTextBox.TabIndex = 9;
            this.NumberOfInputPointsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // NumberOfPointsPerSegmentTextBox
            // 
            this.NumberOfPointsPerSegmentTextBox.Location = new System.Drawing.Point(157, 22);
            this.NumberOfPointsPerSegmentTextBox.Name = "NumberOfPointsPerSegmentTextBox";
            this.NumberOfPointsPerSegmentTextBox.Size = new System.Drawing.Size(37, 20);
            this.NumberOfPointsPerSegmentTextBox.TabIndex = 9;
            this.NumberOfPointsPerSegmentTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Number of input points";
            // 
            // ConfirmParametersForChart
            // 
            this.ConfirmParametersForChart.Location = new System.Drawing.Point(137, 359);
            this.ConfirmParametersForChart.Name = "ConfirmParametersForChart";
            this.ConfirmParametersForChart.Size = new System.Drawing.Size(75, 23);
            this.ConfirmParametersForChart.TabIndex = 8;
            this.ConfirmParametersForChart.Text = "Confirm";
            this.ConfirmParametersForChart.UseVisualStyleBackColor = true;
            this.ConfirmParametersForChart.Click += new System.EventHandler(this.ConfirmParametersForChart_Click);
            // 
            // InterpolationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 651);
            this.Controls.Add(this.ConfirmParametersForChart);
            this.Controls.Add(this.ParametersForInterpolationGroupBox);
            this.Controls.Add(this.SinusoidalWaveParametersGroupBox);
            this.Controls.Add(this.ShowPointsButton);
            this.Controls.Add(this.PointsToShowGroupBox);
            this.Controls.Add(this.InterpolationChart);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InterpolationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.InterpolationChart)).EndInit();
            this.PointsToShowGroupBox.ResumeLayout(false);
            this.PointsToShowGroupBox.PerformLayout();
            this.SinusoidalWaveParametersGroupBox.ResumeLayout(false);
            this.SinusoidalWaveParametersGroupBox.PerformLayout();
            this.ParametersForInterpolationGroupBox.ResumeLayout(false);
            this.ParametersForInterpolationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart InterpolationChart;
        private System.Windows.Forms.GroupBox PointsToShowGroupBox;
        private System.Windows.Forms.CheckBox HermiteInterpolationCheckBox;
        private System.Windows.Forms.CheckBox LinearInterpolationCheckBox;
        private System.Windows.Forms.CheckBox DefaultPointsCheckBox;
        private System.Windows.Forms.Button ShowPointsButton;
        private System.Windows.Forms.GroupBox SinusoidalWaveParametersGroupBox;
        private System.Windows.Forms.Label FrequencyLabel;
        private System.Windows.Forms.Label AmplitudeLabel;
        private System.Windows.Forms.Label NumberOfPointsPerSegmentLabel;
        private System.Windows.Forms.GroupBox ParametersForInterpolationGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfirmParametersForChart;
        private System.Windows.Forms.TextBox FrequencyTextBox;
        private System.Windows.Forms.TextBox AmplitudeTextBox;
        private System.Windows.Forms.TextBox NumberOfInputPointsTextBox;
        private System.Windows.Forms.TextBox NumberOfPointsPerSegmentTextBox;
    }
}

