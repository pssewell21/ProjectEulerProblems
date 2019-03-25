using System;
using System.Diagnostics;

namespace Problem9
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

            const int sumOfValues = 12;
            var breakOut = false;

            for (int a = 1; a < sumOfValues; a++)
            {
                for (int b = a; b < sumOfValues; b++)
                {
                    for (int c = b; c < sumOfValues; c++)
                    {
                        if (a + b + c == sumOfValues)
                        {
                            int leftValue = (a * a) + (b * b);
                            int rightValue = c * c;

                            if (leftValue == rightValue)
                            {
                                Console.WriteLine($"Pythagorean triple found : {a}, {b}, {c}, Product = {a * b * c}");
                                breakOut = true;
                            }
                            else
                            {
                                Console.WriteLine($"{a}, {b}, {c} is not a Pythagorean triple");
                            }
                        }
                        else
                        {
                            //Console.WriteLine($"{a}, {b}, {c} do not add up to {sumOfValues}");
                        }

                        if (breakOut)
                        {
                            break;
                        }
                    }

                    if (breakOut)
                    {
                        break;
                    }
                }

                if (breakOut)
                {
                    break;
                }
            }

            Console.WriteLine($"Execution took {stopWatch.ElapsedMilliseconds / 1000D} seconds");
        }

        #endregion

        private static void DoProblem()
        {
            var stopWatch = Stopwatch.StartNew();

            const int sumOfValues = 1000;
            var breakOut = false;

            for (int a = 1; a < sumOfValues; a++)
            {
                for (int b = a; b < sumOfValues; b++)
                {
                    for (int c = b; c < sumOfValues; c++)
                    {
                        if (a + b + c == sumOfValues)
                        {
                            int leftValue = (a * a) + (b * b);
                            int rightValue = c * c;

                            if (leftValue == rightValue)
                            {
                                Console.WriteLine($"Pythagorean triple found : {a}, {b}, {c}, Product = {a * b * c}");
                                breakOut = true;
                            }
                        }

                        if (breakOut)
                        {
                            break;
                        }
                    }

                    if (breakOut)
                    {
                        break;
                    }
                }

                if (breakOut)
                {
                    break;
                }
            }

            Console.WriteLine($"Execution took {stopWatch.ElapsedMilliseconds / 1000D} seconds");
        }
    }
}
