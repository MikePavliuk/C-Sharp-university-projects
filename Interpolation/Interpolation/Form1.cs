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

namespace Interpolation
{
    public partial class InterpolationForm : Form
    {
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

        abstract class СInterpolation
        {
            public Point[,] interpolatedSegmentsOfPoints;
            public abstract void InterpolatePoints(int numberOfPointsPerSegment, Point[] inputPointsForInterpolation);
        }

        class LineInterpolation : СInterpolation
        {

            public override void InterpolatePoints(int numberOfPointsPerSegment, Point[] inputPointsForInterpolation)
            {
                double x, y, step;
                int numberOfInputPoints = inputPointsForInterpolation.Length;
                interpolatedSegmentsOfPoints = new Point[numberOfInputPoints - 1, numberOfPointsPerSegment];
                for (int i = 0; i < numberOfInputPoints - 1; i++)
                {
                    Point startPointOfSegment;
                    Point endPointOfSegment;

                    startPointOfSegment = inputPointsForInterpolation[i];
                    endPointOfSegment = inputPointsForInterpolation[i + 1];

                    double scaleCoefficient = 1.0 / (numberOfPointsPerSegment-1);
                    for (int j = 0; j < numberOfPointsPerSegment; j++)
                    {
                        step = scaleCoefficient * j;
                        x = startPointOfSegment.x + (endPointOfSegment.x - startPointOfSegment.x) * step;
                        y = startPointOfSegment.y + step * (endPointOfSegment.y - startPointOfSegment.y);
                        interpolatedSegmentsOfPoints[i, j] = new Point(x, y);
                    }
                }
            }
        }

        class HermiteInterpolation : СInterpolation
        {
            public override void InterpolatePoints(int numberOfPointsPerSegment, Point[] inputPointsForInterpolation)
            {
                double x, y, step;
                int numberOfInputPoints = inputPointsForInterpolation.Length;
                interpolatedSegmentsOfPoints = new Point[numberOfInputPoints - 1, numberOfPointsPerSegment];
                for (int i = 0; i < numberOfInputPoints - 1; i++)
                {
                    Point BeforeA;
                    Point A;
                    Point B;
                    Point AfterB;

                    if (i == 0)
                        BeforeA = new Point(0, 0);
                    else BeforeA = inputPointsForInterpolation[i - 1];
                    A = inputPointsForInterpolation[i];
                    B = inputPointsForInterpolation[i + 1];
                    if (i == numberOfInputPoints - 2)
                        AfterB = new Point(0, 0);
                    else AfterB = inputPointsForInterpolation[i + 2];

                    double c0 = A.y;
                    double c1 = (1 / 2.0) * (B.y - BeforeA.y);
                    double c2 = BeforeA.y - ((5 / 2.0) * A.y) + (2 * B.y) - ((1 / 2.0) * AfterB.y);
                    double c3 = ((1 / 2.0) * (AfterB.y - BeforeA.y)) + ((3 / 2.0) * (A.y - B.y));

                    double scaleCoefficient = 1.0 / (numberOfPointsPerSegment-1);
                    for (int j = 0; j < numberOfPointsPerSegment; j++)
                    {
                        step = scaleCoefficient * j;
                        x = A.x + (B.x - A.x) * step;
                        y = ((c3 * step + c2) * step + c1) * step + c0;
                        interpolatedSegmentsOfPoints[i, j] = new Point(x, y);
                    }
                }
            }
        }

        LineInterpolation LineInterpolator = new LineInterpolation();
        HermiteInterpolation HermiteInterpolator = new HermiteInterpolation();

        Point[] inputPointsForInterpolation;

        private List<int> seriesToShow = new List<int>();
        private List<int> seriesToHide = new List<int>();

        public InterpolationForm()
        {
            InitializeComponent();
            InitializeGroupBoxesWithDefaultValues();
            SetSettingsForInterpolationFromGroupBoxes();
            DefaultPointsCheckBox.Checked = true;
            FillListWithSeriesIndexesToShowAndHide();
            HideUncheckedPoints();
            DrawSeries();
        }
        private void InitializeGroupBoxesWithDefaultValues()
        {
            const int DEFAULT_AMPLITUDE = 1;
            const int DEFAULT_FREQUENCY = 1;
            const int NUMBER_OF_POINTS_PER_SEGMENT = 10;
            const int NUMBER_OF_INPUT_POINTS = 9;

            AmplitudeTextBox.Text = "" + DEFAULT_AMPLITUDE;
            FrequencyTextBox.Text = "" + DEFAULT_FREQUENCY;
            NumberOfPointsPerSegmentTextBox.Text = "" + NUMBER_OF_POINTS_PER_SEGMENT;
            NumberOfInputPointsTextBox.Text = "" + NUMBER_OF_INPUT_POINTS;

        }
        private void SetSettingsForInterpolationFromGroupBoxes()
        {
            if (AmplitudeTextBox.Text != "" && FrequencyTextBox.Text != "" && NumberOfPointsPerSegmentTextBox.Text != ""
                && NumberOfInputPointsTextBox.Text != "" && NumberOfInputPointsTextBox.Text != "0")
            {
                int numberOfPointsPerSegment = int.Parse(NumberOfPointsPerSegmentTextBox.Text);
                int numberOfInputPoints = int.Parse(NumberOfInputPointsTextBox.Text);
                int amplitude = int.Parse(AmplitudeTextBox.Text);
                int frequency = int.Parse(FrequencyTextBox.Text);

                SetSettingsProperties(numberOfPointsPerSegment, numberOfInputPoints, amplitude, frequency);

                this.ActiveControl = null;
            }
            else
            {
                ShowErrorMessage("You should fill all text boxes (and remember that number of input points can't be 0)!");
            }
        }

