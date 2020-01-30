using System;

namespace _15.PawsOfGeeseAndRabbits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Есть кроликии и гуси, вместе у них 64 лапы.\n" +
                "Возможные ваианты:");
            for(int i=1; i<16;i++)
            {
                Console.WriteLine("Кроликов - "+i+ ", гусей - " + (64-i*4)/2);
            }
            Console.ReadLine();
        }
    }
}
