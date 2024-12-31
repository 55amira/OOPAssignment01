using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Point
    {

        public int X;
        public int Y;

        //CLR Crate 
        //Constructor
        //public Point()
        // {
        // }

        //    public Point ()
        //    {
        //        X = 8;
        //        Y = 8;
        //    }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Print()
        {
            Console.WriteLine($"({X},{Y})");
        }
    }
}
