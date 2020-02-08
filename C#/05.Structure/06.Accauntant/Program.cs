using System;

namespace _06.Accauntant
{
    class Program
    {
        static void Main(string[] args)
        {
            Post worker;
            worker = Post.Worker;
            Accauntant Acc = new Accauntant();
            Console.WriteLine(Acc.AskForBonus(worker,180));
        }
    }
    class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            return hours > (int)worker;
        }
    }
    enum Post
    {
        Slave=288,
        Worker=160,
        Manager=140,
        Superior=70,
        Effective_manager=20
    }
}
