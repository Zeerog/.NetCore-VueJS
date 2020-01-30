using System;

namespace MonthToSeason
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number;
            Console.WriteLine("Я очень глупый, я знаю только два числа: хорошая единица и плохой ноль. Назовешь мне одно из них?");
            input = Console.ReadLine();
            int.TryParse(input, out number);
            switch (number)
            {
                case 0:
                    Console.WriteLine("Плохо");
                    break;
                case 1:
                    Console.WriteLine("Хорошо");
                    break;
                default:
                    Console.WriteLine("Ты же понимаешь что я не знаю такого -_-");
                    break;
            }
            Console.ReadLine();
        }
    }
}