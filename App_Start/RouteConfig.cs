using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MovieStoreNew
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // new and cleaner way to define custom routes using attributes
            routes.MapMvcAttributeRoutes();
            //older way to define custom routes
            //routes.MapRoute(
            //"MoviesByReleaseDate",
            //"movies/released/{year}/{month}",
            //new {Controller = "Movies", action = "ByReleaseDate"},
            //new {year = /*@"\d{4}"*/ @"2015|2016", month = @"\d{2}"} //constraints
            //    );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
