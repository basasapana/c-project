/* Generate prime number between 1 and the input provided by the user */
using System;

namespace primeNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            bool isPrime = true;
            for (i = 2; i < 100; i++)
            {
                for (j = 2; j < i/2; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
                isPrime = true;
            }
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
