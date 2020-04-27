using System;

namespace _03.MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();
            dictionary.Add("Маша", "Василькина");
            dictionary.Add("Петя", "Пяточкин");
            dictionary.Add("Секрет", "Секретный");
            Console.WriteLine(dictionary.GetValue("Петя"));
            Console.WriteLine(dictionary.Count);


        }
    }
    public class MyDictionary<TKey, TValue>
    {
        private class Node<T,U>
        {
            public Node(T key, U value)
            {
                Key = key;
                Value = value;
            }
            public T Key { get; set; }
            public U Value { get; set; }
            public Node<T,U> Next { get; set; }
        }
        Node<TKey, TValue> head;
        Node<TKey, TValue> tail;
        int count;

        public void Add(TKey key, TValue value)
        {
            Node<TKey, TValue> node = new Node<TKey, TValue>(key, value);

            if (head == null)
                head = node;
            else
                tail.Next = node;
            tail = node;

            count++;
        }
        public int Count { get { return count; } }
        public TValue GetValue(TKey key)
        {
            int curIndex = 0;
            Node<TKey, TValue> current = head;
            while (curIndex != Count)
            {
                if (current.Key.GetHashCode() == key.GetHashCode())
                    return current.Value;
                current = current.Next;
                curIndex++;
            }
            return default;
        }
    }
}
