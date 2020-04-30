using System;
using System.Net.Sockets;
using System.IO;

namespace _01.SaveWebPage
{
    class Program
    {
        static void Main(string[] args)
        {
            var port = 80;
            while (true)
            {
                try
                {
                    var serverAddr = Console.ReadLine();
                    //serverAddr = "pagesaver info.cern.ch/hypertext/WWW/TheProject.html output.html";
                    if (serverAddr.Substring(0, 10) == "pagesaver ")
                    {
                        serverAddr = serverAddr.Substring(10);
                        var writePath = serverAddr.Substring(serverAddr.IndexOf(" ")+1);
                        serverAddr = serverAddr.Remove(serverAddr.IndexOf(" "));
                        var page = serverAddr.Substring(serverAddr.IndexOf("/") + 1);
                        serverAddr = serverAddr.Remove(serverAddr.IndexOf("/"));
                        Console.WriteLine(serverAddr);
                        Console.WriteLine(writePath);

                        var message = "GET /" + page + " HTTP/1.0\nHost: " + serverAddr + "\n\n";
                        var client = new TcpClient(serverAddr, port);
                        var data = System.Text.Encoding.ASCII.GetBytes(message);
                        NetworkStream stream = client.GetStream();

                        stream.Write(data, 0, data.Length);

                        if (stream.CanRead)
                        {
                            byte[] myReadBuffer = new byte[1024];
                            string CompleteMessage = "";
                            int numberOfBytesRead = 0;

                            do
                            {
                                numberOfBytesRead = stream.Read(myReadBuffer, 0, myReadBuffer.Length);

                                CompleteMessage += System.Text.Encoding.ASCII.GetString(myReadBuffer, 0, numberOfBytesRead);
                            }
                            while (stream.DataAvailable);
                            if (CompleteMessage.IndexOf("\n\r\n") != -1)
                            {
                                CompleteMessage = CompleteMessage.Substring(CompleteMessage.IndexOf("\n\r\n")+3);
                            }
                            StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default);
                            sw.WriteLine(CompleteMessage);
                            sw.Close();
                            Console.WriteLine("Запись выполнена");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Sorry.  You cannot read from this NetworkStream.");
                        }

                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Exception {0}", e);
                }
            }
        }
    }
}
