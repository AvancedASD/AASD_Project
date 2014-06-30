using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AASD_BuisnessLayer.BusinessGateways;
using AASD_BuisnessLayer.Entities;
using AASD_BuisnessLayer.Enumeration;

namespace AASD_BuisnessLayer.BuisnessLayer_Models.Abstract
{
    public abstract class SearchEngine : ISearchBehaviour, IFilterBehavior, IDisplayBehaviour
    {
        static bool added = false;

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
        public virtual IList<Filter> GetFilteredData(IList<Result> data, IList<String> context)
        {
            IList<Filter> filteredResults = new List<Filter>();
            foreach (Result re in data)
            {
                added = false;
                foreach (String a in context)
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

                //  Console.WriteLine("arun counter :" + counter);
                Console.WriteLine(re.Url + "\n" + re.ResultId + "\n" + re.ResulType + "\n" + re.QueryId + "\n" + re.Description);
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

            return result;
        }

    }
}
