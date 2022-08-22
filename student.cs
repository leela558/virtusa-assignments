using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsAssignment
{
    class StudentRepository
    {
        private Student[] student = new Student[5];
        int i = 0;
        public void AddStud(Student stud)
        {
            if (i <= student.Length)
            {
                student[i] = stud;
                i++;
            }
        }
        public Student getbyRollno(int RollNo)
        {
            foreach (Student s in student)
            {
                if (s != null)
                {
                    if (s.RollNo == RollNo)
                    {
                        return s;
                    }
                }
            }
            return null;
        }
    }
    class Test_Student
    {
        static void Main()
        {
            StudentRepository Repository = new StudentRepository();
            do
            {
                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.Total Marks and Percentage");
                Console.WriteLine("3.Exit App");
                Console.WriteLine("Enter your Choice");
                int ch = int.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        {
                            Student stud = new Student();
                            Console.WriteLine("Enter Roll_no:");
                            stud.RollNo=int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Name:");
                            stud.StudName = Console.ReadLine();
                            Console.WriteLine("Enter Marks in Eng:");
                            stud.Eng= int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Marks in Maths");
                            stud.Maths= int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Marks in Science");
                            stud.Science=int.Parse(Console.ReadLine());
                            Repository.AddStud(stud);
                        }
                        break;
                    case 2:
                        {
                            int sum = 0;
                            double Per = 0.0D;
                            Console.WriteLine("Enter Roll No");
                            int RollNo=int.Parse(Console.ReadLine());
                            Student stud = Repository.getbyRollno(RollNo);
                            if(stud!=null)
                            {
                                sum = stud.Eng + stud.Science + stud.Maths;
                                Per = (sum / 3);
                                Console.WriteLine($"RollNo:{RollNo} Total Marks:{sum} Percentage:{Per}");
                            }

                        }
                        break;
                    case 3:
                        {
                            Environment.Exit(0);
                        }
                        break;
                }
            }while(true);
        }
    }
}
