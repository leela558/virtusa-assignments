using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsAssignment
{
    class Tour_Travel
    {
        public string CName;
        public int No_People;
        public string Pac_Category;
        public double Cost;
        public DateTime Tour_St_date;
        private Tour_Travel[] Tour= new Tour_Travel[220];
        int i = 0;
        public void AddCous(Tour_Travel tour)
        {
            if(i<Tour.Length)
            {
                Tour[i] = tour;
                i++;
            }
        }
        public Tour_Travel[] AllData1()
        {
            return Tour;
        }

    }
    class Test_Tour
    {
        static void Main()
        {
            Tour_Travel tour_Travel = new Tour_Travel();
            do
            {
                Console.WriteLine("1.New Coustomer");
                Console.WriteLine("2.All data");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Enter your Choice");
                int ch=int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Tour_Travel tour= new Tour_Travel();
                            string k;
                            string[] tours = { "Discover India","Holiday Hungama","Pilgrimage Package" };
                            Console.Write("Enter Customer Name:");
                            tour.CName=Console.ReadLine();
                            Console.Write("Enter no of people:");
                            tour.No_People = int.Parse(Console.ReadLine());
                            Console.Write("Tour start date:");
                            tour.Tour_St_date = DateTime.Parse(Console.ReadLine());
                            Console.WriteLine("=================================");
                            Console.WriteLine("1)Discover India:1000\n3)Holiday Hungama:1200\n4)Pilgrimage Package:1500");
                            Console.Write("Package Category:");
                            string c=Console.ReadLine();
                            foreach(var i in tours)
                            {
                                if (i==c)
                                {
                                    tour.Pac_Category=i;
                                }
                            }
                            
                            Console.WriteLine("----------------------------------");
                            Console.WriteLine("press 2:Confirm to Payment");
                            int l=int.Parse(Console.ReadLine());
                            Console.Write("Enter Amount:");
                            int s=int.Parse(Console.ReadLine());
                            if(l==2)
                            {
                                tour.Cost = s;
                            }
                            tour_Travel.AddCous(tour);
                            Console.WriteLine("===================================");
                        }
                        break;
                    case 2:
                        {
                            Tour_Travel[] Tour = tour_Travel.AllData1();
                            foreach (Tour_Travel t in Tour)
                                if (t != null)
                                {
                                    {
                                        Console.WriteLine($"Customer Name:{t.CName}\nNo of People:{t.No_People}\nTour Start Date:{t.Tour_St_date}\nPackage Category:{t.Pac_Category}\nCost:{t.Cost}");
                                    }
                                }
                        }
                        break;
                    case 3:
                        {
                            Environment.Exit(0);
                        }
                        break;
                }
            }while (true);
        }
    }
}
