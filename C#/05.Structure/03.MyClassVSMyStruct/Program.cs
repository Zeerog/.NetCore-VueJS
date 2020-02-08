using System;

namespace _03.MyClassVSMyStruct
{
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass { change = "не изменено" };
            MyStruct myStruct = new MyStruct { change = "не изменено" };
            ClassTaker(myClass);
            StruktTaker(myStruct);
            Console.WriteLine("myClass.change = " + myClass.change);
            Console.WriteLine("myStruct.change = " + myStruct.change);
        }
    }
    class MyClass
    {
        public string change;
    }
    struct MyStruct
    {
        public string change;
    }
}
/* Когда мы используем экземпляр класса, в метод отправляется копия ссылки на класс, потому все изменения в методе сохраняются в классе
 * Когда мы используем экземпляр структуры, в метод отправляется копия структуры, потому изменения в копии не затрагивают оригинальную структуру
 */ 