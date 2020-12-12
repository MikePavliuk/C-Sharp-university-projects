namespace NumericalIntegration
{
    partial class NumericalIntegrationForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.FunctionToFindIntegralGroupBox = new System.Windows.Forms.GroupBox();
            this.ThirdFunctionRadioButton = new System.Windows.Forms.RadioButton();
            this.SecondFunctionRadioButton = new System.Windows.Forms.RadioButton();
            this.FirstFunctionRadioButton = new System.Windows.Forms.RadioButton();
            this.IntegrateFunctionButton = new System.Windows.Forms.Button();
            this.ParametersForIntegrationGroupBox = new System.Windows.Forms.GroupBox();
            this.NumberOfSubintervalsTextBox = new System.Windows.Forms.TextBox();
            this.IntervalEndTextBox = new System.Windows.Forms.TextBox();
            this.SubIntervalsLabel = new System.Windows.Forms.Label();
            this.IntervalEndLabel = new System.Windows.Forms.Label();
            this.IntervalStartTextBox = new System.Windows.Forms.TextBox();
            this.IntervalStartLabel = new System.Windows.Forms.Label();
            this.NumericalIntegrationChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PointsToShowGroupBox = new System.Windows.Forms.GroupBox();
            this.SimponsRuleCheckBox = new System.Windows.Forms.CheckBox();
            this.TrapezoidalRuleCheckBox = new System.Windows.Forms.CheckBox();
            this.RectangleMethodCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowPointsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SimponsResultLabel = new System.Windows.Forms.Label();
            this.SimponsResultTextLabel = new System.Windows.Forms.Label();
            this.TrapezoidalResultLabel = new System.Windows.Forms.Label();
            this.TrapezoidalResultTextLabel = new System.Windows.Forms.Label();
            this.RectangleResultLabel = new System.Windows.Forms.Label();
            this.RectangleResultTextLabel = new System.Windows.Forms.Label();
            this.FunctionToFindIntegralGroupBox.SuspendLayout();
            this.ParametersForIntegrationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericalIntegrationChart)).BeginInit();
            this.PointsToShowGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FunctionToFindIntegralGroupBox
            // 
            this.FunctionToFindIntegralGroupBox.Controls.Add(this.ThirdFunctionRadioButton);
            this.FunctionToFindIntegralGroupBox.Controls.Add(this.SecondFunctionRadioButton);
            this.FunctionToFindIntegralGroupBox.Controls.Add(this.FirstFunctionRadioButton);
            this.FunctionToFindIntegralGroupBox.Location = new System.Drawing.Point(12, 12);
            this.FunctionToFindIntegralGroupBox.Name = "FunctionToFindIntegralGroupBox";
            this.FunctionToFindIntegralGroupBox.Size = new System.Drawing.Size(147, 100);
            this.FunctionToFindIntegralGroupBox.TabIndex = 0;
            this.FunctionToFindIntegralGroupBox.TabStop = false;
            this.FunctionToFindIntegralGroupBox.Text = "Function to find integral";
            // 
            // ThirdFunctionRadioButton
            // 
            this.ThirdFunctionRadioButton.AutoSize = true;
            this.ThirdFunctionRadioButton.Location = new System.Drawing.Point(6, 65);
            this.ThirdFunctionRadioButton.Name = "ThirdFunctionRadioButton";
            this.ThirdFunctionRadioButton.Size = new System.Drawing.Size(102, 17);
            this.ThirdFunctionRadioButton.TabIndex = 1;
            this.ThirdFunctionRadioButton.TabStop = true;
            this.ThirdFunctionRadioButton.Text = "f(x) = 5*x^4 - 4*x";
            this.ThirdFunctionRadioButton.UseVisualStyleBackColor = true;
            // 
            // SecondFunctionRadioButton
            // 
            this.SecondFunctionRadioButton.AutoSize = true;
            this.SecondFunctionRadioButton.Location = new System.Drawing.Point(6, 42);
            this.SecondFunctionRadioButton.Name = "SecondFunctionRadioButton";
            this.SecondFunctionRadioButton.Size = new System.Drawing.Size(68, 17);
            this.SecondFunctionRadioButton.TabIndex = 1;
            this.SecondFunctionRadioButton.TabStop = true;
            this.SecondFunctionRadioButton.Text = "f(x) = x^3";
            this.SecondFunctionRadioButton.UseVisualStyleBackColor = true;
            // 
            // FirstFunctionRadioButton
            // 
            this.FirstFunctionRadioButton.AutoSize = true;
            this.FirstFunctionRadioButton.Location = new System.Drawing.Point(6, 19);
            this.FirstFunctionRadioButton.Name = "FirstFunctionRadioButton";
            this.FirstFunctionRadioButton.Size = new System.Drawing.Size(66, 17);
            this.FirstFunctionRadioButton.TabIndex = 0;
            this.FirstFunctionRadioButton.TabStop = true;
            this.FirstFunctionRadioButton.Text = "f(x) = 2*x";
            this.FirstFunctionRadioButton.UseVisualStyleBackColor = true;
            // 
            // IntegrateFunctionButton
            // 
            this.IntegrateFunctionButton.Location = new System.Drawing.Point(12, 245);
            this.IntegrateFunctionButton.Name = "IntegrateFunctionButton";
            this.IntegrateFunctionButton.Size = new System.Drawing.Size(75, 23);
            this.IntegrateFunctionButton.TabIndex = 1;
            this.IntegrateFunctionButton.Text = "Integrate";
            this.IntegrateFunctionButton.UseVisualStyleBackColor = true;
            this.IntegrateFunctionButton.Click += new System.EventHandler(this.IntegrateFunctionButton_Click);
            // 
            // ParametersForIntegrationGroupBox
            // 
            this.ParametersForIntegrationGroupBox.Controls.Add(this.NumberOfSubintervalsTextBox);
            this.ParametersForIntegrationGroupBox.Controls.Add(this.IntervalEndTextBox);
            this.ParametersForIntegrationGroupBox.Controls.Add(this.SubIntervalsLabel);
            this.ParametersForIntegrationGroupBox.Controls.Add(this.IntervalEndLabel);
            this.ParametersForIntegrationGroupBox.Controls.Add(this.IntervalStartTextBox);
            this.ParametersForIntegrationGroupBox.Controls.Add(this.IntervalStartLabel);
            this.ParametersForIntegrationGroupBox.Location = new System.Drawing.Point(12, 118);
            this.ParametersForIntegrationGroupBox.Name = "ParametersForIntegrationGroupBox";
            this.ParametersForIntegrationGroupBox.Size = new System.Drawing.Size(147, 121);
            this.ParametersForIntegrationGroupBox.TabIndex = 2;
            this.ParametersForIntegrationGroupBox.TabStop = false;
            this.ParametersForIntegrationGroupBox.Text = "Parameters for Integration";
            // 
            // NumberOfSubintervalsTextBox
            // 
            this.NumberOfSubintervalsTextBox.Location = new System.Drawing.Point(74, 97);
            this.NumberOfSubintervalsTextBox.Name = "NumberOfSubintervalsTextBox";
            this.NumberOfSubintervalsTextBox.Size = new System.Drawing.Size(63, 20);
            this.NumberOfSubintervalsTextBox.TabIndex = 4;
            this.NumberOfSubintervalsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // IntervalEndTextBox
            // 
            this.IntervalEndTextBox.Location = new System.Drawing.Point(74, 55);
            this.IntervalEndTextBox.Name = "IntervalEndTextBox";
            this.IntervalEndTextBox.Size = new System.Drawing.Size(63, 20);
            this.IntervalEndTextBox.TabIndex = 5;
            this.IntervalEndTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // SubIntervalsLabel
            // 
            this.SubIntervalsLabel.AutoSize = true;
            this.SubIntervalsLabel.Location = new System.Drawing.Point(6, 81);
            this.SubIntervalsLabel.Name = "SubIntervalsLabel";
            this.SubIntervalsLabel.Size = new System.Drawing.Size(115, 13);
            this.SubIntervalsLabel.TabIndex = 3;
            this.SubIntervalsLabel.Text = "Number of subintervals";
            // 
            // IntervalEndLabel
            // 
            this.IntervalEndLabel.AutoSize = true;
            this.IntervalEndLabel.Location = new System.Drawing.Point(6, 58);
            this.IntervalEndLabel.Name = "IntervalEndLabel";
            this.IntervalEndLabel.Size = new System.Drawing.Size(64, 13);
            this.IntervalEndLabel.TabIndex = 3;
            this.IntervalEndLabel.Text = "Interval End";
            // 
            // IntervalStartTextBox
            // 
            this.IntervalStartTextBox.Location = new System.Drawing.Point(74, 33);
            this.IntervalStartTextBox.Name = "IntervalStartTextBox";
            this.IntervalStartTextBox.Size = new System.Drawing.Size(63, 20);
            this.IntervalStartTextBox.TabIndex = 3;
            this.IntervalStartTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // IntervalStartLabel
            // 
            this.IntervalStartLabel.AutoSize = true;
            this.IntervalStartLabel.Location = new System.Drawing.Point(6, 36);
            this.IntervalStartLabel.Name = "IntervalStartLabel";
            this.IntervalStartLabel.Size = new System.Drawing.Size(67, 13);
            this.IntervalStartLabel.TabIndex = 3;
            this.IntervalStartLabel.Text = "Interval Start";
            // 
            // NumericalIntegrationChart
            // 
            chartArea4.Name = "ChartArea1";
            chartArea5.Name = "ChartArea2";
            chartArea6.Name = "ChartArea3";
            this.NumericalIntegrationChart.ChartAreas.Add(chartArea4);
            this.NumericalIntegrationChart.ChartAreas.Add(chartArea5);
            this.NumericalIntegrationChart.ChartAreas.Add(chartArea6);
            legend2.Name = "Legend1";
            this.NumericalIntegrationChart.Legends.Add(legend2);
            this.NumericalIntegrationChart.Location = new System.Drawing.Point(165, 12);
            this.NumericalIntegrationChart.Name = "NumericalIntegrationChart";
            series7.ChartArea = "ChartArea1";
            series7.IsVisibleInLegend = false;
            series7.Legend = "Legend1";
            series7.Name = "Series4";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "Rectangle Method";
            series9.ChartArea = "ChartArea2";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series9.IsVisibleInLegend = false;
            series9.Legend = "Legend1";
            series9.Name = "Series5";
            series10.ChartArea = "ChartArea2";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "Trapezoidal Rule";
            series11.ChartArea = "ChartArea3";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series11.IsVisibleInLegend = false;
            series11.Legend = "Legend1";
            series11.Name = "Series6";
            series12.ChartArea = "ChartArea3";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Legend1";
            series12.Name = "Simpon\'s Rule";
            this.NumericalIntegrationChart.Series.Add(series7);
            this.NumericalIntegrationChart.Series.Add(series8);
            this.NumericalIntegrationChart.Series.Add(series9);
            this.NumericalIntegrationChart.Series.Add(series10);
            this.NumericalIntegrationChart.Series.Add(series11);
            this.NumericalIntegrationChart.Series.Add(series12);
            this.NumericalIntegrationChart.Size = new System.Drawing.Size(725, 535);
            this.NumericalIntegrationChart.TabIndex = 3;
            this.NumericalIntegrationChart.Text = "NumericalI ntegration Chart";
            // 
            // PointsToShowGroupBox
            // 
            this.PointsToShowGroupBox.Controls.Add(this.SimponsRuleCheckBox);
            this.PointsToShowGroupBox.Controls.Add(this.TrapezoidalRuleCheckBox);
            this.PointsToShowGroupBox.Controls.Add(this.RectangleMethodCheckBox);
            this.PointsToShowGroupBox.Location = new System.Drawing.Point(12, 289);
            this.PointsToShowGroupBox.Name = "PointsToShowGroupBox";
            this.PointsToShowGroupBox.Size = new System.Drawing.Size(147, 100);
            this.PointsToShowGroupBox.TabIndex = 4;
            this.PointsToShowGroupBox.TabStop = false;
            this.PointsToShowGroupBox.Text = "Points to show";
            // 
            // SimponsRuleCheckBox
            // 
            this.SimponsRuleCheckBox.AutoSize = true;
            this.SimponsRuleCheckBox.Location = new System.Drawing.Point(9, 74);
            this.SimponsRuleCheckBox.Name = "SimponsRuleCheckBox";
            this.SimponsRuleCheckBox.Size = new System.Drawing.Size(98, 17);
            this.SimponsRuleCheckBox.TabIndex = 7;
            this.SimponsRuleCheckBox.Text = "Simpson\'s Rule";
            this.SimponsRuleCheckBox.UseVisualStyleBackColor = true;
            // 
            // TrapezoidalRuleCheckBox
            // 
            this.TrapezoidalRuleCheckBox.AutoSize = true;
            this.TrapezoidalRuleCheckBox.Location = new System.Drawing.Point(9, 51);
            this.TrapezoidalRuleCheckBox.Name = "TrapezoidalRuleCheckBox";
            this.TrapezoidalRuleCheckBox.Size = new System.Drawing.Size(106, 17);
            this.TrapezoidalRuleCheckBox.TabIndex = 6;
            this.TrapezoidalRuleCheckBox.Text = "Trapezoidal Rule";
            this.TrapezoidalRuleCheckBox.UseVisualStyleBackColor = true;
            // 
            // RectangleMethodCheckBox
            // 
            this.RectangleMethodCheckBox.AutoSize = true;
            this.RectangleMethodCheckBox.Location = new System.Drawing.Point(9, 28);
            this.RectangleMethodCheckBox.Name = "RectangleMethodCheckBox";
            this.RectangleMethodCheckBox.Size = new System.Drawing.Size(114, 17);
            this.RectangleMethodCheckBox.TabIndex = 5;
            this.RectangleMethodCheckBox.Text = "Rectangle Method";
            this.RectangleMethodCheckBox.UseVisualStyleBackColor = true;
            // 
            // ShowPointsButton
            // 
            this.ShowPointsButton.Location = new System.Drawing.Point(12, 405);
            this.ShowPointsButton.Name = "ShowPointsButton";
            this.ShowPointsButton.Size = new System.Drawing.Size(75, 23);
            this.ShowPointsButton.TabIndex = 5;
            this.ShowPointsButton.Text = "Show";
            this.ShowPointsButton.UseVisualStyleBackColor = true;
            this.ShowPointsButton.Click += new System.EventHandler(this.ShowPointsButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SimponsResultLabel);
            this.panel1.Controls.Add(this.SimponsResultTextLabel);
            this.panel1.Controls.Add(this.TrapezoidalResultLabel);
            this.panel1.Controls.Add(this.TrapezoidalResultTextLabel);
            this.panel1.Controls.Add(this.RectangleResultLabel);
            this.panel1.Controls.Add(this.RectangleResultTextLabel);
            this.panel1.Location = new System.Drawing.Point(165, 551);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 32);
            this.panel1.TabIndex = 6;
            // 
            // SimponsResultLabel
            // 
            this.SimponsResultLabel.AutoSize = true;
            this.SimponsResultLabel.Location = new System.Drawing.Point(496, 9);
            this.SimponsResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SimponsResultLabel.Name = "SimponsResultLabel";
            this.SimponsResultLabel.Size = new System.Drawing.Size(10, 13);
            this.SimponsResultLabel.TabIndex = 5;
            this.SimponsResultLabel.Text = "-";
            // 
            // SimponsResultTextLabel
            // 
            this.SimponsResultTextLabel.AutoSize = true;
            this.SimponsResultTextLabel.Location = new System.Drawing.Point(396, 9);
            this.SimponsResultTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SimponsResultTextLabel.Name = "SimponsResultTextLabel";
            this.SimponsResultTextLabel.Size = new System.Drawing.Size(91, 13);
            this.SimponsResultTextLabel.TabIndex = 4;
            this.SimponsResultTextLabel.Text = "Simpon\'s Result - ";
            // 
            // TrapezoidalResultLabel
            // 
            this.TrapezoidalResultLabel.AutoSize = true;
            this.TrapezoidalResultLabel.Location = new System.Drawing.Point(298, 9);
            this.TrapezoidalResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TrapezoidalResultLabel.Name = "TrapezoidalResultLabel";
            this.TrapezoidalResultLabel.Size = new System.Drawing.Size(10, 13);
            this.TrapezoidalResultLabel.TabIndex = 3;
            this.TrapezoidalResultLabel.Text = "-";
            // 
            // TrapezoidalResultTextLabel
            // 
            this.TrapezoidalResultTextLabel.AutoSize = true;
            this.TrapezoidalResultTextLabel.Location = new System.Drawing.Point(198, 9);
            this.TrapezoidalResultTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TrapezoidalResultTextLabel.Name = "TrapezoidalResultTextLabel";
            this.TrapezoidalResultTextLabel.Size = new System.Drawing.Size(104, 13);
            this.TrapezoidalResultTextLabel.TabIndex = 2;
            this.TrapezoidalResultTextLabel.Text = "Trapezoidal Result - ";
            // 
            // RectangleResultLabel
            // 
            this.RectangleResultLabel.AutoSize = true;
            this.RectangleResultLabel.Location = new System.Drawing.Point(106, 9);
            this.RectangleResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RectangleResultLabel.Name = "RectangleResultLabel";
            this.RectangleResultLabel.Size = new System.Drawing.Size(10, 13);
            this.RectangleResultLabel.TabIndex = 1;
            this.RectangleResultLabel.Text = "-";
            // 
            // RectangleResultTextLabel
            // 
            this.RectangleResultTextLabel.AutoSize = true;
            this.RectangleResultTextLabel.Location = new System.Drawing.Point(6, 9);
            this.RectangleResultTextLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RectangleResultTextLabel.Name = "RectangleResultTextLabel";
            this.RectangleResultTextLabel.Size = new System.Drawing.Size(98, 13);
            this.RectangleResultTextLabel.TabIndex = 0;
            this.RectangleResultTextLabel.Text = "Rectangle Result - ";
            // 
            // NumericalIntegrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ShowPointsButton);
            this.Controls.Add(this.PointsToShowGroupBox);
            this.Controls.Add(this.NumericalIntegrationChart);
            this.Controls.Add(this.ParametersForIntegrationGroupBox);
            this.Controls.Add(this.IntegrateFunctionButton);
            this.Controls.Add(this.FunctionToFindIntegralGroupBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NumericalIntegrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numerical Integration";
            this.FunctionToFindIntegralGroupBox.ResumeLayout(false);
            this.FunctionToFindIntegralGroupBox.PerformLayout();
            this.ParametersForIntegrationGroupBox.ResumeLayout(false);
            this.ParametersForIntegrationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericalIntegrationChart)).EndInit();
            this.PointsToShowGroupBox.ResumeLayout(false);
            this.PointsToShowGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FunctionToFindIntegralGroupBox;
        private System.Windows.Forms.RadioButton SecondFunctionRadioButton;
        private System.Windows.Forms.RadioButton FirstFunctionRadioButton;
        private System.Windows.Forms.RadioButton ThirdFunctionRadioButton;
        private System.Windows.Forms.Button IntegrateFunctionButton;
        private System.Windows.Forms.GroupBox ParametersForIntegrationGroupBox;
        private System.Windows.Forms.Label SubIntervalsLabel;
        private System.Windows.Forms.Label IntervalEndLabel;
        private System.Windows.Forms.Label IntervalStartLabel;
        private System.Windows.Forms.TextBox NumberOfSubintervalsTextBox;
        private System.Windows.Forms.TextBox IntervalEndTextBox;
        private System.Windows.Forms.TextBox IntervalStartTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart NumericalIntegrationChart;
        private System.Windows.Forms.GroupBox PointsToShowGroupBox;
        private System.Windows.Forms.CheckBox RectangleMethodCheckBox;
        private System.Windows.Forms.CheckBox SimponsRuleCheckBox;
        private System.Windows.Forms.CheckBox TrapezoidalRuleCheckBox;
        private System.Windows.Forms.Button ShowPointsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SimponsResultLabel;
        private System.Windows.Forms.Label SimponsResultTextLabel;
        private System.Windows.Forms.Label TrapezoidalResultLabel;
        private System.Windows.Forms.Label TrapezoidalResultTextLabel;
        private System.Windows.Forms.Label RectangleResultLabel;
        private System.Windows.Forms.Label RectangleResultTextLabel;
    }
}

