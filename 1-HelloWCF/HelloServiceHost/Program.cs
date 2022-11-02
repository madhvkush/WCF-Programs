using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace HelloServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(_1_HelloWCF.HelloService)))
            {
                host.Open();
                Console.WriteLine("Host started.. " + DateTime.Now);
                Console.Read();
            }
            // if it not runs properly.. {Run EXE file of host as administrator}
            // or check below
           // https://stackoverflow.com/questions/885744/wcf-servicehost-access-rights
        }
    }
}
