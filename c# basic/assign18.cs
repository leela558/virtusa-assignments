using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class assign18
    { 
            public static void Main()
            {
            string a = "", b = "";
                Console.Write("Enter any two words:");
                a = Console.ReadLine();
                b = Console.ReadLine();
                if (a == b)
                {
                    Console.WriteLine("same Words");
                }
                else
                {
                    Console.WriteLine("not same words");
                }
                Console.ReadLine();
            }
        }
    }
