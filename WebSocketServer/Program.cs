using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSocketServer
{
    class Program
    {
        static void Main(string[] args)
        {
            WebSocketServer socketServer = new WebSocketServer("http://localhost:8080/");
            socketServer.Start();
            Console.ReadKey();
        }
    }
}
