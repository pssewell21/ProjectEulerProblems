using System;
using System.Diagnostics;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestIsPalendromic();
            //DoSampleProblem();
            DoProblem();

            Console.Read();
        }

        #region Sample Problem

        private static void DoSampleProblem()
        {
            var stopWatch = Stopwatch.StartNew();

            int largestPalindrome = 0;

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    var product = i * j;

                    var isPalindromic = IsPalindromic(product);

                    Console.WriteLine($"{i} * {j} = {product}, IsPalindromic = {isPalindromic}");

                    if (isPalindromic && product > largestPalindrome)
                    {
                        largestPalindrome = product;
                    }
                }
            }

            Console.WriteLine($"Largest Palindrome = {largestPalindrome}");

            Console.WriteLine($"Execution took {stopWatch.ElapsedMilliseconds / 1000D} seconds");
        }

        #endregion

        private static void DoProblem()
        {
            var stopWatch = Stopwatch.StartNew();

            int largestPalindrome = 0;

            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    var product = i * j;

                    var isPalindromic = IsPalindromic(product);

                    //Console.WriteLine($"{i} * {j} = {product}, IsPalindromic = {isPalindromic}");

                    if (isPalindromic && product > largestPalindrome)
                    {
                        largestPalindrome = product;
                    }
                }
            }

            Console.WriteLine($"Largest Palindrome = {largestPalindrome}");

            Console.WriteLine($"Execution took {stopWatch.ElapsedMilliseconds / 1000D} seconds");
        }

        private static bool IsPalindromic(int number)
        {
            var numberCharArray = number.ToString();

            if (numberCharArray.Length <= 1)
            {
                return false;
            }

            for (int i = 0; i <= numberCharArray.Length / 2; i++)
            {
                if (!Equals(numberCharArray[i], numberCharArray[numberCharArray.Length - i - 1]))
                {
                    return false;
                }
            }

            return true;
        }

        private static void TestIsPalendromic()
        {
            var stopWatch = Stopwatch.StartNew();

            // FALSE
            var number = 0;
            var isPalindromic = IsPalindromic(number);
            Console.WriteLine($"{number} IsPalindromic = {isPalindromic}");

            // FALSE
            number = 5;
            isPalindromic = IsPalindromic(number);
            Console.WriteLine($"{number} IsPalindromic = {isPalindromic}");

            // TRUE
            number = 11;
            isPalindromic = IsPalindromic(number);
            Console.WriteLine($"{number} IsPalindromic = {isPalindromic}");

            // FALSE
            number = 12;
            isPalindromic = IsPalindromic(number);
            Console.WriteLine($"{number} IsPalindromic = {isPalindromic}");

            // FALSE
            number = 21;
            isPalindromic = IsPalindromic(number);
            Console.WriteLine($"{number} IsPalindromic = {isPalindromic}");

            // TRUE
            number = 111;
            isPalindromic = IsPalindromic(number);
            Console.WriteLine($"{number} IsPalindromic = {isPalindromic}");

            // TRUE
            number = 121;
            isPalindromic = IsPalindromic(number);
            Console.WriteLine($"{number} IsPalindromic = {isPalindromic}");

            // FALSE
            number = 231;
            isPalindromic = IsPalindromic(number);
            Console.WriteLine($"{number} IsPalindromic = {isPalindromic}");

            Console.WriteLine($"Execution took {stopWatch.ElapsedMilliseconds / 1000D} seconds");
        }
    }
}
