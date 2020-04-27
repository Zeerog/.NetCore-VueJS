using System;

namespace _04.GetArray
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            for (int i = 0; i < 20; i++)
            {
                list.Add(i);
            }
            int[] arr = list.GetArray();
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(arr[i]);
            }
   

        }

    }
    public class Node<U>
    {
        public Node(U data)
        {
            Data = data;
        }
        public U Data { get; set; }
        public Node<U> Next { get; set; }
    }
    public class MyList<T>
    {
        public Node<T> head;
        public Node<T> tail;
        int count;

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

            count++;
        }
        public int Count { get { return count; } }
        public T GetItem(int index)
        {
            if (index < Count)
            {
                int curIndex = 0;
                Node<T> current = head;
                while (curIndex != Count)
                {
                    if (curIndex == index)
                        return current.Data;
                    current = current.Next;
                    curIndex++;
                }
            }
            return default;
        }
    }

    public static class MyListExtension
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            T[] arr = new T[list.Count];
            int curIndex = 0;
            Node<T> current = list.head;
            while (curIndex != list.Count)
            {
                arr[curIndex] = current.Data;
                current = current.Next;
                curIndex++;
            }
            return arr;
        }
    }
}
