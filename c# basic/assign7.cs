using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class assign7
    {
        public static void Main()
        {
            int i = 0, quantity = 0;
            double t1 = 0D, t2 = 0D, t3 = 0D;
            Console.WriteLine("enter the product number");
            i = Convert.ToInt32(Console.ReadLine());
            while(i<=3)
            {
                switch(i)
                {
                    case 1:
                        Console.WriteLine("Enter the product quality");
                        t1 = quantity * 22.5;
                        break;
                    case 2:
                        Console.WriteLine("Enter the product quality");
                        t2 = quantity * 44.5;
                        break;
                    case 3:
                        Console.WriteLine("Enter the product quality");
                        t3 = quantity * 9.98;
                        break;

                }
                i++;
            }
           
            double total = t1 + t2 + t3;
                Console.WriteLine(total);
                Console.ReadKey();
            }
        }
    }