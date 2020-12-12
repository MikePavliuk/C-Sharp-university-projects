using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Regular_expression
{
    public partial class RegularExpressionForm : Form
    {

        Dictionary<string, int> possibleMonths = new Dictionary<string, int>()
        {
            {"January", 30},
            {"February", 29},
            {"March", 31},
            {"April", 30},
            {"May", 31},
            {"June", 30},
            {"July", 31},
            {"August", 31},
            {"September", 30},
            {"October", 31},
            {"November", 30},
            {"December", 31},
        };
        List<DatePattern> months;
        int theLargestNumberOfRegicesOfMonth;

        public RegularExpressionForm()
        {
            InitializeComponent();
            months = new List<DatePattern>();
            InitializeMonthsForRegices();
            theLargestNumberOfRegicesOfMonth = GetTheLargestNumberOfRegicesOfMonthPossibleMonths();
        }

        private void InitializeMonthsForRegices()
        {
            foreach (KeyValuePair<string, int> possibleMonth in possibleMonths)
            {
                months.Add(new DatePattern(possibleMonth.Key, possibleMonth.Value));
            }
        }

        private int GetTheLargestNumberOfRegicesOfMonthPossibleMonths()
        {
            int theLargestNumberOfRegicesOfMonth = 0;
            foreach (DatePattern month in months)
            {
                if (month.PatternsForRegexForMonth.Count > theLargestNumberOfRegicesOfMonth) theLargestNumberOfRegicesOfMonth = month.PatternsForRegexForMonth.Count;
            }
            return theLargestNumberOfRegicesOfMonth;
        }

        private void InputTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            string inputText = InputTextBox.Text;
            if (inputText == "")
            {
                OutputLabel.Text = "";
                return;
            }
            for (int indexOfRegexPattern = 0; indexOfRegexPattern < theLargestNumberOfRegicesOfMonth; indexOfRegexPattern++)
            {
                for (int indexOfMonth = 0; indexOfMonth < months.Count; indexOfMonth++)
                {
                    int day = 0;
                    Match matchDay = Regex.Match(inputText, months[indexOfMonth].PatternForRegexForDay);
                    if (matchDay.Success)
                    {
                        day = int.Parse(matchDay.Value);
                    }
                    else
                    {
                        return;
                    }
                    if (months[indexOfMonth].PatternsForRegexForMonth.Count > indexOfRegexPattern)
                    {
                        Match matchMonth = Regex.Match(inputText, months[indexOfMonth].PatternsForRegexForMonth[indexOfRegexPattern], RegexOptions.IgnoreCase);
                        if (matchMonth.Success)
                        {
                            OutputLabel.Text = day + "-" + months[indexOfMonth].Replacement;
                            return;
                        }
                    }
                }
            }
            OutputLabel.Text = "";
        }
    }
}
