using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_Constructori
{
    public static class GeometryUtils
    {
        public static void Point(Point[] points, int dx, int dy)
        {
            for (int i = 0; i < points.Length; i++)
            {
                points[i].Move(dx, dy); 
            }
        }
        public static void Move(Triangle triunghi, int dx, int dy)
        {
            triunghi.A.X = triunghi.A.X + dx;
            triunghi.B.X = triunghi.B.X + dx;
            triunghi.C.X = triunghi.C.X + dx;
            triunghi.A.Y = triunghi.A.Y + dy;
            triunghi.B.Y = triunghi.B.Y + dy;
            triunghi.C.Y = triunghi.C.Y + dy;
        }
        public static void Move(Rectangle dreptunghi, int dx, int dy)
        {
            dreptunghi.A.X = dreptunghi.A.X + dx;
            dreptunghi.B.X = dreptunghi.B.X + dx;
            dreptunghi.C.X = dreptunghi.C.X + dx;
            dreptunghi.D.X = dreptunghi.D.X + dx;
            dreptunghi.A.Y = dreptunghi.A.Y + dy;
            dreptunghi.B.Y = dreptunghi.B.Y + dy;
            dreptunghi.C.Y = dreptunghi.C.Y + dy;
            dreptunghi.D.Y = dreptunghi.D.Y + dy;
        }
        public static void Print(Point[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine($"X[{i}]=" + points[i].X);
                Console.WriteLine($"Y[{i}]=" + points[i].Y);
            }
        }
        public static void Print(Triangle triunghi)
        {
            Console.WriteLine("A " + triunghi.A.X + " " + triunghi.A.Y);
            Console.WriteLine("B " + triunghi.B.X + " " + triunghi.B.Y);
            Console.WriteLine("C " + triunghi.C.X + " " + triunghi.C.Y);
        }
        public static void Print(Rectangle dreptunghi)
        {
            Console.WriteLine("A " + dreptunghi.A.X + " " + dreptunghi.A.Y);
            Console.WriteLine("B " + dreptunghi.B.X + " " + dreptunghi.B.Y);
            Console.WriteLine("C " + dreptunghi.C.X + " " + dreptunghi.C.Y);
            Console.WriteLine("D " + dreptunghi.D.X + " " + dreptunghi.D.Y);
        }
    }
}
