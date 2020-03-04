using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp_Client.MathServiceReference;
namespace ConsoleApp_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            MathServiceSoapClient client = new MathServiceSoapClient();
            var result = client.getStudent();
            Console.ReadKey();


        }
    }
}
