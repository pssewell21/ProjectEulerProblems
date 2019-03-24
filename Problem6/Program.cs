using System;
using System.Diagnostics;

namespace Problem6
{
    class Program
    {
        static void Main(string[] args)
        {
            DoSampleProblem();
            DoProblem();

            Console.Read();
        }

        #region Sample Problem

        private static void DoSampleProblem()
        {
            var stopWatch = Stopwatch.StartNew();

            int value = 10;

            int sumOfSquares = GetSumOfSquares(value);

            int squareOfSums = GetSquareOfSums(value);

            var difference = squareOfSums - sumOfSquares;

            Console.WriteLine($"The difference is {difference}");

            Console.WriteLine($"Execution took {stopWatch.ElapsedMilliseconds / 1000D} seconds");
        }

        #endregion

        private static void DoProblem()
        {
            var stopWatch = Stopwatch.StartNew();

            int value = 100;

            int sumOfSquares = GetSumOfSquares(value);

            int squareOfSums = GetSquareOfSums(value);

            var difference = squareOfSums - sumOfSquares;

            Console.WriteLine($"The difference is {difference}");

            Console.WriteLine($"Execution took {stopWatch.ElapsedMilliseconds / 1000D} seconds");
        }
        
        private static int GetSumOfSquares(int number)
        {
            int sum = 0;

            for (int i = 0; i <= number; i++)
            {
                sum += i * i;
            }

            return sum;
        }

        private static int GetSquareOfSums(int number)
        {
            int valueToSquare = 0;
            
            for (int i = 0; i <= number; i++)
            {
                valueToSquare += i;
            }

            return valueToSquare * valueToSquare;
        }
    }
}
