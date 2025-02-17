using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WatchShop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "ProductsNew",
            url: "dong-ho-deo-tay/New-Product",
              defaults: new { controller = "Products", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
           name: "ProductsSeller",
           url: "dong-ho-deo-tay/Best-Seller",
             defaults: new { controller = "Products", action = "Index1", id = UrlParameter.Optional }
           );

            routes.MapRoute(
           name: "ProductsDiscount",
           url: "dong-ho-deo-tay/Discount",
             defaults: new { controller = "Products", action = "Index2", id = UrlParameter.Optional }
           );

            routes.MapRoute(
          name: "ProductsDetailsOmega",
          url: "dong-ho-deo-tay/{alias}",
            defaults: new { controller = "Product", action = "ProductDetails", id = UrlParameter.Optional }
          );

            routes.MapRoute(
        name: "ProductsDetailsHublot",
        url: "dong-ho-deo-tay/",
          defaults: new { controller = "Product", action = "ProductDetails", id = UrlParameter.Optional }
        );

            routes.MapRoute(
        name: "ProductsDetailsRolex",
        url: "dong-ho-deo-tay/",
          defaults: new { controller = "Product", action = "ProductDetails", id = UrlParameter.Optional }
        );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
