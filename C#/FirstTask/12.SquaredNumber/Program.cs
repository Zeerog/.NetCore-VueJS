using System;

namespace _12.SquaredNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, i=1;
            Console.Write("Введите число: ");
            int.TryParse(Console.ReadLine(), out number);
            while(i<number)
            {
                Console.WriteLine(i+"*"+i+"="+i*i);
                i++;
            }
            Console.ReadLine();
        }
    }
}
