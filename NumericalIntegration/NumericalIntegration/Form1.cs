using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NumericalIntegration
{
    public partial class NumericalIntegrationForm : Form
    {

        public enum Func
        {
            First = 1,
            Second = 2,
            Third = 3
        }

        class Point
        {
            public double x;
            public double y;

            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
        }
        
        class Function
        {
            public Func currentFunction;
            public double Calculate(double x)
            {
                if ((int)currentFunction == 1)
                {
                    return 2*x;
                }
                else if ((int)currentFunction == 2)
                {
                    return x*x*x;
                }
                else
                {
                    return 5*x*x*x*x - 4*x;
                }
            }
        }

        interface IIntegral
        {
            void IntegrateFunction(Function function, int intervalStart, int intervalEnd, int numberOfSubintervals);
        }

        class RestangleRule: IIntegral
        {
            public Point[] integratedPoints;

            public void IntegrateFunction(Function function, int intervalStart, int intervalEnd, int numberOfSubintervals)
            {
                double x, step, integral = 0;
                integratedPoints = new Point[numberOfSubintervals];
                step = (double)(intervalEnd - intervalStart) / numberOfSubintervals;
                for (int i = 1; i <= numberOfSubintervals; i++)
                {
                    x = intervalStart + (i - 1) * step;
                    integral += step * function.Calculate(x);
                    integratedPoints[i-1] = new Point(x, integral);
                }
            }
        }

        class TrapezoidalRule: IIntegral
        {
            public Point[] integratedPoints;
            public void IntegrateFunction(Function function, int intervalStart, int intervalEnd, int numberOfSubintervals)
            {
                double x, step;
                integratedPoints = new Point[numberOfSubintervals-1];
                step = (double)(intervalEnd - intervalStart) / numberOfSubintervals;
                double integral = function.Calculate(intervalStart) + function.Calculate(intervalEnd);
                for (int i = 1; i < numberOfSubintervals; i++)
                {
                    x = intervalStart + i * step;
                    integral += 2 * function.Calculate(x);
                    integratedPoints[i-1] = new Point(x, integral * step / 2);
                }
            }
        }

        class SimpsonsRule: IIntegral
        {
            public Point[] integratedPoints;
            public void IntegrateFunction(Function function, int intervalStart, int intervalEnd, int numberOfSubintervals)
            {
                double x, step;
                integratedPoints = new Point[numberOfSubintervals-1];
                step = (double)(intervalEnd - intervalStart) / numberOfSubintervals;
                double integral = function.Calculate(intervalStart) + function.Calculate(intervalEnd);
                for (int i = 1; i < numberOfSubintervals; i++)
                {
                    x = intervalStart + i * step;
                    if (i % 2 == 0)
                    {
                        integral += 2 * function.Calculate(x);
                    }
                    else
                    {
                        integral += 4 * function.Calculate(x);
                    }
                    integratedPoints[i-1] = new Point(x, integral * step / 3);
                } 
            }
        }

        private Func currentFunction;
        private Function function = new Function();

        private List<int> seriesToShow = new List<int>();
        private List<int> seriesToHide = new List<int>();

        private RestangleRule restangleIntegral = new RestangleRule();
        private TrapezoidalRule trapezoidalIntegral = new TrapezoidalRule();
        private SimpsonsRule simponsIntegral = new SimpsonsRule();


        public NumericalIntegrationForm()
        {
            InitializeComponent();
        }

        private void IntegrateFunctionButton_Click(object sender, EventArgs e)
        { 
            SetSettingsForIntegrationFromGroupBoxes();
            ClearChart();
            DrawSeries();
            FillListWithSeriesIndexesToShowAndHide();
            ShowCheckedPoints();
            HideUncheckedPoints();
        }

        private void SetSettingsForIntegrationFromGroupBoxes()
        {
            if (IntervalStartTextBox.Text != "" && IntervalEndTextBox.Text != "" && NumberOfSubintervalsTextBox.Text != "")
            {
                int intervalStart = int.Parse(IntervalStartTextBox.Text);
                int intervalEnd = int.Parse(IntervalEndTextBox.Text);
                int numberOfSubintervals = int.Parse(NumberOfSubintervalsTextBox.Text);
                
                ChooseFunctionToIntegrate();
                function.currentFunction = currentFunction;
                SetIntegrationClassesWithValues(intervalStart, intervalEnd, numberOfSubintervals);
                this.ActiveControl = null;
            }
            else
            {
                ShowErrorMessage("You should fill all text boxes!");
            }
        }
        
        private void ChooseFunctionToIntegrate()
        {
            if (FirstFunctionRadioButton.Checked) currentFunction = Func.First;
            else if (SecondFunctionRadioButton.Checked) currentFunction = Func.Second;
            else if (ThirdFunctionRadioButton.Checked) currentFunction = Func.Third;
        }

        private void SetIntegrationClassesWithValues(int intervalStart, int intervalEnd, int numberOfSubintervals)
        {
            restangleIntegral.IntegrateFunction(function, intervalStart, intervalEnd, numberOfSubintervals);
            trapezoidalIntegral.IntegrateFunction(function, intervalStart, intervalEnd, numberOfSubintervals);
            simponsIntegral.IntegrateFunction(function, intervalStart, intervalEnd, numberOfSubintervals);
        }

        private void ShowErrorMessage(string textOfError)
        {
            MessageBox.Show(textOfError,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
        }

        private void ClearChart()
        {
            foreach(Series serie in NumericalIntegrationChart.Series)
            {
                serie.Points.Clear();
            }
        }

        private void DrawSeries()
        {
            DrawRectanglePoints();
            DrawTrapezoidalPoints();
            DrawSimponPoints();
        }

        private void DrawRectanglePoints()
        {
            if (restangleIntegral.integratedPoints != null)
            {
                foreach (Point point in restangleIntegral.integratedPoints)
                {
                    NumericalIntegrationChart.Series[0].Points.AddXY(point.x, point.y);
                    NumericalIntegrationChart.Series[1].Points.AddXY(point.x, point.y);
                }
                RectangleResultLabel.Text = restangleIntegral.integratedPoints[restangleIntegral.integratedPoints.Length - 1].y.ToString("F4");
            }
        }

        private void DrawTrapezoidalPoints()
        {
            if (trapezoidalIntegral.integratedPoints != null && trapezoidalIntegral.integratedPoints.Length > 0)
            {
                foreach (Point point in trapezoidalIntegral.integratedPoints)
                {
                    NumericalIntegrationChart.Series[2].Points.AddXY(point.x, point.y);
                    NumericalIntegrationChart.Series[3].Points.AddXY(point.x, point.y);
                }
                TrapezoidalResultLabel.Text = trapezoidalIntegral.integratedPoints[trapezoidalIntegral.integratedPoints.Length - 1].y.ToString("F4");
            }
        }

        private void DrawSimponPoints()
        {
            if (simponsIntegral.integratedPoints != null && simponsIntegral.integratedPoints.Length > 0)
            {
                foreach (Point point in simponsIntegral.integratedPoints)
                {
                    NumericalIntegrationChart.Series[4].Points.AddXY(point.x, point.y);
                    NumericalIntegrationChart.Series[5].Points.AddXY(point.x, point.y);
                }
                SimponsResultLabel.Text = simponsIntegral.integratedPoints[simponsIntegral.integratedPoints.Length - 1].y.ToString("F4");
            }
        }

        private void FillListWithSeriesIndexesToShowAndHide()
        {
            if (RectangleMethodCheckBox.Checked)
            {
                seriesToShow.Add(0);
                seriesToShow.Add(1);
            }
            else
            {
                seriesToHide.Add(0);
                seriesToHide.Add(1);
            }

            if (TrapezoidalRuleCheckBox.Checked)
            {
                seriesToShow.Add(2);
                seriesToShow.Add(3);
            }
            else
            {
                seriesToHide.Add(2);
                seriesToHide.Add(3);
            }

            if (SimponsRuleCheckBox.Checked)
            {
                seriesToShow.Add(4);
                seriesToShow.Add(5);
            }
            else
            {
                seriesToHide.Add(4);
                seriesToHide.Add(5);
            }
        }

        private void ShowCheckedPoints()
        {
            foreach (int serie in seriesToShow)
            {
                NumericalIntegrationChart.Series[serie].Enabled = true;
            }

        }

        private void HideUncheckedPoints()
        {
            foreach (int serie in seriesToHide)
            {
                NumericalIntegrationChart.Series[serie].Enabled = false;
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IgnoreNotIntegerInTextBox(e);
        }

        private void IgnoreNotIntegerInTextBox(KeyPressEventArgs e)
        {
            char pressedKeyCharCode = e.KeyChar;
            const int CHARCODE_OF_DELETE_BUTTON = 8;
            const int CHARCODE_OF_ENTER_BUTTON = 13;
            const int CHARCODE_OF_MINUS_BUTTON = 45;
            if (!Char.IsDigit(pressedKeyCharCode) &&
                pressedKeyCharCode != CHARCODE_OF_DELETE_BUTTON &&
                pressedKeyCharCode != CHARCODE_OF_ENTER_BUTTON && pressedKeyCharCode != CHARCODE_OF_MINUS_BUTTON)
            {
                ShowErrorMessage("You should enter integer number!");
                e.Handled = true;
            }
        }

        private void ShowPointsButton_Click(object sender, EventArgs e)
        {
            seriesToShow.Clear();
            seriesToHide.Clear();
            FillListWithSeriesIndexesToShowAndHide();
            ShowCheckedPoints();
            HideUncheckedPoints();
        }
    }
}
