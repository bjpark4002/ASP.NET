﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoComplete.AutoCompleteServiceReference;
namespace AutoComplete.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Search()
        {
            return View();
        }


        [HttpPost]
        public JsonResult AutoComplete(string prefix)
        {
            
            WebServiceClient db = new WebServiceClient();
            //var filteredSubCategoryList = db.GetProduct();

            List<ProductTable> filteredSubCategoryList = new List<ProductTable>();

            var var = db.GetProducts().Select(x => x.Name).Where(x => x.ToLower().StartsWith(prefix)).ToList();
            return Json(var);



        }
    }
}