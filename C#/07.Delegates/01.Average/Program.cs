using System;

namespace _01.Average
{
    delegate int Operation(int x, int y, int z);
    class Program
    {
        static void Main(string[] args)
        {
            Operation operation = delegate (int x, int y, int z)
            {
                return (x + y + z)/3;
            };
        }
    }
}
