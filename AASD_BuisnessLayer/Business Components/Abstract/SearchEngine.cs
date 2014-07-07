using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AASD_BuisnessLayer.BusinessGateways;
using AASD_BuisnessLayer.Entities;
using AASD_BuisnessLayer.Enumeration;
///Created by Arun
namespace AASD_BuisnessLayer.BuisnessLayer_Models.Abstract
{
    public abstract class SearchEngine : ISearchBehaviour, IFilterBehavior, IDisplayBehaviour
    {
        static bool added = false;
        static bool preAdded = false;

        /// <summary>
        /// Retrieves Result from the bing api
        /// </summary>
        /// <param name="request">Query parameters</param>
        /// <returns>Unfiltered results</returns>
        public virtual IList<Result> RetrieveResultsBing(Query request)
        {
            IList<Result> resultList = null;
            try
            {
                if (request != null)
                {
                    BusinessGateway businessGateway = new BusinessGateway();
                    resultList = new List<Result>();
                    resultList = businessGateway.ConsumingBingApi(request);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }

            return resultList;
        }

        /// <summary>
        /// Filters the data from the unfiltered data
        /// </summary>
        /// <param name="data"> unfiltered data set</param>
        /// <param name="context">context </param>
        /// <returns>Filtered results</returns>
        public virtual IList<Filter> GetFilteredData(IList<Result> data, Query request, IList<String> context)
        {
            IList<Filter> filteredResults = new List<Filter>();
            IList<string> newContextList = null;

            if (context != null && context.Count > 0)
            {
                newContextList = new List<string>();
                newContextList.Add(request.Context);
                context.ToList().ForEach(x =>
                {
                    newContextList.Add(!x.Contains(request.SearchQuery) ? (x) : (x.Replace(request.SearchQuery, "")));
                });

                newContextList.Remove("");
                //foreach (string s in newContextList)
                //{
                //    if (s.Equals("")) { newContextList.Remove(s); }
                //}

            }

            foreach (string a in newContextList)
            {
                added = false;
                foreach (Result re in data)
                {
                    if (re.Description.Contains(a) && added == false)
                    {
                        filteredResults.Add(new Filter()
                        {
                            Description = re.Description,
                            QueryId = re.QueryId,
                            ResultId = re.ResultId,
                            DisplayUrl = re.DisplayUrl,
                            Title = re.Title,
                            Url = re.Url,
                            ResulType = QueryResultType.Filtered
                        });
                        added = true;
                    }
                    else
                    {
                        Console.WriteLine("miss");

                    }
                }
            }

            return filteredResults;
        }

        /// <summary>
        /// Displays the desired results
        /// </summary>
        /// <param name="filteredResult">Filtered results</param>
        /// <returns>returns list of display data</returns>
        public virtual IList<Display> DisplayResults(IList<Filter> filteredResult)
        {
            IList<Display> result = null;

            if (filteredResult != null && filteredResult.Count > 0)
            {
                result = new List<Display>();
                foreach (Filter x in filteredResult)
                {
                    result.Add(new Display()
                    {
                        Description = x.Description,
                        Name = x.Title,
                        Title = x.Title,
                        URL = x.Url,
                    });
                }
            }

            return result;
        }

    }
}
