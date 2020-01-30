using System;

namespace _7.PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Давай ты напишешь число, а я определю, такое ли оно простое как ты думаешь.\nВведи число:");
            int.TryParse(Console.ReadLine(), out number);
            if (isPrime(number)==true)
                Console.Write("Это простое число");
            else
                Console.Write("Это не простое число");
            Console.ReadLine();
        }
        static bool isPrime(int number)
        {
            if (number % 2 == 0)
                return number == 2;
            int d = 3;
            while (d * d <= number && number % d != 0)
            d += 2;
            return d * d > number;
        }
    }
}
