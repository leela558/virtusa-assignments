using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class assign4
    {
        public static void Main()
        {
            Console.WriteLine("enter number1");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine("even");
                }
                else
                {
                    Console.Write("odd");
                }
            }
            Console.ReadKey();
        }

    }
}
