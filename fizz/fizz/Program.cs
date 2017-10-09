using System;

namespace fizz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 100; i++) {
                string result = "";
                if (i % 3 == 0) result = "fizz";
                if (i % 5 == 0) result = result + "buzz";

                Console.WriteLine(result);
                if (result.Length == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
