using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopsAssinment
{
    internal class matrix
    {
        public static void Main()
        {
            int i = 0, j = 0;
            int[,] m = new int [3,3];
            Console.WriteLine("Enter row and coloumn");
            int n = int.Parse(Console.ReadLine());
            int m1 = int.Parse(Console.ReadLine());
            Console.Write("Input elements in the matrix");
            for (i = 0; i <n;i++)
            {
                for(j=0;j<m1;j++)
                {
                    Console.WriteLine("[{0},{1}",i, j);
                    m[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (i = 0; i < n; i++)
            {
                Console.Write("\n");
                for (j = 0; j < m1; j++)
                {
                    Console.Write("{0}\t", m[i, j]);
                }
            }
            Console.Write("\n\n");
        }
    }
}
