using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FirstMvcProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Home",
                url:  "", 
                defaults: new {controller = "Employee", action = "index"}
            );

            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "Category",
                url: "{Title}",
                defaults: new { controller = "Category", action = "Index", id = UrlParameter.Optional}
            );

            routes.MapRoute(
                name: "Detail",
                url: "{Title}/{DetailName}",
                defaults: new { controller = "Category", action = "Detail", id = UrlParameter.Optional, @DetailName = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
