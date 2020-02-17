using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.Models;
using Practice.Dal;
using Practice.ViewModel;
namespace Practice.Controllers
{
    public class CustomerBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpContextBase objContext = controllerContext.HttpContext;
            string custCode = objContext.Request.Form["txtCustomerCode"];
            string custName = objContext.Request.Form["txtCustomerName"];

            Customer obj = new Customer()
            {
                CustomerCode = custCode,
                CustomerName = custName

            };
            return obj;
        }
    }
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Load()
        {
            Customer obj =
                new Customer
                {
                    CustomerCode = "1001",
                    CustomerName = "Bumjin"
                };
            return View("Customer",obj);
        }
        public ActionResult Enter()
        {
            CustomerViewModel obj = new CustomerViewModel(); // viewmodel obj
            obj.customer = new Customer();                   // single object.
            CustomerDal dal = new CustomerDal();             // using dal, i have filled customer collection
            List<Customer> customerscroll = dal.Customers.ToList<Customer>();
            obj.customers = customerscroll;
            return View("EnterCustomer",obj);
        }


        public ActionResult EnterSearch()
        {
            CustomerViewModel obj = new CustomerViewModel();
            obj.customers = new List<Customer>();
            return View("SearchCustomer",obj);
        }
        public ActionResult SearchCustomer()
        {
            CustomerViewModel obj = new CustomerViewModel();
            CustomerDal dal = new CustomerDal();             // using dal, i have filled customer collection

            string str = Request.Form["txtCustomerName"].ToString();
            List<Customer> customerscroll = (from x in dal.Customers where x.CustomerName == str select x).ToList<Customer>();
            obj.customers = customerscroll;
            return View("SearchCustomer", obj);
        }
/*
        public ActionResult Submit([ModelBinder(typeof(CustomerBinder))] Customer obj )
        {
            //Customer obj = new Customer();
            //obj.CustomerName = Request.Form["CustomerName"];
            //obj.CustomerCode = Request.Form["CustomerCode"];

            return View("Customer",obj);
        }*/


        public ActionResult Submit()
        {

            CustomerViewModel vm = new CustomerViewModel();
            Customer obj = new Customer();
            obj.CustomerName = Request.Form["Customer.CustomerName"];
            obj.CustomerCode = Request.Form["Customer.CustomerCode"];
            if (ModelState.IsValid)
            {
                // insert customer object into database
                CustomerDal Dal = new CustomerDal();
                Dal.Customers.Add(obj); //in mememory
                Dal.SaveChanges();  //physical commit
                vm.customer = new Customer();
            }
            else
            {
                vm.customer = obj; 
            }
            CustomerDal dal = new CustomerDal();             // using dal, i have filled customer collection
            List<Customer> customerscroll = dal.Customers.ToList<Customer>();
            vm.customers = customerscroll;

            return View("EnterCustomer",vm);
            
        }
    }
}