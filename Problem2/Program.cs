using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            DoProblem();

            Console.Read();
        }

        private static void DoProblem()
        {
            const int MAX_VALUE = 4000000;

            int sum = 0;

            var term1 = 1;
            var term2 = 2;
            int next;

            sum += term2;

            while (term1 + term2 < MAX_VALUE)
            {
                next = term1 + term2;

                if (next % 2 == 0)
                {
                    sum += next;
                }

                term1 = term2;
                term2 = next;

                Console.WriteLine($"Next = {next}");
            }

            Console.WriteLine($"Sum of fibonacci numbers below {MAX_VALUE} = {sum}");
        }
    }
}
