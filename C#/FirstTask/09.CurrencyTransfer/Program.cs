using System;

namespace _9.CurrencyTransfer
{
    class Program
    {
        static void Main(string[] args)
        {
            float number;
            int a;
            Console.Write("Скучный конвертор валют.\n" +
                "Введите сумму:\t");
            float.TryParse(Console.ReadLine(), out number);
            Console.Write("1-UAH\n" +
                "2-EUR\n" +
                "3-USD\n" +
                "Выберите валюту: ");
            int.TryParse(Console.ReadLine(), out a);
            switch (a)
            {
                case 1:
                    Console.WriteLine($"EUR - {number* 0.038}\nUSD - {number* 0.042}");
                    break;
                case 2:
                    Console.WriteLine($"UAH - {number* 26.46}\nUSD - {number* 1.11}");
                    break;
                case 3:
                    Console.WriteLine($"UAH - {number* 23.82}\nEUR - {number* 0.90}");
                    break;
                default:
                    Console.WriteLine("Вы где-то ошиблись");
                    break;

            }
            Console.ReadLine();
        }
    }
}
