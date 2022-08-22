using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class assign10
    {       public static void Main()
            {
                Console.Write("enter a number:");
                int a = Convert.ToInt32(Console.ReadLine());
                int K = 0, l = 1, j = 0;
                Console.WriteLine("Fibonacci series:");
                Console.Write(K + " " + l + " ");
                for (int i = 2; i < a; i++)
                {
                    j = K + l;
                    Console.Write(j + " ");
                    K = l;
                    l = j;
                }
                Console.ReadLine();
            }
        }
    }
