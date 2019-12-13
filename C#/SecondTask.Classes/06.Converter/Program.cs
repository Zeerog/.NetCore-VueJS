using System;

namespace _06.Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter Converter = new Converter(0.042, 0.038, 2.68);
            Converter.ConvertFromUAH(1000);
            Converter.ConvertToUAH(100);
            Console.ReadLine();
        }
    }
    class Converter
    {
        double usd, eur, rub;
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        public void ConvertToUAH(double money)
        {
            Console.WriteLine($"{money} USD = {(money / usd).ToString("#.##")} UAH");
            Console.WriteLine($"{money} EUR = {(money / eur).ToString("#.##")} UAH");
            Console.WriteLine($"{money} RUB = {(money / rub).ToString("#.##")} UAH");
        }
        public void ConvertFromUAH(double money)
        {
            Console.WriteLine($"{money} UAH = {(money * usd).ToString("#.##")} USD");
            Console.WriteLine($"{money} UAH = {(money * eur).ToString("#.##")} EUR");
            Console.WriteLine($"{money} UAH = {(money * rub).ToString("#.##")} RUB");
        }
    }
}