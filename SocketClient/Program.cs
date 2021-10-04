using System;
using System.Text;
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

            listen.Connect(connect);

            byte[] send_info = new byte[100];
            string data; 

            Console.WriteLine("Ingrese la info a enviar");
            data = Console.ReadLine();

            send_info = Encoding.Default.GetBytes(data);

            listen.Send(send_info);

            Console.ReadKey();

        }
    }
}
