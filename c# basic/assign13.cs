using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class assign13
    {
      
            public static void Main()
            {
                Console.Write("enter any three numbers:");
                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());
                int c = Convert.ToInt32(Console.ReadLine());
                if (a > b)
                {
                    if (a > c)
                    {
                        Console.WriteLine("a is bigger, that is: " + a);
                    }
                    else
                    {
                        Console.WriteLine("c is bigger, that is: " + c);
                    }
                }
                else if (b > c)
                    Console.WriteLine("b is bigger, that is: " + b);
                else
                {
                    Console.WriteLine("c is bigger, that is: " + c);
                }
                Console.ReadLine();
            }
        }
    }

