using System;

namespace _05.User
{
    class Program
    {
        static void Main(string[] args)
        {
            User newUser = new User();
            newUser.Login = "qwerty";
            newUser.FirstName = "Павел";
            newUser.LastName = "Блэк";
            newUser.Age = 20;
            newUser.Show();

            Console.ReadLine();
        }
    }
    class User
    {
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public readonly string creationDate;
        public User()
        {
            creationDate = DateTime.Now.ToString("dd/MM/yyyy");
        }
        public void Show()
        {
            Console.WriteLine("Логин: " + Login);
            Console.WriteLine("Имя: " + FirstName);
            Console.WriteLine("Фамилия: " + LastName);
            Console.WriteLine("Возраст: " + Age);
            Console.WriteLine("Дата заполнения: " + creationDate);
        }
    }
}