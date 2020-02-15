using System;

namespace _02.Calculator
{
    class Program
    {
        delegate int Operation(int x, int y);
        static void Main(string[] args)
        {
            Operation Add = (x, y) => x + y;
            Operation Sub = (x, y) => x - y;
            Operation Mul = (x, y) => x * y;
            Operation Div = (x, y) =>
            {
                if (y == 0)
                    return x / y;
                Console.WriteLine("Нувозможно поделить на ноль");
                return x;
            };
            int x, y;
            Console.Write("Введите первое число: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Выберите операцию (+|-|*|/): ");
            switch (Console.ReadLine())
            {
                case "+":
                    Add(x, y);
                    break;
                case "-":
                    Sub(x, y);
                    break;
                case "*":
                    Mul(x, y);
                    break;
                case "/":
                    Div(x, y);
                    break;
                default:
                    Console.Write("Данная операция невозможна ");
                    break;
            }
        }
    }
}
