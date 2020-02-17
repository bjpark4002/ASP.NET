using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HellowWorld.Models;


namespace HellowWorld.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Load()
        {
            Customer obj =
                new Customer
                {
                    CustomerCode = "1001",
                    CustomerName = "Shiv"
                };
            return View("Customer",obj);
        }
        public ActionResult Enter()
        {
            return View("EnterCustomer");
        }
        public ActionResult Submit()//Customer obj)
        {
            Customer tas = new Customer
            {
                CustomerCode = Request.Form["CustomerCode"],
                CustomerName = Request.Form["CustomerName"]
            };


           return View("Customer",tas);
        }
    }
}