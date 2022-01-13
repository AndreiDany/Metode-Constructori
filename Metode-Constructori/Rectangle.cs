using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_Constructori
{
    public class Rectangle
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public Point D { get; set; }
        public int Lungime { get; set; }
        public int Latime { get; set; }

        public Rectangle(Point A, int Lungime, int Latime)
            {
            this.A = A;
            this.Lungime = Lungime;
            this.Latime = Latime;
            this.B.X = this.A.X + Latime;
            this.B.Y = this.A.Y;
            this.C.X = this.A.X + Latime;
            this.C.Y = this.A.Y + Lungime;
            this.D.X = this.A.X;
            this.D.Y = this.A.Y + Lungime;
        }
        public Rectangle(Point A, Point C)
        {
            this.A = A;
            this.C = C;
            this.B.X = this.C.X;
            this.B.Y = this.A.Y;
            this.D.X = this.A.X;
            this.D.Y = this.D.Y;
        }
        public void Print()
        {
            Console.WriteLine("A " + this.A.X + " " + this.A.Y);
            Console.WriteLine("B " + this.B.X + " " + this.B.Y);
            Console.WriteLine("C " + this.C.X + " " + this.C.Y);
            Console.WriteLine("D " + this.D.X + " " + this.D.Y);
        }
        public void Move(int dx, int dy)
        {
            this.A.X = this.A.X + dx;
            this.B.X = this.B.X + dx;
            this.C.X = this.C.X + dx;
            this.D.X = this.D.X + dx;
            this.A.Y = this.A.Y + dy;
            this.B.Y = this.B.Y + dy;
            this.C.Y = this.C.Y + dy;
            this.D.Y = this.D.Y + dy;
        }

    }
}
