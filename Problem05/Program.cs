using System;
using System.Diagnostics;

namespace Problem5
{
    class Program
    {
        static void Main(string[] args)
        {
            TestIsDivisibleByUpToTen();
            //DoSampleProblem();
            DoProblem();

            Console.Read();
        }

        #region Sample Problem

        private static void DoSampleProblem()
        {
            var stopWatch = Stopwatch.StartNew();

            int number = 10;
            var isEvenlyDivisible = false;

            while (!isEvenlyDivisible)
            {
                number++;

                isEvenlyDivisible = IsDivisibleByUpToTen(number);
            }

            Console.WriteLine($"First evenly divisible number is {number}");

            Console.WriteLine($"Execution took {stopWatch.ElapsedMilliseconds / 1000D} seconds");
        }

        #endregion

        private static void DoProblem()
        {
            var stopWatch = Stopwatch.StartNew();

            int number = 10;
            var isEvenlyDivisible = false;

            while (!isEvenlyDivisible)
            {
                number++;

                isEvenlyDivisible = IsDivisibleByUpToTwenty(number);
            }

            Console.WriteLine($"First evenly divisible number is {number}");

            Console.WriteLine($"Execution took {stopWatch.ElapsedMilliseconds / 1000D} seconds");
        }

        private static bool IsDivisibleByUpToTen(int number)
        {
            for (int i = 2; i < 11; i++)
            {
                if (number % i != 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsDivisibleByUpToTwenty(int number)
        {
            for (int i = 2; i < 21; i++)
            {
                if (number % i != 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static void TestIsDivisibleByUpToTen()
        {
            //FALSE
            int number = 3;
            Console.WriteLine($"{number} is divisible = {IsDivisibleByUpToTen(number)}");

            //TRUE
            number = 8;
            Console.WriteLine($"{number} is divisible = {IsDivisibleByUpToTen(number)}");
        }
    }
}
