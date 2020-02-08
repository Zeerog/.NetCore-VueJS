using System;

namespace _02.Player
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            ((IPlayable)player).Play();
            ((IPlayable)player).Pause();
            ((IPlayable)player).Stop();
            ((IRecodable)player).Record();
            ((IRecodable)player).Pause();
            ((IRecodable)player).Stop();

            //Или
            //IPlayable playable = new Player();
            //IRecodable recodable = new Player();
            //playable.Play();
            //playable.Pause();
            //playable.Stop();
            //recodable.Record();
            //recodable.Pause();
            //recodable.Stop();
        }
    }
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class Player : IPlayable, IRecodable
    {
        void IPlayable.Play()
        {
            Console.WriteLine("Play");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Pause Player");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Stop Player");
        }
        void IRecodable.Record()
        {
            Console.WriteLine("Record");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("Pause Record");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Stop Record");
        }
    }
}
