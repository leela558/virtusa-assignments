using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Strings
    {
        public static void Main()
        {
            string s1 = "The quick brown fox jumps over the lazy dog";
            string s4 = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";
            string s2 = "and killed it";
            Console.Write(s1[12]);
            if(s1.Contains("is")==true)
            {
                Console.WriteLine("Word Found");
            }
            else
            {
                Console.WriteLine("not");
            }
            string s3 = s1 + s2;
            Console.Write(s3);
            Console.Write("\n");
            if(s1==s4)
            {
                Console.Write("equals");
            }
            else
            {
                Console.Write("not\n");
            }
            Console.Write(s1.Length);
            Console.Write("\n");
            Console.Write(s1.Replace("The", "A"));
            Console.Write("\n");
            /*string[] words = s1.spilt("brown fox");
            foreach(var word in words)
            {
                Console.WriteLine($"{words}");
            }*/
            Console.Write(s1.ToUpper());
            Console.Write(s1.ToLower());

        }
    }
}
