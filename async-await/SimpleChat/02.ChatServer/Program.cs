using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Threading;

namespace _02.ChatServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chat server");
            try
            {
                var port = 13000;
                var localAddr = IPAddress.Parse("127.0.0.1");
                var server = new TcpListener(localAddr, port);
                server.Start();
                List<ClientObject> clients = new List<ClientObject>();
                while (true)
                {
                    Thread.Sleep(10);
                    if (server.Pending())
                    {
                        ClientObject client = new ClientObject(server.AcceptTcpClient());
                        clients.Add(client);
                    }
                    for (int i = 0; i < clients.Count; i++)
                    {
                        if (clients[i].client.Available != 0)
                        {
                            if (clients[i].userName == "")
                            {                               
                                var name = clients[i].GetMessage();
                                for (int j = 0; j < clients.Count; j++)
                                {
                                    if(name == clients[j].userName)
                                    {
                                        name = "";
                                    }
                                }
                                if(name == "")
                                    clients[i].SendMessage("This name alredy used");
                                else
                                {
                                    clients[i].userName = name;
                                    clients[i].SendMessage("Welcome, " + clients[i].userName);
                                    for (int j = 0; j < clients.Count; j++)
                                    {
                                        if (j != i && clients[j].userName != "")
                                        {
                                            clients[j].SendMessage(clients[i].userName + " joined to chat");
                                        }
                                    }
                                    Console.WriteLine(clients[i].userName + " joined to chat");
                                }
                            }
                            else
                            {
                                var message = clients[i].GetMessage();
                                if (message == "quit")
                                {
                                    for (int j = 0; j < clients.Count; j++)
                                    {
                                        if (j != i && clients[j].userName != "")
                                        {
                                            clients[j].SendMessage(clients[i].userName + " leave chat");
                                        }
                                    }
                                    Console.WriteLine(clients[i].userName + " leave chat");
                                    clients[i].Stream.Close();
                                    clients[i].client.Close();
                                    clients.RemoveAt(i);
                                    i--;
                                }
                                else
                                {
                                    message = clients[i].userName + ": " + message;
                                    for (int j = 0; j < clients.Count; j++)
                                    {
                                        if (j != i && clients[j].userName != "")
                                        {
                                            clients[j].SendMessage(message);
                                        }
                                    }
                                    Console.WriteLine(message);
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
    public class ClientObject
    {
        public string userName;
        public NetworkStream Stream { get; private set; }
        public TcpClient client;

        public ClientObject(TcpClient tcpClient)
        {
            client = tcpClient;
            Stream = client.GetStream();
            userName = "";
            Console.WriteLine(client.Client.RemoteEndPoint);
        }
        public void SendMessage(string message)
        {
            var response = System.Text.Encoding.ASCII.GetBytes(message);
            Stream.Write(response, 0, response.Length);
        }
        public string GetMessage()
        {
            var bytes = new byte[256];
            var bytesReadCount = Stream.Read(bytes, 0, bytes.Length);
            return System.Text.Encoding.ASCII.GetString(bytes, 0, bytesReadCount);
        }
    }
}
