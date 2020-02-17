using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Practice.Models;
namespace Practice.ViewModel
{
    public class CustomerViewModel
    {
        //customer 
        public Customer customer { get; set; }

        //list of customer
        public List<Customer> customers { get; set; }



    }
}