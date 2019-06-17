﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.config");

            routes.MapRoute(
               name: "Home",
               url: "",
               defaults: new { controller = "Home", action = "ShowHomePage", id = UrlParameter.Optional }
           );

            routes.MapRoute(
               name: "Home2",
               url: "Home",
               defaults: new { controller = "Home", action = "ShowHomePage", id = UrlParameter.Optional }
           );
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
