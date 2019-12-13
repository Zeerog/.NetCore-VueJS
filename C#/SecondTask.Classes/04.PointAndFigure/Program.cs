using System;

namespace _04.PointAndFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(10, 10, "A");
            Point B = new Point(10, -10, "B");
            Point C = new Point(-10, -10, "C");
            Point D = new Point(-10, 10, "D");
            Figure Cube = new Figure(A, B, C, D);
            Console.WriteLine(Cube.name);
            Cube.PerimeterCalculator();

            Console.ReadLine();
        }
    }
    class Point
    {
        double x, y;
        string name;
        public Point(double x, double y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
        public double X
        {
            get
            {
                return x;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }

    }
    class Figure
    {
        double perimeter;
        public readonly string name;
        public Figure(Point A, Point B, Point C)
        {
            perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(A, C);
            name = "Треугольник";
        }
        public Figure(Point A, Point B, Point C, Point D)
        {
            perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(A, D);
            name = "Четырехугольник";
        }
        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            perimeter = LengthSide(A, B) + LengthSide(B, C) + LengthSide(C, D) + LengthSide(D, E) + LengthSide(A, E);
            name = "Пятиугольник";
        }
        double LengthSide(Point A, Point B)
        {
            return Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
        }
        public void PerimeterCalculator()
        {
            Console.WriteLine(perimeter);
        }
    }
}
