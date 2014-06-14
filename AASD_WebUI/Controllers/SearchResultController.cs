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

            ResultContract[] results = new ResultContract[100];
             for (int i = 0; i < 100; i++)
             {
                 results[i] = new ResultContract() { Description = query, DisplayUrl = "xxx.com"+i.ToString(), Title = query, Url = "www.xxx.com" };
             }
            /*ResultContract[] results;
            using (AASDServiceClient client = new AASDServiceClient())
            {
                RetrieveSearchRequest retrieveSearchRequest = new RetrieveSearchRequest();
                retrieveSearchRequest.Request = new QueryContract() { Query = query };
                results = client.RetrieveSearch(retrieveSearchRequest);
            }*/

            return results;
        }

    }


    public class SearchResultController : Controller
    {
        public int pageSize = 10;
        private ResultRepository resultRepository;

        //Have to use interface and mock
        public SearchResultController()
        {
            resultRepository = new ResultRepository();
        }

        //[OutputCache(Duration = 30)]
        public ActionResult List(string query = "test", string context = "", int page = 1)
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

            resultsListViewModel.results = resultRepository.
                GetFakeResults(resultsListViewModel.currentQuery.stringQuery).
                Skip((page - 1) * pageSize).Take(pageSize);
            resultsListViewModel.pagingInfo = new PagingInfo
            {
                currentPage = page,
                itemsPerPage = pageSize,
                totalItems = resultRepository.
                GetFakeResults(resultsListViewModel.currentQuery.stringQuery).Count()
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
