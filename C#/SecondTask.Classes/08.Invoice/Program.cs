using System;

namespace _08.Invoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(10, "OrdinaryNickname", "SomeCompany");
            invoice.nds = true;
            invoice.Article = "товар2";
            invoice.Quantity = 4;
            invoice.ShowPrice();
            Console.ReadLine();
        }
    }
    class Invoice
    {
        readonly int account;
        readonly string customer;
        readonly string provider;
        string article;
        int quantity;
        public bool nds;
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public string Article
        {
            set
            {
                article = value;
            }
            get
            {
                return article;
            }
        }
        public int Quantity
        {
            set
            {
                quantity = value;
            }
            get
            {
                return quantity;
            }
        }
        public void ShowPrice()
        {
            double price;
            if (article == "товар1")
                price = 6000;
            else if (article == "товар2")
                price = 8000;
            else if (article == "товар3")
                price = 10000;
            else
                price = 0;
            if (!nds)
                price *= 0.8;
            Console.WriteLine("Итоговая цена: " + price * quantity);
        }
    }
}