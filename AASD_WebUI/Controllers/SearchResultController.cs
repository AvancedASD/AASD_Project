using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AASD_WebUI.Models;
using AASD_WebUI.ServiceReference_Search;

namespace AASD_WebUI.Controllers
{
    public class ResultRepository
    {
        //[TestMethod]
        public IEnumerable<ResultContract> GetFakeResults(string query)
        {
            /*ResultContract[] results = new ResultContract[100];
             for (int i = 0; i < 100; i++)
             {
                 results[i] = new ResultContract() { Description = query, DisplayUrl = "xxx.com"+i.ToString(), Title = query, Url = "www.xxx.com" };
             }*/
            ResultContract[] results;
            using (AASDServiceClient client = new AASDServiceClient())
            {
                RetrieveSearchRequest retrieveSearchRequest = new RetrieveSearchRequest();
                retrieveSearchRequest.Request = new QueryContract() { Query = query, Context = string.Empty };
                results = client.RetrieveSearch(retrieveSearchRequest);
            }
            return results;
        }
    }


    public class SearchResultController : Controller
    {
        private int pageSize = 10;
        private IAASDService _service;
        // private ResultRepository resultRepository;


        //Have to use interface and mock
        public SearchResultController(IAASDService service)
        {
            //resultRepository = new ResultRepository();
            _service = service;
        }


        [OutputCache(Duration = 30)]
        public ActionResult List(string query = "", string context = "", int page = 1)
        {
            //Test
            if (query == null)
                throw new NullReferenceException();

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
            // resultsListViewModel.currentQuery.stringQuery += DateTime.Now.ToString();
            return View(resultsListViewModel);
        }
    }
}
