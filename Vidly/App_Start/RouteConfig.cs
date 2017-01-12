using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapMvcAttributeRoutes();

            ////customer route - the order matters; from specfic the generic
            //routes.MapRoute("MoviesByReleaseDate",
            //                "movies/release/{year}/{month}",
            //                new { controller = "Movies", action = "ByReleaseDate" },
            //                new {year = @"\d{4}", month = @"\d{2}"});

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
