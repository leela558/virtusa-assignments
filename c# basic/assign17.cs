using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class assign17
    {
        public static void Main()
        {
            int i;
            string a = Console.ReadLine();
            string b = "";
            for (i = a.Length - 1; i >= 0; i--)
            {
                b = b + a[i];
            }
            Console.WriteLine(b);

        }
    }
}
