using System;

namespace _03.ArrayCustomSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 5, 5, 4, 8, 9, 6, 3, 2, 1 };
            numbers.Sort(true);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
    public static class IntExtension
    {
        public static void Sort(this int[] Arr, bool Direction)
        {
            int temp;
            for (int i = 0; i < Arr.Length - 1; i++)
            {
                for (int j = i + 1; j < Arr.Length; j++)
                {
                    if (Direction && Arr[i] > Arr[j])
                    {
                        temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                    else if (!Direction && Arr[i] < Arr[j])
                    {
                        temp = Arr[i];
                        Arr[i] = Arr[j];
                        Arr[j] = temp;
                    }
                }
            }
        }
    }
}
