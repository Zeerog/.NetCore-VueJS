using System;

namespace _01.MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class MyClass<T> where T : new()
    {
        public static T FacrotyMethod()
        {
            return new T();
        }
    }
}
