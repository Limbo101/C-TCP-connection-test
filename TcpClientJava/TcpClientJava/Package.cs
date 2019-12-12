using System;
using System.Collections.Generic;
using System.Text;

namespace TcpClientJava
{
    [Serializable]
    public class Package
    {
        public string operation { get; set; }
        public string argument { get; set; }
        private int arg { get; set; }


        public Package(string operation, string argument)
        {
            this.operation = operation;
            this.argument = argument;

        }

        //public String getArgument()
        //{
        //    return argument;
        //}

        //public String getOperation()
        //{
        //    return operation;
        //}
    }
}   




