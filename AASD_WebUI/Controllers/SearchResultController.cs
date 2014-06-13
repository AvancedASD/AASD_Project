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
        private static string currentQuery = null;
        private static ResultContract[] results = null;

        //[TestMethod]
        public IEnumerable<ResultContract> GetFakeResults(string query)
        {
            if (currentQuery != query) //then getresults from service
            {
                results = new ResultContract[100];
                for (int i = 0; i < 100; i++)
                {
                    results[i] = new ResultContract() { Description = query, DisplayUrl = "xxx.com"+i.ToString(), Title = query, Url = "www.xxx.com" };
                }
            }
            return results;
        }

    }


    public class SearchResultController : Controller
    {
        public int pageSize = 4;
        private ResultRepository resultRepository;

        //Have to use interface and mock
        public SearchResultController()
        {
            resultRepository = new ResultRepository();
        }


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
            return View(resultsListViewModel);
        }
    }
}
