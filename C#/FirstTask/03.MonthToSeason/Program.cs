using System;

namespace MonthToSeason
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number;
            Console.Write("Я очень умный, зная только номер месяца, я могу определить какое это время года.\nДавай проверим?\nЗагадай мне номер месяца, давай, смелее:\t");
            input = Console.ReadLine();
            int.TryParse(input, out number);
            switch(number)
            {
                case 1:
                case 11:
                case 12:                    
                    Console.WriteLine("Зима");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Весна");
                    break;
                case 5:
                case 6:
                case 7:
                    Console.WriteLine("Лето");
                    break;
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("Осень");
                    break;
                default:
                    Console.WriteLine("На этой планете такого месяца нет");
                    break;
            }
            Console.ReadLine();
        }
    }
}
