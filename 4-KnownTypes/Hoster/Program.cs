﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoster
{
    class Program
    {
        static void Main(string[] args)
        {
            using (System.ServiceModel.ServiceHost host = new System.ServiceModel.ServiceHost(typeof(_4_KnownTypes.MyService)))
            {
                host.Open();
                Console.WriteLine("host started");
                Console.Read();
            }
        }
    }
}
