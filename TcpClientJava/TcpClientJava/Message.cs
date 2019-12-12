using System;
using System.Collections.Generic;
using System.Text;

namespace TcpClientJava
{
    [SerializableAttribute]
    class Message
    {
        public byte[] Data { get; set; }
    }
}
