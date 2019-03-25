using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            //DoSampleProblem();
            DoProblem();

            Console.Read();
        }

        #region Sample Problem

        private static void DoSampleProblem()
        {
            const int VALUE = 13195;

            var primeFactorList = new List<int>();

            for (int i = 1; i < VALUE; i++)
            {
                Console.WriteLine($"Finding out if {i} is a prime factor of {VALUE}");

                var isPrime = true;

                if (VALUE % i == 0 && i != 1)
                {
                    Console.WriteLine($"{i} is a factor of {VALUE}");

                    for (int j = 1; j < i; j++)
                    {
                        Console.WriteLine($"Finding out if {j} is a factor of {i} to see if {i} is prime");

                        if (i % j == 0 && j != 1)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        Console.WriteLine($"{i} is a prime factor of {VALUE}");
                        primeFactorList.Add(i);
                    }
                    else
                    {
                        Console.WriteLine($"{i} is not prime so it is not a prime factor of {VALUE}");
                    }
                }
                else
                {
                    Console.WriteLine($"{i} is not a factor of {VALUE}");
                }
            }

            Console.Write($"Prime factors of {VALUE} are: ");

            foreach(var item in primeFactorList)
            {
                if (primeFactorList.IndexOf(item) == primeFactorList.Count - 1)
                {
                    Console.Write($"{item}");
                }
                else
                {
                    Console.Write($"{item}, ");
                }
            }
        }

        #endregion

        private static void DoProblem()
        {
            var stopWatch = Stopwatch.StartNew();

            const long VALUE = 600851475143;
            long[] factors = new long[2];
            long largestFactor = 0;            
            
            for (long i = 2; i * i < VALUE; i++)
            {
                if (VALUE % i == 0)
                {
                    // Since we are only looking at value up to the SQRT of VALUE, there is a corresponding factor above the SQRT of VALUE
                    // Find which one is the larger factor and if prime, update the largest factor variable.
                    factors[0] = i;
                    factors[1] = VALUE / i;
            
                    for (int j = 0; j < factors.Length; j++)
                    {
                        var isPrime = true;
            
                        for (long k = 2; k * k < factors[j]; k++)
                        {
                            if (factors[j] % k == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
            
                        if (isPrime && factors[j] > largestFactor)
                        {
                            largestFactor = factors[j];
                        }
                    }                    
                }
            }

            Console.WriteLine($"Execution took {stopWatch.ElapsedMilliseconds / 1000D} seconds");

            Console.WriteLine($"Largest prime frime factor of {VALUE} is: {largestFactor}");
        }
    }
}
