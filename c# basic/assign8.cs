using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class assign8
    {
            public static void Main()
            {
                Console.Write("enter a number:");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("squares");
                for (int i = 1; i <= a; i++)
                {
                    Console.WriteLine(i * i);
                }
                Console.ReadLine();
            }
        }
    }
