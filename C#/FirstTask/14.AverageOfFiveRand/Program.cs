using System;

namespace _13.AverageOfFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            float sum = 0, number;
            for (int i = 1; i <= 5; i++)
            {
                number = rnd.Next(0,100);
                Console.WriteLine($"Число {i}: {number}");
                sum += number;
            }
            Console.Write($"Среднее значение: {sum / 5}");
            Console.ReadLine();
        }
    }
}
