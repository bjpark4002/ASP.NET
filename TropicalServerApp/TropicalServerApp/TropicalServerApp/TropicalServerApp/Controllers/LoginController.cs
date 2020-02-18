using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TropicalServerApp.Models;
using TropicalServerApp.Dal;

namespace TropicalServerApp.Controllers
{
    public class LoginController : Controller
    {
        // static user object 
        // GET: Login
        public ActionResult Login()
        {
            ViewData["MyTime"] = DateTime.Now.ToString();

            Customer obj = new Customer();
            return View("Login",obj);
        }
        
        public ActionResult LoginSuccess()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ValidateLogin(Customer obj)
        {
            if (ModelState.IsValid)
            {
                using (var db = new CustomerDal())
                {
                    //Linq  
                    //var user = db.Customers.FirstOrDefault(u=>u.LoginId == obj.LoginId && u.Password == obj.Password);

                    var user = db.Customers.FirstOrDefault(u => u.LoginId.Equals(obj.LoginId) && u.Password.Equals(obj.Password)); 
                    if(user != null)
                    {
                        //return View("AfterLogin", obj);
                        return RedirectToAction("Orders", "Product");
                    }
                }
                ModelState.AddModelError(string.Empty, "Incorrect ID/Password");
                //return View("Login", obj);
            }
            return View("Login",obj);

            //adding info into database.
            //CustomerDal Dal = new CustomerDal(); 
            //Dal.Customers.Add(obj);
            //Dal.SaveChanges();
            //if (ModelState.IsValid)
            //{

            //    return View("AfterLogin", obj);
            //}
            //else
            //{
            //    return View("Login", obj);
            //}
            //Customer obj = new Customer();

            //obj.LoginId  = Request.Form["txtLoginId"];
            //obj.Password = Request.Form["txtPassword"];
        }
    }
}