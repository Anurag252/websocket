using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace WebsocketDemo
{
    class Program
    {

      static  Socket sock;
        static void Main(string[] args)
        {
            TcpListener sck = new TcpListener(IPAddress.Any, 1112);
            sck.Start();
            Console.WriteLine("Server started");
            
          sock =   sck.AcceptSocket();
            byte[] buffer = new byte[10000];
             sock.Receive(buffer);
            Console.WriteLine("found a connection");

            //   System.IO.Stream s = new NetworkStream(sock);
            // StreamReader sreader = new StreamReader(s);
            //  string k = sreader.ReadToEnd();
            string k = Encoding.ASCII.GetString(buffer);
            Console.WriteLine();
          //  s.Close();
            sock.Close();
            Console.Read();
        }
    }
}
