using System;

namespace MaxNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number;
            Console.Write("Это программа для определения большего из двух чисел\nПожалуйста введите первое число:");
            input = Console.ReadLine();
            number = Convert.ToInt32(input);
            Console.Write("Введите второе число:\t\t");
            input = Console.ReadLine();
            if (number < Convert.ToInt32(input))
                number = Convert.ToInt32(input);
            Console.WriteLine($"Большее число:\t\t\t{number}");
            Console.ReadLine();
        }
    }
}