using System;
using System.Net;
using System.Net.Sockets;

namespace SocketClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint connect = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 6400);
        }
    }
}
