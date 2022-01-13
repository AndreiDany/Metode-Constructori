using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_Constructori
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public void Print()
        {
            Console.WriteLine("X=" + this.X);
            Console.WriteLine("Y=" + this.Y);
        }

        public void Move(int dx, int dy)
        {
            this.X = X+dx;
            this.Y = Y+dy;
        }
    }
}
