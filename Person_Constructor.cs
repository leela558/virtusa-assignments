using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsAssignment
{
    class Person_Constructor
    {
        /*First name , Last name , Email 
First name , Last name , Date of birth*/
        public string First_name;
        public string Last_name;
        public string email;
        public DateTime Dateofbirth;
        public Person_Constructor(string First_name,string Last_name,string email)
        {
            this.First_name= First_name;
            this.Last_name= Last_name;
            this.email= email;
        }
        public Person_Constructor(string First_name, string Last_name, string Dateofbirth,string email)
        {
            this.First_name = First_name;
            this.Last_name = Last_name;
            this.Dateofbirth = Convert.ToDateTime(Dateofbirth);
            this .email = email;    
        }
        public void show()
        {
            Console.WriteLine($"First_name Last_name:{First_name}"+$"{Last_name} email:{email}");
            
        }
        public void show1()
        {
            Console.WriteLine($"First_name Last_name:{First_name}" + $"{Last_name} Dateofbirth:{Dateofbirth} email:{email}");
        }
        
    }
    class Constructor
    {
        static void Main() 
        {
            Person_Constructor p1 = new Person_Constructor("ktv", "shyam", "ktvshyam@gmail.com");
            p1.show();
            Person_Constructor p2 = new Person_Constructor("ktv", "shyam","28/10/2000","ktvshyam@gmail.com");
            p2.show1();
        }
    }
}
