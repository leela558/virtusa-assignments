using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsAssignment
{
    class Temperature
    {
        public double[] weekTemp;
        public double bTemp;
        public double[] WeekTemp
        {
            get { return weekTemp; }
            set { weekTemp = value; }
        }
        public double BTemp
        {
            get { return bTemp; }
            set { bTemp = value; }
        }
        public double Avg_Temp
        {
            get {return avg_Temp(); }
        }
        public double Max_Temp
        {
            get { return max_Temp(); }
        }
        public double Min_Temp
        {
            get { return min_Temp(); }
        }
        public double Avg_Ex_Temp
        {
            get { return avg_Ex_Temp(); }
        }
        public double NoBtemp
        {
            get { return noBtemp(); }
        }
        public Temperature(double[] weekTemp, double bTemp)
        {
            this.weekTemp = weekTemp;
            this.bTemp = bTemp;
        }
        public override string ToString()
        {
            StringBuilder os = new StringBuilder();
            os.AppendLine("========================");
            os.AppendLine("Average Temp:"+Avg_Temp.ToString());
            os.AppendLine("Maximun Temp:"+Max_Temp.ToString());
            os.AppendLine("Minimum Temp:" + Min_Temp.ToString());
            os.AppendLine("Average Temp Excluding Lower Temp:"+Avg_Ex_Temp.ToString());
            os.AppendLine("No of Temps Below Temp:"+NoBtemp.ToString());
            return os.ToString();
        }
        public double avg_Temp()
        {
            return weekTemp.Average();
        }
        public double max_Temp()
        {
            return weekTemp.Max();
        }
        public double min_Temp()
        {
            return weekTemp.Min();
        }
        public double avg_Ex_Temp()
        {
            return (weekTemp.Sum() - Min_Temp)/NoBtemp;
        }
        public double noBtemp()
        {
            var r = from t in weekTemp
                    where t>Min_Temp
                    select t;
            return r.Count();
            
        }
    }
    class Test_Temperature
    {
        public static void Main()
        {
            do
            {
                double[] week = new double[7];    //array to track user temperature imputs
                string[] days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" }; //array to track days of week
                for (int x = 0; x < 7; x++) //loop to gather the temperaures for the week
                {
                    Console.Write("Temperature on " + days[x] + "?: ");
                    string UserTemp = Console.ReadLine();
                    week[x] = double.Parse(UserTemp);
                }
                Console.Write("Below Temp:");
                double BelowTemp = double.Parse(Console.ReadLine());
                Temperature Week = new Temperature(week, BelowTemp);
                Console.WriteLine(Week.ToString());
                Console.WriteLine("Enter 1 for Exit\nEnter any any number for coutinue");
                int k=int.Parse(Console.ReadLine());
                if (k == 1)
                {
                    Environment.Exit(0);
                }
            }while(true);
        }
    }
}
