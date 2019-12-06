using System;

namespace MonthToSeason
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number;
            Console.Write("Я тоже хочу быть полезным, давай я напомню тебе имя дня недели по его номеру.\nКакой день тебя интересует?\t");
            input = Console.ReadLine();
            int.TryParse(input, out number);
            switch (number)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Какая-то странная у тебя неделя. Ты уверен в том что спрашиваешь");
                    break;
            }
            Console.ReadLine();
        }
    }
}
