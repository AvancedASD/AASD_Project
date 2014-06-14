using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AASD_WebUI.Infastructure;

namespace AASD_WebUI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(null, "", // Only matches the empty URL (i.e. /)
             new
             {
                 controller = "Search",
                 action = "Index",                
             }
             );

           // routes.MapRoute(
           //   "Quick_Search", // Route name
           //   "search/q-{query}.c-{context}", // URL with parameters
           //    new { controller = "SearchResult", 
           //        action = "List",
           //        query = UrlParameter.Optional, 
           //        context = UrlParameter.Optional }         
           //);

            routes.MapRoute(
              "Quick_Search", // Route name
              "search/page{page}", // URL with parameters
               new
               {
                   controller = "SearchResult",
                   action = "List",
                   page = 1
               },
               new { page = @"\d+" }
           );

            routes.MapRoute(
                null,
                "{controller}/{action}"
            );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            // Use LocalDB for Entity Framework by default
            Database.DefaultConnectionFactory = new SqlConnectionFactory(@"Data Source=(localdb)\v11.0; Integrated Security=True; MultipleActiveResultSets=True");

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);

            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());
        }
    }
}