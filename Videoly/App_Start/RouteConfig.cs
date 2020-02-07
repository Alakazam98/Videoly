﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Videoly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Customers",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Customers", action = "Customers", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "Movies",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Movies", action = "Movies", id = UrlParameter.Optional }
            );

            
        }
    }
}
