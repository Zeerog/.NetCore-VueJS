using System;

namespace _01.Printer
{
    class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }

    }

    class PrinterBlue : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(value);
        }
    }

    class PrinterRed : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
        }

    }

    class Program
    {
        private static void Main(string[] args)
        {
            var arr = new Printer[3];
            arr[0] = new Printer();
            arr[1] = new PrinterBlue();
            arr[2] = new PrinterRed();

            foreach (Printer pr in arr)
            {
                pr.Print("Hello");
            }
        }

    }
}
