using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class assign3
    {
        public static void Main()
        {
            Console.WriteLine("enter number1");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number2");
            int b = int.Parse(Console.ReadLine());
            while (a <= b)
            {
                Console.WriteLine(a);
                a++;
            }
            Console.ReadKey();
        }
    }
}
