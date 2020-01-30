using System;

namespace _10.MultiplicationTableAndDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, digits=0;
            Console.WriteLine("Таблица умножения");
            Console.Write("Введите число: ");
            int.TryParse(Console.ReadLine(), out number);
            for(int i=1;i<=20;i++)
            {
                Console.WriteLine(number+"*"+i+"="+number*i);
            }
            Console.WriteLine();
            Console.WriteLine("Определение количества разрядов числа");
            Console.Write("Введите число: ");
            int.TryParse(Console.ReadLine(), out number);
            for (;;)
            {
                if (number % 10 == 0)
                    break;
                number /= 10;
                digits++;
            }
            Console.WriteLine($"Разрядов в этом числе - {digits}");
            Console.ReadLine();
        }
    }
}
