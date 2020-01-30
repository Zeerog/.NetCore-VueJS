using System;

namespace _16.Password
{
    class Program
    {
        static void Main(string[] args)
        {
            for(;;)
            {
                Console.Write("Введите пароль:");
                if (Console.ReadLine() == "root")
                    break;
                else
                    Console.WriteLine("Неверный пароль!");
            }
        }
    }
}
