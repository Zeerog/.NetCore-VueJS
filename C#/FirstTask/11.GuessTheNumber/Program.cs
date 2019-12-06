using System;

namespace _11.GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int win = 0, counter = 0, min_counter = 0, my_number, number;
            Random rnd = new Random();
            for (; ; )
            {
                my_number = rnd.Next(1, 146);
                Console.WriteLine("Я загадал число от 1 до 146, попробуй его отгадать.\n" +
                    "Если тебе надоело, просто введи 0.\n" +
                    $"Побед:\t{win}\n" +
                    $"Самая быстрая победа:\t{min_counter}\n");

                for (; ; )
                {
                    Console.Write("Угадай число: ");
                    int.TryParse(Console.ReadLine(), out number);
                    counter++;
                    if (number == 0)
                        Environment.Exit(0);
                    else if (number == my_number)
                    {
                        Console.WriteLine("Поздравляю, у тебя получилось");
                        break;
                    }
                    else if (number > my_number)
                        Console.WriteLine("Мое число меньше");
                    else
                        Console.WriteLine("Мое число больше");
                }
                if (counter < min_counter ||min_counter==0)
                    min_counter = counter;
                win++;
                System.Threading.Thread.Sleep(2000);
                Console.Clear();
            }
        }
    }
}
