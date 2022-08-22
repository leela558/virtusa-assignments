using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsAssignment
{
    class OnlineBooking
    {
        private int isbn;
        private string bookname;
        private string booktitle;
        private string bookauthor;
        private int stock;
        private double bookprice;
        private int bookno;
       
        public int BookNo { get => bookno;set => bookno = value; }
        public int Isbn { get=>isbn; set => isbn = value; }
        public string Bookname { get => bookname;set=>bookname = value;}
        public string Booktitle { get => booktitle;set=>booktitle = value;}
        public int Stock { get => stock;set=>stock = value;}
        public double Bookprice { get => bookprice;set=>bookprice = value;}
        public string Bookauthor { get => bookauthor;set=>bookauthor = value;}
        
        public void Details()
        {
            Console.WriteLine($@"BookNo:{bookno}|Isbn:{isbn} |Bookname:{bookname} |Booktitle:{booktitle} |Bookauthor:{bookauthor} |Stock:{stock} |Bookprice:{bookprice}");
        }
    }

    class Test_OnlineBooking
    {
        public double k;
        
        static void Main(string[] args)
        {
            do
            {
                OnlineBooking[] b = new OnlineBooking[10];
                b[0] = new OnlineBooking();
                b[0].BookNo = 1;
                b[0].Isbn = 2123340236;
                b[0].Bookname = "Machines";
                b[0].Booktitle = "Bhimra";
                b[0].Stock = 10;
                b[0].Bookprice = 509;
                b[0].Details();
                b[1] = new OnlineBooking();
                b[1].BookNo = 2;
                b[1].Isbn = 2055678543;
                b[1].Bookname = "Control System";
                b[1].Booktitle = "Gopal";
                b[1].Stock = 5;
                b[1].Bookprice = 600;
                b[1].Details();
                b[2] = new OnlineBooking();
                b[2].BookNo = 3;
                b[2].Isbn = 45678932;
                b[2].Bookname = "Power System";
                b[2].Booktitle = "C.L.Wadhawa";
                b[2].Stock = 10;
                b[2].Bookprice = 550;
                b[2].Details();
                double k = 0;
                double s = 0;

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("press 4 for Exit:");
                    Console.WriteLine("choose ur book");
                    int ch = int.Parse(Console.ReadLine());
                    if (ch == 4)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        for (int i = 0; i < 3; i++)
                        {
                           
                            if (b[i].BookNo == ch)
                            {
                                Console.WriteLine("No of books required:");
                                int r = int.Parse(Console.ReadLine());
                                k = b[i].Bookprice * r;
                                Console.WriteLine("Total Price:{0}", k);

                            }
                        }
                        s = s + k;
                        Console.WriteLine("New Total Price:{0}:", s);
                    }
                }

            } while (true);    
        }
    }
}
