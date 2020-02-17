﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HellowWorld
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.config");


            routes.MapRoute(
                name: "Home",
                url: "Home",
                defaults: new { controller = "home", action = "GotoHome", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Home1",
                url: "Home/Home",
                defaults: new { controller = "home", action = "GotoHome", id = UrlParameter.Optional }
            ); 

            routes.MapRoute(
                 name: "Home2",
                 url: "",
                 defaults: new { controller = "home", action = "GotoHome", id = UrlParameter.Optional }
             );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

