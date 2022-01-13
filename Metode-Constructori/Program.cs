using System;

namespace Metode_Constructori
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point (1, 5);
            Point p2 = new Point(5, 5);
            Point p3 = new Point(5, 2);
            Point p4 = new Point(1, 2);
            Triangle triunghi = new Triangle ( p1, p2, p3 );
            triunghi.Print();
            triunghi.Move(0, -1);
            triunghi.Print();
            //Rectangle dreptunghi = new Rectangle(p1, p3);
            //dreptunghi.Move(1, 1);
            //dreptunghi.Print();
            GeometryUtils.Print(triunghi);
            GeometryUtils.Print(new Point[] {p1, p2, p3 });
        }
    }
}
