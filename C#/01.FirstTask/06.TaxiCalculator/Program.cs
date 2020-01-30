using System;

namespace _6.TaxiCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number, price;
            Console.Write("Я помогу вам посчитать цену за проезд в зависимости от длинны поездки и времени простоя.\n" +
                "Наш тариф:\n" +
                "До  5км - 20грн, каждый следующий километр - 3грн.\n" +
                "Простой - 1грн/мин.\n" +
                "Введите длинну маршрута:\t\t");
            input=Console.ReadLine();
            int.TryParse(input, out number);
            if (number <= 5)
                price = 20;
            else
                price = 20 + (number - 5) * 3;
            Console.Write("Введите ожидаемую длинну простоя:\t");
            input = Console.ReadLine();
            int.TryParse(input, out number);
            price += number;
            Console.WriteLine($"Ожидаемая сумма к оплате:\t\t{price}");
            Console.ReadLine();
        }
    }
}
