using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LissajousCurve
{
    public partial class LissajousCurveForm : Form
    {   
        private int amplitudeX;
        private int frequencyX;
        private double phaseX;
        private int amplitudeY;
        private int frequencyY;

        public LissajousCurveForm()
        {
            InitializeComponent();
            InitializeParametricEquationGroupBoxWithDefaultValues();
            SetParametersForLissajousCurveEquationFromGroupBoxes();
            DrawLissajousCurve();
        }

        private void InitializeParametricEquationGroupBoxWithDefaultValues() 
        {
            const int DEFAULT_X_AMPLITUDE = 1;
            const int DEFAULT_X_FREQUENCY = 3;
            const int DEFAULT_PHASE = 90;
            const int DEFAULT_Y_AMPLITUDE = 1;
            const int DEFAULT_Y_FREQUENCY = 2;

            InitializeParametricEquationXGroupBox(DEFAULT_X_AMPLITUDE, DEFAULT_X_FREQUENCY, DEFAULT_PHASE);
            InitializeParametricEquationYGroupBox(DEFAULT_Y_AMPLITUDE, DEFAULT_Y_FREQUENCY);
        } 

        private void InitializeParametricEquationXGroupBox(int defaultXAmplitude,int defaultXFrequency, int defaultXPhase)
        {
            ParametricEquationXAmplitudeTextBox.Text = "" + defaultXAmplitude;
            ParametricEquationXFrequencyTrackBar.Value = defaultXFrequency;
            ParametricEquationXPhaseTextBox.Text = "" + defaultXPhase;
        }

        private void InitializeParametricEquationYGroupBox(int defaultYAmplitude, int defaultYFrequency)
        {
            ParametricEquationYAmplitudeTextBox.Text = "" + defaultYAmplitude;
            ParametricEquationYFrequencyTrackBar.Value = defaultYFrequency;
        }

        private void SetParametersForLissajousCurveEquationFromGroupBoxes()
        {
            amplitudeX = int.Parse(ParametricEquationXAmplitudeTextBox.Text);
            phaseX = ConvertDegreeToRadian(int.Parse(ParametricEquationXPhaseTextBox.Text));
            frequencyX = ParametricEquationXFrequencyTrackBar.Value;
            amplitudeY = int.Parse(ParametricEquationYAmplitudeTextBox.Text);
            frequencyY = ParametricEquationYFrequencyTrackBar.Value;
        }
        private double ConvertDegreeToRadian(int degree)
        {
            return (Math.PI * degree) / 180;
        }
        private void DrawLissajousCurve()
        {
            double x, y;
            const double STEP_OF_DRAWING_POINTS = 0.01;
            const int NUMBER_OF_POINTS = 2000;
            for (double i = 0; i < NUMBER_OF_POINTS * STEP_OF_DRAWING_POINTS; i += STEP_OF_DRAWING_POINTS)
            {
                x = amplitudeX * Math.Sin(frequencyX * i + phaseX);
                y = amplitudeY * Math.Sin(frequencyY * i);
                LissajousCurveChart.Series[0].Points.AddXY(x, y);
            }
        }

        private void DrawLissajousCurveButton_Click(object sender, EventArgs e)
        {
            LissajousCurveChart.Series[0].Points.Clear();
            if (AreAllTextBoxesNotEmpty())
            {
                SetParametersForLissajousCurveEquationFromGroupBoxes();
                DrawLissajousCurve();
                this.ActiveControl = null;
            } else
            {
                ShowErrorMessage("You should fill all fields to draw lissajous curve!");
            }
        }

        private bool AreAllTextBoxesNotEmpty()
        {
            if (ParametricEquationXAmplitudeTextBox.Text != "" && 
                ParametricEquationYAmplitudeTextBox.Text != "" && 
                ParametricEquationXPhaseTextBox.Text != "")
            {
                return true;
            }
            else return false;
        }

        private void ShowErrorMessage(string textOfError)
        {
            MessageBox.Show(textOfError,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
        }

        private void ParametricEquationXFrequencyTrackBar_ValueChanged(object sender, EventArgs e)
        {
            ParametricEquationXFrequencyValueLabel.Text = "" + ParametricEquationXFrequencyTrackBar.Value;
        }

        private void ParametricEquationYFrequencyTrackBar_ValueChanged(object sender, EventArgs e)
        {
            ParametricEquationYFrequencyValueLabel.Text = "" + ParametricEquationYFrequencyTrackBar.Value;
        }

        private void ParametricEquationTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void ParametricEquationXPhaseTextBox_Leave(object sender, EventArgs e)
        {
            if (ParametricEquationXPhaseTextBox.Text != "")
            {
                const int END_OF_RANGE_IN_DEGREES = 180;
                CheckIfIntegerPositiveNumberIsOnRange(END_OF_RANGE_IN_DEGREES);
            }
        }

        private void CheckIfIntegerPositiveNumberIsOnRange(int endOfRangeInDegrees)
        {
            int phaseInDegrees = int.Parse(ParametricEquationXPhaseTextBox.Text);
            if (phaseInDegrees > endOfRangeInDegrees)
            {
                ShowErrorMessage("Enter phase, which will have angle not more than "  + endOfRangeInDegrees + " degrees!");
                this.ActiveControl = ParametricEquationXPhaseTextBox;
            }
        }

        private void ClearChartAreaButton_Click(object sender, EventArgs e)
        {
            LissajousCurveChart.Series[0].Points.Clear();
            this.ActiveControl = null;
        }
    }
}
