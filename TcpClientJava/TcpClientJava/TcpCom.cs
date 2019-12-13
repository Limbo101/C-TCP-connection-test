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
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;


namespace TcpClientJava
{
    public class TcpCom
    {
        private TcpClient client;
        private String ip;
        private int port;
        public TcpCom(String ip, int port)
        {

            this.ip = "localhost";
            this.port = 3344;

        }

        public void startClient()
        {

            client = new TcpClient(ip, port); // waits for new tcp clients

        }
    

        public void SendClient() {

            Boolean send = true;
            NetworkStream stream = client.GetStream();
            while (true)
            {
                send = true;
                if (send == true)
                {
                    Package pack = new Package("ciulpk bybi", "salut");
                    Console.WriteLine(pack.operation);
                    //sending
                    Console.WriteLine("Sending date!");
                    string message = JsonConvert.SerializeObject(pack);
                    byte[] sendBytes = new byte[1024];
                    sendBytes = Encoding.UTF8.GetBytes(message + "\r\0") ; // this
                    stream.Write(sendBytes, 0, sendBytes.Length);
                    Console.WriteLine(message);
                    Console.WriteLine("Date has been sent!");
                    send = false;
                }
             
            }


            //// receiving
            //byte[] buffer = new Byte[2048];
            //    int readBytes = client.GetStream().Read(buffer, 0, buffer.Length);
            //    string receivedJsonString = Encoding.UTF8.GetString(buffer, 0, readBytes);
            //    readBytes.ToString();
            //String deserializedMessage = JsonConvert.DeserializeObject<String>(message);
            //    Console.WriteLine(deserializedMessage);
            ////client.Close();
            ///
            client.GetStream().Close();
                Console.WriteLine("Client terminated.");
            client.Close(); 

        }
        //public static Message Serialize(object anySerializableObject)
        //{
        //    using (var memoryStream = new MemoryStream())
        //    {
        //        (new BinaryFormatter()).Serialize(memoryStream, anySerializableObject);
        //        return new Message { Data = memoryStream.ToArray() };
        //    }


        }
}

