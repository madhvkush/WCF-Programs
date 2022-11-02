using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (System.ServiceModel.ServiceHost host = new System.ServiceModel.ServiceHost(typeof(_2_MultipleServices.CompanyService)))
            {
                host.Open();
                Console.WriteLine("host started"); // Run as Administrator
                Console.Read();
            }
        }
    }
}
