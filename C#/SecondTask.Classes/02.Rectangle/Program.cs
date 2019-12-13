using System;

namespace _02.Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1, side2;
            Console.Write("Please, enter side1: ");
            double.TryParse(Console.ReadLine(), out side1);
            Console.Write("Please, enter side2: ");
            double.TryParse(Console.ReadLine(), out side2);
            Rectangle Rect = new Rectangle(side1, side2);
            Console.WriteLine("Area = " + Rect.Area);
            Console.WriteLine("Perimetr = " + Rect.Perimetr);
            Console.ReadLine();
        }
    }
    class Rectangle
    {
        double side1, side2;
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        double AreaCalculator()
        {
            return side1 * side2;
        }
        double PerimetrCalculator()
        {
            return (side1 + side2) * 2;
        }
        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }
        public double Perimetr
        {
            get
            {
                return PerimetrCalculator();
            }
        }
    }
}
