using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraySort
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, num;
            int[] arr = new int[10];
            for (i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());         // insert the data in the array
            }
            for (j = 0; j < 10; j++)
            {
                Console.WriteLine("arr[{0}]={1}",j,arr[j]);
            }
            Array array = arr;            // sorting in the c#
            Array.Sort(arr);
            for (int z = 0; z < 10; z++)
            {
                Console.WriteLine("arr[{0}]={1}",z,arr[z]);
            }
            int search = 44;
            int f = Array.Find(arr,search);

        }
    }
}
