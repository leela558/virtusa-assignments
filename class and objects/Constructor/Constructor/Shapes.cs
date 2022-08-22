using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Shapes
    {
        public int Area(double pi,int r)
        {
            int area =(int) pi * r * r;
            return area;
        }
        public int Area(int h,int b)
        {
            double temp = 0.5;
            int area =(h*b)/2;
            return area;
        }
        public int Area(int s)
        {
            int area = s*s;
            return area;
        }

    }
}
