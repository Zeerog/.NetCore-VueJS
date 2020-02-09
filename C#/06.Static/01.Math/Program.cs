using System;

namespace _01.Math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    static class Math
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static double Sub(double x, double y)
        {
            return x - y;
        }
        public static double Mult(double x, double y)
        {
            return x * y;
        }
        public static double Div(double x, double y)
        {
            return x / y;
        }
        public static double Pow(double x, int y)
        {
            double res = x;
            for(int i = 0; i < y; i++)
            {
                res *= x;
            }
            return res;
        }
        public static double Sqrt(double x)
        {
            double res = x / 2;
            for (int i = 0; i < 100; i++) 
                res = (res + x / res) / 2d;
            return res;
        }
        //Можно продолжать и дальше, при наличии желания, времени и фантазии
    }
}
