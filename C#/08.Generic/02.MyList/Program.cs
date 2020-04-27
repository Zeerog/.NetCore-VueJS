using System;

namespace _02.MyList
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
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(list.GetItem(i));
            }
            Console.WriteLine("count: " + list.Count);
        }
    }
    public class MyList<T>
    {
        private class Node<U>
        {
            public Node(U data)
            {
                Data = data;
            }
            public U Data { get; set; }
            public Node<U> Next { get; set; }
        }
        Node<T> head;
        Node<T> tail;
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
}
