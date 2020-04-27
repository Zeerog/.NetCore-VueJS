using System;

namespace _07.ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> list = new ArrayList<int>();
            for (int i = 0; i < 20; i++)
            {
                list.Add(i);
            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(list.GetItem(i));
            }
            Console.WriteLine("count: " + list.Count);
        }
    }
    public class ArrayList<T>
    {
        private int count = 0;
        public int Count
        {
            get
            {
                return count;
            }
        }
        private T[] arr = new T[10];
        public void Add(T item)
        {
            arr[count] = item;
            count++;
            if (count == arr.Length)
                Array.Resize(ref arr, (int)(count * 1.5));
        }
        public T GetItem(int index)
        {
            return arr[index];
        }
    }
}
