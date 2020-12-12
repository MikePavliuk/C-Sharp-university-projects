using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_expression
{
    class DatePattern
    {
        public List<string> PatternsForRegexForMonth;
        public string PatternForRegexForDay;
        public string Replacement;
        private string definition;
        private int maxPossibleNumberOfDays;
        static string patternMatchAnythingWithUnlimitedTime = ".*";
        static string patternDoesntMatchAnything = "(?!.*)";
        static string patternOr = "|";

        public DatePattern(string definition, int maxPossibleNumberOfDays)
        {
            Replacement = definition;
            this.definition = definition.ToLower();
            this.maxPossibleNumberOfDays = maxPossibleNumberOfDays;
            PatternsForRegexForMonth = new List<string>();
            CreatePatternForDay();
            InitializePatternsForMonth();


        }

        private void InitializePatternsForMonth()
        {
            CreatePatternsWithNumberOfLettersWithFirstLetterWithoutGarbage(definition.Length);
            CreatePatternsWithTwoHafsOfWordWithGarbage();
            for(int i = definition.Length; i >= 3; i--)
            {
                CreatePatternsWithNumberOfLettersWithFirstLetterWithoutGarbage(i);

            }
            for (int i = definition.Length; i >= 3; i--)
            {
                if (definition.Length > 5 && i == 3) break;
                CreatePatternsWithNumberOfLettersWithFirstLetterWithGarbage(i);
            }
            for (int i = definition.Length; i >= 2; i--)
            {
                if (i == 6 && definition.Length == 7 && definition[0] == 'j') CreatePatternsThatMatchNothingInAmountOf(2);
                if (i == 3 && definition.Length == 4 && definition[2] == 'l') PatternsForRegexForMonth.Add("^ju.*y");
                if (i == 3 && definition.Length == 4 && definition[2] == 'n') PatternsForRegexForMonth.Add("^ju.*e");
                if (i == 2 && definition.Length == 4) CreatePatternsThatMatchNothingInAmountOf(15);
                if (i == 2 && definition.Length == 5 || definition.Length == 6) CreatePatternsThatMatchNothingInAmountOf(15);
                if(i == 2 && definition.Length == 3) CreatePatternsThatMatchNothingInAmountOf(20);
                CreatePatternsWithNumberOfLettersWithoutFirstLetterWithoutGarbage(i);
            }
            if (definition.Length == 3) {
                CreatePatternsThatMatchNothingInAmountOf(30);
                CreatePatternsWithNumberOfLettersWithFirstLetterWithGarbage(2);
            }
            for (int i = definition.Length; i >= 2; i--)
            {
                CreatePatternsWithNumberOfLettersWithoutFirstLetterWithGarbage(i);
            }

            CreatePatternsWithNumberOfLettersWithFirstLetterWithoutGarbage(2);
            if (definition.Length != 3) CreatePatternsWithNumberOfLettersWithFirstLetterWithGarbage(2);
            if (definition.Length == 3)
            {
                CreatePatternsThatMatchNothingInAmountOf(30);
                CreatePatternsWithNumberOfLettersWithFirstLetterWithoutGarbage(1);
            }

        }

        private void CreatePatternsWithTwoHafsOfWordWithGarbage()
        {
            string pattern = "";
            for (int i = 1; i < definition.Length; i++)
            {
                pattern += "(";
                pattern += definition.Substring(0, i);
                pattern += patternMatchAnythingWithUnlimitedTime;
                pattern += definition.Substring(i, definition.Length - i);
                pattern += ")";
                if (i != definition.Length - 1) pattern += patternOr;
            }
            PatternsForRegexForMonth.Add(pattern);
        }


        private void CreatePatternsWithNumberOfLettersWithFirstLetterWithoutGarbage(int numberOfLetters)
        {
            string pattern = "";
            int numberOfLettersWithoutFirstWord = numberOfLetters - 1;
            for (int i = 0; i < definition.Length - numberOfLettersWithoutFirstWord; i++)
            {
                pattern += "(";
                pattern += definition[0].ToString();
                for (int j = 1; j <= numberOfLettersWithoutFirstWord; j++)
                {
                    pattern += definition[i + j];
                }
                pattern += ")";
                if (i != definition.Length - numberOfLettersWithoutFirstWord - 1) pattern += patternOr;
            }
            PatternsForRegexForMonth.Add(pattern);
        }

        private void CreatePatternsWithNumberOfLettersWithoutFirstLetterWithoutGarbage(int numberOfLetters)
        {
            string pattern = "";
            for (int i = 0; i < definition.Length - (numberOfLetters - 1); i++)
            {
                pattern += "(";
                for (int j = 0; j <= numberOfLetters - 1; j++)
                {
                    pattern += definition[i + j];
                }
                pattern += ")";
                if (i != definition.Length - numberOfLetters) pattern += patternOr;
            }
            PatternsForRegexForMonth.Add(pattern);
        }

        private void CreatePatternsWithNumberOfLettersWithFirstLetterWithGarbage(int numberOfLetters)
        {
            string pattern = "";
            int numberOfLettersWithoutFirstWord = numberOfLetters - 1;
            for (int i = 0; i < definition.Length - numberOfLettersWithoutFirstWord; i++)
            {
                pattern += "(";
                pattern += "^";
                pattern += definition[0].ToString();
                pattern += patternMatchAnythingWithUnlimitedTime;
                for (int j = 1; j <= numberOfLettersWithoutFirstWord; j++)
                {
                    pattern += definition[i + j];
                    pattern += patternMatchAnythingWithUnlimitedTime;
                }
                pattern += ")";
                if (i != definition.Length - numberOfLettersWithoutFirstWord - 1) pattern += patternOr;
            }
            PatternsForRegexForMonth.Add(pattern);
        }

        private void CreatePatternsWithNumberOfLettersWithoutFirstLetterWithGarbage(int numberOfLetters)
        {
            string pattern = "";
            for (int i = 0; i < definition.Length - (numberOfLetters - 1); i++)
            {
                pattern += "(";
                for (int j = 0; j <= numberOfLetters - 1; j++)
                {
                    pattern += definition[i + j];
                    pattern += patternMatchAnythingWithUnlimitedTime;
                }
                pattern += ")";
                if (i != definition.Length - numberOfLetters) pattern += patternOr;
            }
            PatternsForRegexForMonth.Add(pattern); 
        }

        private void CreatePatternsThatMatchNothingInAmountOf(int amountOfPatternsThatMatchesNothing)
        {
            for(int i = 0; i < amountOfPatternsThatMatchesNothing; i++)
            {
                PatternsForRegexForMonth.Add(patternDoesntMatchAnything);
            }
        }

        private void CreatePatternForDay()
        {
            if (maxPossibleNumberOfDays / 10 == 3) PatternForRegexForDay = "([3][" + maxPossibleNumberOfDays % 10 + "])|";
             PatternForRegexForDay += "([1-2][0-9])|([1-9])";
        }

    }
}
