using System;
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
            using (System.ServiceModel.ServiceHost host = new System.ServiceModel.ServiceHost(typeof(_5_MessageContracts.MyServices)))
            {
                host.Open();
                Console.WriteLine("host started");
                Console.Read();
            }
        }
    }
}
