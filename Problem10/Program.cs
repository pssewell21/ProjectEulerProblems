using System;
using System.Diagnostics;

namespace Problem10
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

            const int MAX_PRIME_VALUE = 100;

            int number = 2;

            long sum = 0;

            while (number <= MAX_PRIME_VALUE)
            {
                if (IsPrime(number))
                {
                    sum += number;

                    Console.WriteLine($"{number} is prime, new sum = {sum}");
                }

                number++;
            }

            Console.WriteLine($"Sum of prime numbers below {MAX_PRIME_VALUE} = {sum}");

            Console.WriteLine($"Execution took {stopWatch.ElapsedMilliseconds / 1000D} seconds");
        }

        #endregion

        private static void DoProblem()
        {
            var stopWatch = Stopwatch.StartNew();

            const int MAX_PRIME_VALUE = 2000000;

            int number = 2;

            long sum = 0;

            while (number <= MAX_PRIME_VALUE)
            {
                if (IsPrime(number))
                {
                    sum += number;

                    //Console.WriteLine($"{number} is prime, new sum = {sum}");
                }

                number++;
            }

            Console.WriteLine($"Sum of prime numbers below {MAX_PRIME_VALUE} = {sum}");

            Console.WriteLine($"Execution took {stopWatch.ElapsedMilliseconds / 1000D} seconds");
        }

        private static bool IsPrime(long number)
        {

            if (number <= 3)
            {
                return number > 1;
            }
            else if (number % 2 == 0 || number % 3 == 0)
            {
                return false;
            }
            
            var isPrime = true;

            for (long i = 5; i <= Math.Sqrt(number); i++)
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
