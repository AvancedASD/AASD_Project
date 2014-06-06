using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AASD_WebUI.ServiceReference_Search;
using AASD_WebUI.Models;

namespace AASD_WebUI.Controllers
{
    public class ResultController : Controller
    {
        //
        // GET: /Result/
         public ActionResult List(string query = "")
        {
            string filteredQuery = query;
            
            ResultListViewModel resultsListViewModel = new ResultListViewModel();
            resultsListViewModel.currentQuery = filteredQuery;


           using (AASDServiceClient client = new AASDServiceClient())
            {
                RetrieveSearchRequest retrieveSearchRequest = new RetrieveSearchRequest();
                retrieveSearchRequest.Request = new QueryContract() { Query = resultsListViewModel.currentQuery };
                resultsListViewModel.results = client.RetrieveSearch(retrieveSearchRequest);

                //Console.WriteLine(lstResultContracts[0].Title);
            }
            return View(resultsListViewModel);
        }

    }
}
