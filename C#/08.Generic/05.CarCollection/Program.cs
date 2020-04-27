using System;

namespace _05.CarCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection<string> collection = new CarCollection<string>();
            collection.Add("model1", "-2000");
            collection.Add("model2", "10485");
            Console.WriteLine(collection.GetItem(1, false));
            collection.Clear();
            Console.WriteLine(collection.Count);
        }
    }
    public class CarCollection<T>
    {
        private class Node<U>
        {
            public Node(U model, U year)
            {
                Model = model;
                Year = year;
            }
            public U Model { get; set; }
            public U Year { get; set; }
            public Node<U> Next { get; set; }
        }
        Node<T> head;
        Node<T> tail;
        int count;

        public void Add(T model, T year)
        {
            Node<T> node = new Node<T>(model, year);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

            count++;
        }
        public int Count { get { return count; } }
        public T GetItem(int index, bool item)
        {
            if (index < Count)
            {
                int curIndex = 0;
                Node<T> current = head;
                while (curIndex != Count)
                {
                    if (curIndex == index)
                    {
                        if (item)
                            return current.Model;
                        else
                            return current.Year;
                    }
                    current = current.Next;
                    curIndex++;
                }
            }
            return default;
        }
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }
    }
}
