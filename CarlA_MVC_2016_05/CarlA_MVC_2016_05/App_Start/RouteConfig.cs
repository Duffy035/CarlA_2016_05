//Carl ANdersson

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CarlA_MVC_2016_05
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                name: "Hexa",
                url: "SpriteController/Hexa/{id}",
                defaults: new { controller = "SpriteController", action = "Hexa", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Octa",
                url: "SpriteController/Octa/{id}",
                defaults: new { controller = "SpriteController", action = "Octa", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
