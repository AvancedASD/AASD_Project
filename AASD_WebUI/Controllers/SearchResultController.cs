using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AASD_WebUI.Models;
using AASD_WebUI.Proxy;
using AASD_BuisnessLayer;
using AASD_BuisnessLayer.BuisnessLayer_Models.Concrete.SearchEngines;
using AASD_BuisnessLayer.Entities;

///Created by Ivan
namespace AASD_WebUI.Controllers
{ 


    public class SearchResultController : Controller
    {
        private int pageSize = 10;
        private IAASDService _service;
      
        public SearchResultController(IAASDService service)
        {           
            _service = service;
        }


        [OutputCache(Duration = 30)]
        public ActionResult List(string query = "", string context = "", int page = 1)
        {           

            if (query == String.Empty)
            {
                return View("EmptyQueryError");
            }

            ResultListViewModel resultsListViewModel = new ResultListViewModel();
            resultsListViewModel.currentQuery = new QueryViewModel() { stringQuery = query, context = context };

            RetrieveSearchRequest retrieveSearchRequest = new RetrieveSearchRequest();
            retrieveSearchRequest.Request = new QueryContract() { Query = query, Context = context };

            RetrieveSearchRequest1 inValue = new RetrieveSearchRequest1();
            inValue.RetrieveSearchRequest = retrieveSearchRequest;

           
            resultsListViewModel.results = _service.
                RetrieveSearch(inValue).listResultContract.
                Skip((page - 1) * pageSize).Take(pageSize);

            resultsListViewModel.pagingInfo = new PagingInfo
            {
                currentPage = page,
                itemsPerPage = pageSize,
                totalItems = _service.
                     RetrieveSearch(inValue).
                     listResultContract.Count()
            };

            if (resultsListViewModel.results == null)
            {
                return View("ServiceUnavailableError");
            }
        
            return View(resultsListViewModel);
        }
    }
}
