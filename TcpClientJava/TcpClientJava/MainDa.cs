using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace TcpClientJava
{
    class MainDa
    {
        public static void Main(string[] args)
        {
            TcpCom salut = new TcpCom("localhost",3344);
            salut.startClient();
            salut.SendClient();
         
        }
    }
}
