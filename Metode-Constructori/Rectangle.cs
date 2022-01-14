using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_Constructori
{
    public class Rectangle
    {
        public Point A { get; set; } = new Point(0, 0);
        public Point B { get; set; } = new Point(0,0);

        public Point C { get; set; } = new Point(0, 0);
        public Point D { get; set; } = new Point(0, 0);
        public int Lungime { get; set; } = 0;
        public int Latime { get; set; } = 0;

        public Rectangle(Point A, int Lungime, int Latime)
            {
            this.A = A;
            this.Lungime = Lungime;
            this.Latime = Latime;
            B.X = A.X + Latime;
            B.Y = A.Y;
            C.X = A.X + Latime;
            C.Y = A.Y + Lungime;
            D.X = A.X;
            D.Y = A.Y + Lungime;
        }
        public Rectangle(Point A, Point C)
        {
            this.A = A;
            this.C = C;
            B.X = C.X;
            B.Y = A.Y;
            D.X = A.X;
            D.Y = C.Y;
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
