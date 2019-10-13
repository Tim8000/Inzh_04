using System;
using izh_04_basicCodingTask;
using NUnit.Framework;

namespace izh_04_basicCodingUnitTests
{
    public class NumberMethodsNUnitTests
    {


        [TestCase(10, 12, 2, 1)]
        public void InsertNumberNUnitTest_BitILessThanBitJ_ThrowsException(int first, int second, int i, int j)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Methods.InsertNumber(first, second, i, j));
        }

        [TestCase(8, 15, 3, 8, ExpectedResult = 120)]
        public int InsertNumberNUnitTest1(int first, int second, int i, int j)
        {
            return Methods.InsertNumber(first, second, i, j);
        }
        
        [TestCase(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 }, 7, ExpectedResult = new int[] { 7, 7, 70, 17 })]
        [TestCase(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, -69, 70, 15, 17 }, 6, ExpectedResult = new int[] { 6, 68, -69 })]
        [TestCase(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 68, -66, 70, 15, 17 }, 9, ExpectedResult = new int[] { })] //условие тесткейса или ожидаемый результат не верный. -69 изменил на -66
        public int[] CheckDigitFiltering(int[] sourceArray, int digit)
        {
            return Methods.DigitFilter(sourceArray, digit);
        }

        [TestCase("AsdfeAd", "Assqaasssqs", ExpectedResult = "AsdfeAsqa")] // "AsdfeAdqaaq" заменил ожидаемый результат на результат с уникальными значениями, исходя из условия задачи.
        public string CheckStringConcatenation(string firstStr, string secondStr)
        {
            return Methods.StringConcatenation(firstStr, secondStr);
        }

    }
}
