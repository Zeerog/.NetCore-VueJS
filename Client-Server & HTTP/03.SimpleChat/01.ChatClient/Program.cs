using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace _01.ChatClient
{
    class Program
    {
        private const string serverAddr = "127.0.0.1";
        private const int port = 13000;
        static TcpClient client;
        static NetworkStream stream;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            try
            {
                client = new TcpClient(serverAddr, port);
                stream = client.GetStream();
                while (true)
                {
                    Thread.Sleep(100);
                    if (Console.KeyAvailable)
                    {
                        SendMessage(Console.ReadLine());
                    }
                    if (client.Available != 0)
                    {
                        Console.WriteLine(ReceiveMessage());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void SendMessage(string message)
        {
            var data = System.Text.Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);
            if(message == "quit")
                Environment.Exit(0);
        }
        static string ReceiveMessage()
        {
            var bytes = new byte[256];
            var bytesReadCount = stream.Read(bytes, 0, bytes.Length);
            return System.Text.Encoding.ASCII.GetString(bytes, 0, bytesReadCount);
        }
    }
}