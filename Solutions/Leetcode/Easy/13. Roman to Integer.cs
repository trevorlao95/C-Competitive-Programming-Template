using CSharpCompProgrammingTemplate.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpCompProgrammingTemplate
{
    public class LeetCodeConsole : LeetCode
    {
        private static void Main(string[] args)
        {
            #region Main

            var solution = new Solution();
            while (MoreColumns()) QuestionHelpers.Time(() => solution.

            #endregion Main

            /**
             * Change method and inputs here, possible values:
             * • Int
             * • IntGrid
             * • IntArray
             * • AllIntArray
             * • StringArray
             * • String
             * **/

            RomanToInt(String()));
        }

        #region Solution

        public class Solution
        {
            public int RomanToInt(string s)
            {
                int totalNumber = 0;
                int previousNumber = 0;
                
                for (int i = 0; i < s.Length; i++)
                {
                    char romanNumeral = s[i];
                    int number = GetRomanNumeralValue(romanNumeral);

                    if (previousNumber < number)
                        previousNumber = previousNumber * -1;

                    totalNumber = totalNumber + previousNumber;

                    previousNumber = number;
                }

                totalNumber = totalNumber + GetRomanNumeralValue(s[s.Length - 1]);

                return totalNumber;
            }

            public int GetRomanNumeralValue(char romanNumeral)
            {
                switch (romanNumeral)
                {
                    case 'I':
                        return 1;
                    case 'V':
                        return 5;
                    case 'X':
                        return 10;
                    case 'L':
                        return 50;
                    case 'C':
                        return 100;
                    case 'D':
                        return 500;
                    case 'M':
                        return 1000;
                    default:
                        return 0;
                }
            }
        }
    }

    #endregion Solution
}