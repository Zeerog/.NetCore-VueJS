using System;

namespace _04.BirthDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int day= 1, month = 1;
            int year = DateTime.Now.Year;
            Console.Write("Когда ваш день рождения?\nЧисло: ");
            day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Номер месяца: ");
            month = Convert.ToInt32(Console.ReadLine());

            DateTime d = new DateTime(year, month, day); // сюда выбранную дату
            if ((d - DateTime.Now).Days < 0)
                d = d.AddYears(1);
            Console.WriteLine((d - DateTime.Now).Days);
        }
    }
}
