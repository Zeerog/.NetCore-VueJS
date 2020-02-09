using System;

namespace _04.OwnStringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string qwe = "I can be can";
            Console.Write(qwe.MyReplace("can","qw"));
        }
    }
    public static class StringExtension
    {
        public static string MySubstring(this string str, int index)
        {
            char[] res = new char[str.Length - index];
            int i = 0;
            for (; index < str.Length; index++)
            {
                res[i] = str[index];
                i++;
            }
            return new string(res);
        }
        public static string MySubstring(this string str, int index, int length)
        {
            char[] res;
            int i = 0;
            int end = index + length;
            if (end > str.Length)
            {
                res = new char[str.Length - index];
                for (; index < str.Length; index++)
                {
                    res[i] = str[index];
                    i++;
                }
            }
            else
            {
                res = new char[length];
                for (; index < end; index++)
                {
                    res[i] = str[index];
                    i++;
                }
            }
            return new string(res);
        }
        public static int MyIndexOf(this string str, string txt)
        {
            int index = -1;
            int temp = 1;
            bool find = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == txt[0])
                {
                    temp = i;
                    for (int j = 0; j < txt.Length; j++)
                    {
                        if (str[i] == txt[j])
                            find = true;
                        else
                        {
                            find = false;
                            break;
                        }
                        i++;
                    }
                }
                if (find)
                {
                    index = temp;
                    break;
                }
            }
            return index;
        }
        public static string MyReplace(this string str, string word, string to)
        {
            char[] res;
            int count = 0;
            bool find = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == word[0])
                {
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (str[i] == word[j])
                            find = true;
                        else
                        {
                            find = false;
                            break;
                        }
                        i++;
                    }
                }
                if (find)
                {
                    find = false;
                    count++;
                }
            }
            if(count==0)
                return str;
            res = new char[str.Length - (word.Length - to.Length) * count];
            int k = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == word[0])
                {
                    int temp = i;
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (str[temp] == word[j])
                            find = true;
                        else
                        {
                            find = false;
                            break;
                        }
                        temp++;
                    }
                }
                if (find)
                {
                    i += word.Length-1;
                    find = false;
                    for (int j = 0; j < to.Length; j++)
                    {
                        res[k] = to[j];
                        k++;
                    }
                }
                else
                {
                    res[k] = str[i];
                    k++;
                }
            }
            return new string(res);
        }

    }
}
