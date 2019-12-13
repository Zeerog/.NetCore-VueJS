using System;

namespace _01.Address
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Index = "55105";
            address.Country = "UA";
            address.City = "Dnepr";
            address.Street = "Shevcghenko";
            address.House = "14";
            address.Apartment = "D16";
            Console.WriteLine("index = "+ address.Index);
            Console.WriteLine("country = " + address.Country);
            Console.WriteLine("city = " + address.City);
            Console.WriteLine("street = " + address.Street);
            Console.WriteLine("house = " + address.House);
            Console.WriteLine("apartment = " + address.Apartment);
            Console.ReadLine();
        }
    }
    class Address
    {
        public string Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Apartment { get; set; }
    }
}
