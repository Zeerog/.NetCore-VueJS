using System;

namespace _13.AverageOfFive
{
    class Program
    {
        static void Main(string[] args)
        {
            float sum = 0, number;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Введите число {i}: ");
                float.TryParse(Console.ReadLine(), out number);
                sum += number;
            }
            Console.Write($"Среднее значение: {sum/5}");
            Console.ReadLine();
        }
    }
}
