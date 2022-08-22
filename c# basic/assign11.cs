using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class assign11
    {
 
            public static void Main()
            {
                Console.Write("enter a number:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(a + " table:");
                for (int i = 0; i <= 20; i++)
                {
                    Console.WriteLine(a + "*" + i + "=" + a * i);
                }
                Console.ReadLine();
            }
        }
    }