        private void SetSettingsProperties(int numberOfPointsPerSegment, int numberOfInputPoints, int amplitude, int frequency)
        {
            inputPointsForInterpolation = new Point[numberOfInputPoints];
            FillInputPointsArrayWithSinusoidalValues(amplitude, frequency);
            SetInterpolationClassesWithProperties(numberOfPointsPerSegment);
        }

        private void FillInputPointsArrayWithSinusoidalValues(int amplitude, int frequency)
        {
            const double PHASE = 0;
            double step = (2 * Math.PI) / (inputPointsForInterpolation.Length - 1);
            double x = 0;
            for (int i = 0; i < inputPointsForInterpolation.Length; i++)
            {
                double y = amplitude * Math.Sin(frequency * x + PHASE);
                inputPointsForInterpolation[i] = new Point(x, y);
                x += step;
            }
        }

        private void SetInterpolationClassesWithProperties(int numberOfPointsPerSegment)
        {
            LineInterpolator.InterpolatePoints(numberOfPointsPerSegment, inputPointsForInterpolation);
            HermiteInterpolator.InterpolatePoints(numberOfPointsPerSegment, inputPointsForInterpolation);
        }

        private void ShowErrorMessage(string textOfError)
        {
            MessageBox.Show(textOfError,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
        }

        private void FillListWithSeriesIndexesToShowAndHide()
        {
            if (DefaultPointsCheckBox.Checked)
            {
                seriesToShow.Add(2);
            }
            else
            {
                seriesToHide.Add(2);
            }

            if (LinearInterpolationCheckBox.Checked)
            {
                seriesToShow.Add(0);
            }
            else
            {
                seriesToHide.Add(0);
            }

            if (HermiteInterpolationCheckBox.Checked)
            {
                seriesToShow.Add(1);
            }
            else
            {
                seriesToHide.Add(1);
            }
        }

        private void ShowCheckedPoints()
        {
            foreach (int serie in seriesToShow)
            {
                InterpolationChart.Series[serie].Enabled = true;
            }

        }

        private void HideUncheckedPoints()
        {
            foreach (int serie in seriesToHide)
            {
                InterpolationChart.Series[serie].Enabled = false;
            }
        }

        private void DrawSeries()
        {
            DrawDefaultPoints();
            DrawLineInterpolatedPoints();
            DrawHermiteInterpolatedPoints();
        }

        private void DrawDefaultPoints()
        {
            foreach (Point inputPoint in inputPointsForInterpolation)
            {
                InterpolationChart.Series[2].Points.AddXY(inputPoint.x, inputPoint.y);
            }
        }

        private void DrawLineInterpolatedPoints()
        {
            foreach (Point lineInterpolatedPoint in LineInterpolator.interpolatedSegmentsOfPoints)
            {
                InterpolationChart.Series[0].Points.AddXY(lineInterpolatedPoint.x, lineInterpolatedPoint.y);
            }
        }

        private void DrawHermiteInterpolatedPoints()
        {
            foreach (Point hermiteInterpolatedPoint in HermiteInterpolator.interpolatedSegmentsOfPoints)
            {
                InterpolationChart.Series[1].Points.AddXY(hermiteInterpolatedPoint.x, hermiteInterpolatedPoint.y);
            }
        }

        private void ConfirmParametersForChart_Click(object sender, EventArgs e)
        {
            SetSettingsForInterpolationFromGroupBoxes();
            ClearChart();
            DrawSeries();
        }

        private void ClearChart()
        {
            foreach (Series serie in InterpolationChart.Series)
            {
                serie.Points.Clear();
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

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IgnoreNotDigitCharInTextBox(e);
        }

        private void IgnoreNotDigitCharInTextBox(KeyPressEventArgs e)
        {
            char pressedKeyCharCode = e.KeyChar;
            const int CHARCODE_OF_DELETE_BUTTON = 8;
            const int CHARCODE_OF_ENTER_BUTTON = 13;
            if (!Char.IsDigit(pressedKeyCharCode) &&
                pressedKeyCharCode != CHARCODE_OF_DELETE_BUTTON &&
                pressedKeyCharCode != CHARCODE_OF_ENTER_BUTTON)
            {
                ShowErrorMessage("You are not allowed to enter negative numbers, letters or any symbols!");
                e.Handled = true;
            }
        }
    }
}
