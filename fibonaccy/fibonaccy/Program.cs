using System;

namespace fibonaccy
{
    class Program
    {
        static void Main(string[] args)
        {
            int f1 = 0, f2 = 1, f3 = 0;
            Console.WriteLine("Please enter the number upto which you want to generate fibonacy series");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
            }
        }
    }
}
