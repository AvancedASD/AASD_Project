using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AASD_WebUI.Models;
using System.Web.Routing;
using AASD_WebUI.Proxy;
using System.Data.Sql;
///Created by Ivan
namespace AASD_WebUI.Controllers
{
    public class SearchController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(QueryViewModel query)
        {
            return RedirectToAction("List", "SearchResult",
                new { query = query.stringQuery, context = query.context });
        }

        public void FixEfProviderServicesProblem()
        {
            //The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            //for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
            //Make sure the provider assembly is available to the running application. 
            //See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.

            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }


    }
}
