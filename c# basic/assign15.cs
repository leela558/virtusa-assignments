using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class assign15
    {
        public static void Main()
        {
            int size;
            int[] arr;
            Console.Write("Enter size of the array: ");
            size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter {0} elements in array:", size);

            arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Number({0}) :", i + 1);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int total = 0;
            int avg = 0;
            for (int i = 0; i < size; i++)
            {
                total = total + arr[i];
            }
            avg = total / 10;
            Console.WriteLine(total);
            Console.WriteLine(avg);
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Max());
        }
    }
}
