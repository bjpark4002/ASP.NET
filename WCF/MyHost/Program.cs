using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WCF;

namespace MyHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (System.ServiceModel.ServiceHost host = new ServiceHost(typeof(CalcService)))
            {
                host.Open();
                Console.WriteLine("Host started");
                Console.ReadKey();
            }
        }
    }
}