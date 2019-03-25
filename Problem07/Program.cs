using System;
using System.Diagnostics;

namespace Problem7
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

            const int NUMBER_OF_ITERATIONS = 1000;

            // The number to determine if is prime.  Start with 2, the first prime number
            long number = 2;

            for (int i = 1; i <= NUMBER_OF_ITERATIONS;)
            {
                var isPrime = IsPrime(number);

                if (isPrime && i == NUMBER_OF_ITERATIONS)
                {
                    break;
                }

                number++;

                if (isPrime)
                {
                    i++;
                }
            }

            Console.WriteLine($"Answer is 7919");
            Console.WriteLine($"Prime number {NUMBER_OF_ITERATIONS} = {number}");

            Console.WriteLine($"Execution took {stopWatch.ElapsedMilliseconds / 1000D} seconds");
        }

        #endregion

        private static void DoProblem()
        {
            var stopWatch = Stopwatch.StartNew();

            const int NUMBER_OF_ITERATIONS = 10001;

            // The number to determine if is prime.  Start with 2, the first prime number
            long number = 2;

            for (int i = 1; i <= NUMBER_OF_ITERATIONS;)
            {
                var isPrime = IsPrime(number);

                if (isPrime && i == NUMBER_OF_ITERATIONS)
                {
                    break;
                }

                number++;

                if (isPrime)
                {
                    i++;
                }
            }

            Console.WriteLine($"Prime number {NUMBER_OF_ITERATIONS} = {number}");

            Console.WriteLine($"Execution took {stopWatch.ElapsedMilliseconds / 1000D} seconds");
        }

        private static bool IsPrime(long number)
        {
            var isPrime = true;

            // Could optimize this further, but it runs in 40 seconds and the goal in under 60, so no further optimization needed.            
            for (long i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }

            //Console.WriteLine($"{number}, isPrime = {isPrime}");

            return isPrime;
        }
    }
}
