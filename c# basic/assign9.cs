using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class assign9
    {
        
            public static void Main()
            {
                Console.Write("enter a number:");
                int a = Convert.ToInt32(Console.ReadLine());
                int f = 1;
                Console.Write("factorial of the given number:");
                for (int i = 1; i <= a; i++)
                {
                    f = f * i;
                }
                Console.WriteLine(f);
                Console.ReadLine();
            }
        }
    }

