using System;
using System.Collections;

namespace _02.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[8];
            Console.Write("Ввод: 1 - ручной, 2 - автоматический: ");
            if (Console.ReadLine() == "1")
            {
                for (int i = 0; i < 8; i++)
                {
                    Console.Write(i + 1 +": Номер поезда: ");
                    trains[i].number = Convert.ToInt32(Console.ReadLine());
                    Console.Write(i + 1 + ": Пункт назначения: ");
                    trains[i].destination = Console.ReadLine();
                    Console.Write(i + 1 + ": Время прибытие - часов: ");
                    trains[i].hour = Convert.ToInt32(Console.ReadLine());
                    Console.Write(i + 1 + ": Минут: ");
                    trains[i].minute = Convert.ToInt32(Console.ReadLine());
                }
            }
            else
            {
                for (int i = 0, k = 8; i < 8; i++)
                {
                    trains[i] = new Train("Станция № " + i.ToString(), k, 12, 00);
                    k--;
                }
            }
            Array.Sort(trains);
 
            string str;
            while(true)
            {
                Console.Write("\nВведите номер поезда для поиска: ");
                str = Console.ReadLine();
                foreach (Train c in trains)
                {
                    if (Convert.ToInt32(str) == c.number) c.Info();
                }
            }
        }
    }
    struct Train : IComparable<Train>
    {
        public String destination;
        public int number;
        public int hour;
        public int minute;
        public Train(string destination, int number, int hour, int minute)
        {
            this.destination = destination;
            this.number = number;
            this.hour = hour;
            this.minute = minute;
        }
        public int CompareTo(Train tr)
        {
            return this.number.CompareTo(tr.number);
        }
        public void Info()
        {
            Console.WriteLine("Название пункта назначения: " + this.destination + " \nНомер поезда " + this.number + " \nВремя отправления " + this.hour+":"+this.minute);
        }
    }
}
