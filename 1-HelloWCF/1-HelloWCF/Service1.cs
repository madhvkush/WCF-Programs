﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _1_HelloWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class HelloService : IHelloService
    {
     
        public string GetMessage(string Name)
        {
            return "Hello " + Name;
        }
    }
}
