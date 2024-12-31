using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign01
{
    internal struct Point
    {
        public int X;   
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int Distance()
        { 
           return X - Y;
        }
    }
}
