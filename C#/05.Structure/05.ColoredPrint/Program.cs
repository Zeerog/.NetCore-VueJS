using System;

namespace _05.ColoredPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            String stroka;
            int color;
            Console.WriteLine("Введите текст:");
            stroka = Console.ReadLine();
            for(int i = 1; i < 16; i++)
            {
                Rainbow.Print("Цвет №"+i, i);
            }
            Console.WriteLine("Выберите цвет:");
            color = Convert.ToInt32(Console.ReadLine());
            Rainbow.Print(stroka, color);
        }
    }
    static class Rainbow
    {
        static ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
        public static void Print(string stroka, int color)
        {
            Console.ForegroundColor = colors[color];
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }
}
