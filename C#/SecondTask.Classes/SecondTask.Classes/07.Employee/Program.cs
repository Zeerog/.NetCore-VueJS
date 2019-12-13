using System;

namespace _07.Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Григорий","Тим'янов");
            employee.position = "должность2";
            employee.yearOfWork = 7;
            employee.Show();
            Console.ReadLine();
        }
    }
    class Employee
    {
        string firstName, lastName;
        public string position;
        public int yearOfWork;
        double  salary;
        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        void SalaryCalc()
        {
            if (position == "должность1")
                salary = 6000;
            else if(position == "должность2")
                salary = 8000;
            else if (position == "должность3")
                salary = 10000;
            if (yearOfWork >= 5)
                salary *= 1.2;
        }
        public void Show()
        {
            SalaryCalc();
            Console.WriteLine("Фамилия: " + lastName);
            Console.WriteLine("Имя: " + firstName);
            Console.WriteLine("Должность: " + position);
            Console.WriteLine("Оклад: " + salary);
            Console.WriteLine("Налог: " + salary*0.2);
        }
    }
}