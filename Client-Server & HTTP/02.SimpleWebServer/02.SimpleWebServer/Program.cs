using System;
using System.Net;
using System.Net.Sockets;

namespace _02.SimpleWebServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("simple server");
            try
            {
                var port = 13000;
                var localAddr = IPAddress.Parse("127.0.0.1");
                var server = new TcpListener(localAddr, port);
                server.Start();
                var bytes = new byte[512];
                while (true)
                {
                    Console.WriteLine("Waiting for connection");
                    var client = server.AcceptTcpClient();
                    Console.WriteLine("Accepted connection from {0}", client.Client.RemoteEndPoint);
                    NetworkStream stream = client.GetStream();
                    var bytesReadCount = stream.Read(bytes, 0, bytes.Length);
                    var data = System.Text.Encoding.ASCII.GetString(bytes, 0, bytesReadCount);
                    Console.WriteLine("Get message: {0}", data);
                    data = "HTTP/1.1 200 OK\nContent-Type: text/html\n\r\n"+
                    "<html><head><title> Go Away </title></head>"+
                    "<body><center><h1><a href=\"https://browser.ru/\"> Here you can see something terible </a></h1></center>" +
                    "</body></html>";
                    var response = System.Text.Encoding.Default.GetBytes(data);
                    stream.Write(response, 0, response.Length);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception {0}", e);
            }
        }
    }
}