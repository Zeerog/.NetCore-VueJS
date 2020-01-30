using System;

namespace _2.FeedDogOrCat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вы кот который делает \"мяу\", или собака с важным \"гав\"?");
            string input;
            input = Console.ReadLine();
            if (input == "мяу")
                Console.WriteLine("Покорми кота");
            else if (input == "мяу")
                Console.WriteLine("Погуляй с собакой");
            else
                Console.WriteLine("Человек, тебе не обмануть меня");
            Console.ReadLine();
        }
    }
}
