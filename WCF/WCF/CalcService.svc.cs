using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCF.Model;

namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CalcService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CalcService.svc or CalcService.svc.cs at the Solution Explorer and start debugging.
    public class CalcService : ICalcService
    {
        public void DoWork()
        {

        }
        public int Sum(int a , int b)
        {
            return a + b;
        }
        public List<Customer> GetCustomers()
        {
            List<Customer> custList = new List<Customer>();
            custList.Add(new Customer(1, "One"));
            custList.Add(new Customer(2, "Two"));
            custList.Add(new Customer(3, "Three"));
            custList.Add(new Customer(4, "Four"));
            return custList;
        }
    }
}
