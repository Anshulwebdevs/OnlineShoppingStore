using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OnlineShoppingStore.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(null, "Edit{id}",
                new
                {
                    controller = "Admin",
                    action = "Edit"

                },
                new { id = @"\d+" }
            );
            routes.MapRoute(
                name: "Admin",
                url: "Admin/{action}/{id}",
                defaults: new { controller = "Admin", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(null,"",
                new
                {
                    controller="Product",
                    action="List",
                    catagory=(string) null,
                    page=1
                }
            );

            routes.MapRoute(null, "Page{page}",
                new
                {
                    controller = "Product",
                    action = "List",
                    catagory = (string)null
                    
                },
                new { page=@"\d+"}
            );

            routes.MapRoute(null, "{catagory}",
                new
                {
                    controller = "Product",
                    action = "List",
                    page = 1
                }
            );
            routes.MapRoute(null, "{catagory}/Page{page}",
                new
                {
                    controller = "Product",
                    action = "List",
                },
                new { page = @"\d+" }
            );



            routes.MapRoute(null, "{controller}/{action}");



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Product", action = "List", id = UrlParameter.Optional }
            );



        }
    }
}
