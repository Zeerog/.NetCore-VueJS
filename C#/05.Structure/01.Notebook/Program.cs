using System;

namespace _01.Notebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook note1 = new Notebook("iPled", "Nenovo", 10000);
            note1.Print();
        }
    }
    struct Notebook
    {
        public string model;
        public string manufacturer;
        public int price;

        public Notebook(string model, string manufacturer, int price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public void Print()
        {
            Console.WriteLine($"Модель: {model}\nПроизводитель: {manufacturer}\nЦена: {price}\n");
        }

    }
}
