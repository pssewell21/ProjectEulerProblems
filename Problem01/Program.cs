using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            DoSampleProblem();

            DoProblem();

            Console.Read();
        }

        private static void DoSampleProblem()
        {
            const int MAX_VALUE = 10;

            var sum = 0;

            var value = 3;

            while (value < MAX_VALUE)
            {
                sum += value;

                value += 3;
            }

            value = 5;

            while (value < MAX_VALUE)
            {
                sum += value;

                value += 5;
            }

            Console.WriteLine($"Sum of multiples of 3 and 5 below {MAX_VALUE} = {sum}");
        }

        private static void DoProblem()
        {
            const int MAX_VALUE = 1000;

            var sum = 0;

            for (int i = 0; i < MAX_VALUE; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine($"Sum of multiples of 3 and 5 below {MAX_VALUE} = {sum}");
        }
    }
}
