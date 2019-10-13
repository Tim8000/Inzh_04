using System;
using System.Collections;
using System.Collections.Generic;

namespace izh_04_basicCodingTask
{
    public class Methods
    {

        public static int[] DigitFilter(int[] sourceArray, int digitToFind)
        {

            var numbers = "";
            string value = "";
            var resultValues = new List<int>();

            for (int i = 0; i < sourceArray.Length; i++)
            {
                numbers += sourceArray[i] + ",";
            }


            foreach (var number in numbers.Split(","))
            {
                if (number.Contains(digitToFind.ToString()))
                {
                    value += number + ",";
                    resultValues.Add(Convert.ToInt32(number));

                }
            }

            return resultValues.ToArray();
        }

        public static int InsertNumber(int first, int second, int i, int j)
        {
            if (i > j)
            {
                throw new ArgumentOutOfRangeException($"{nameof(i)} must be less or equal {nameof(j)}.");
            }

            int medium = ((2 << (j - i)) - 1) << i;
            return (first & ~medium) | ((second << i) & medium);
        }

        /// <summary>
        /// Remove cyrillic characters and concats string with unique values.
        /// </summary>
        /// <param name="firstString"></param>
        /// <param name="secondString"></param>
        /// <returns></returns>
        public static string StringConcatenation(string firstString, string secondString)
        {
            return RemoveUniques(firstString) + RemoveUniques(secondString);
        }


        private static string RemoveUniques(string sourceString)
        {
            var sList = new ArrayList();
            var result = "";

            for (int i = 0; i < sourceString.Length; i++)
            {
                if (sList.Contains(sourceString[i]) == false)
                {
                    if (((sourceString[i] >= 'a') && (sourceString[i] <= 'z')) || ((sourceString[i] >= 'A') && (sourceString[i] <= 'Z')))
                    {
                        sList.Add(sourceString[i]);
                    }

                }
            }


            var sNew = sList.ToArray();

            foreach (var character in sList)
            {
                result += character.ToString();
            }

            return result;
        }

    }
}
