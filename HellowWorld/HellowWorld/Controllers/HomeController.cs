using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HellowWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            Session["MyTimeSession"] = DateTime.Now.ToString(); // alive until end of brower.
            TempData["MyTimeTemp"] = DateTime.Now.ToString(); // controller to controller . Die from second request.
            ViewBag.MyTime = DateTime.Now.ToString(); // controller to view. Dynamic dangerous. (use view data) Die when you switch from one action to other 
            return RedirectToAction("GotoHome", "Home");
        }
        public ActionResult GotoHome()
        {
            //data
            ViewData["MyTime"] = DateTime.Now.ToString();
            ViewBag.MyTime = DateTime.Now.ToString();
            return View();
        }
    }
}