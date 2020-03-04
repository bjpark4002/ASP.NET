using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF.Model
{
    [DataContract]
    public class Customer
    {

        [DataMember]
        private int CustomerId { get; set; }
        [DataMember]

        public string CustomerName { get; set; }
        public Customer(int custID, string custName)
        {
            CustomerId = custID;
            CustomerName = custName;
        }
        public Customer() { }
    }
}