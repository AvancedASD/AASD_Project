using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AASD_WebUI.Models;
using System.Web.Routing;
using AASD_WebUI.ServiceReference_Search;

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
            //later add Model.IsValid
          

            //using (AASDServiceClient client = new AASDServiceClient())
            //{
            //    RetrieveSearchRequest retrieveSearchRequest = new RetrieveSearchRequest();
            //    retrieveSearchRequest.Request = new QueryContract() { Query = resultsListViewModel.currentQuery };
            //    resultsListViewModel.results = client.RetrieveSearch(retrieveSearchRequest);

            //    //Console.WriteLine(lstResultContracts[0].Title);
            //}
            return RedirectToAction("List", "SearchResult", new { query = query.stringQuery, context = query.context });   
            //return RedirectToRoute(new
            //{
            //    controller = "SearchResult",
            //    action = "List",
            //    query = query.stringQuery
            //});
        }


       
    }
}
