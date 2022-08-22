using System;
  
class str{
      
static int countOccurrencesOfIs(string str)
{
      
    // Split the string by spaces
    string[] a = str.Split(' ');
    string word = "DotNet";
      
    // Search for "is" in string
    int count = 0;
    for(int i = 0; i < a.Length; i++)
    {    
          

        if (word.Equals(a[i]))
            count++;
    }
    return count;
}
  

public static void Main()
{
    string str ="DotNet is technology and DotNet is interoperable and DotNet is simple";
    Console.Write(countOccurrencesOfIs(str));
}
}