using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_Constructori
{
     public class Triangle
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }

        public Triangle (Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public void Print()
        {
            Console.WriteLine("A " + this.A.X + " " + this.A.Y);
            Console.WriteLine("B " + this.B.X + " " + this.B.Y);
            Console.WriteLine("C " + this.C.X + " " + this.C.Y);
        }
        public void Move(int dx, int dy)
        {
            this.A.X = this.A.X + dx;
            this.B.X = this.B.X + dx;
            this.C.X = this.C.X + dx;
            this.A.Y = this.A.Y + dy;
            this.B.Y = this.B.Y + dy;
            this.C.Y = this.C.Y + dy;
        }

    }
}
