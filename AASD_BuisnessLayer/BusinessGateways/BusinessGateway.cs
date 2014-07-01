using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AASD_BingAPIService;
using AASD_BingAPIService.Class;
using AASD_BuisnessLayer.Entities;
using AASD_FreeBaseApiServiceAgent;
using AASD_FreeBaseApiServiceAgent.DataContractJSon;
using AD = AASD_Data_Access_Layer;

namespace AASD_BuisnessLayer.BusinessGateways
{
    /// <summary>
    /// This helps Connect to different  layer and all necessary translation happens here
    /// </summary>
    public class BusinessGateway
    {
        public IList<Result> ConsumingBingApi(Query request)
        {
            IList<Result> resultEntity = null;
            try
            {
                if (request != null)
                {
                    QueryExt ext = new QueryExt()
                    {
                        QueryId = request.QueryId,
                        Market = request.Market,
                        Options = request.Options,
                        SearchQuery = request.SearchQuery,
                        Adult = request.Adult,
                        Latitude = request.Latitude,
                        Longitude = request.Longitude,
                        WebFileType = request.WebFileType,
                        WebSearchOptions = request.WebSearchOptions
                    };
                    IList<WebResultExt> xExt = new List<WebResultExt>();
                    xExt = BingSearchAPi.Instance.MakeRequest(ext);

                    if (xExt.Count > 0 && xExt != null)
                    {
                        resultEntity = new List<Result>();
                        xExt.ToList<WebResultExt>().ForEach(x =>
                        {
                            resultEntity.Add(new Result()
                            {
                                Description = x.Description,
                                DisplayUrl = x.DisplayUrl,
                                QueryId = x.QueryId,
                                ResultId = x.ResultId,
                                Title = x.Title,
                                Url = x.Url,
                            });
                        });
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }

            return resultEntity;
        }

        public IList<string> ConsumingFreeBaseApi(Query request)
        {
            IList<string> contextList = null;
            try
            {
                DataResultFreeBase dataResultFreeBase = FreeBaseAPI.Instance.GetFreeBaseServiceResults(request.SearchQuery, request.Context);
                if (dataResultFreeBase != null && dataResultFreeBase.result != null && dataResultFreeBase.result.Count > 0)
                {
                    contextList = new List<string>();
                    dataResultFreeBase.result.ForEach(x =>
                    {
                        contextList.Add(x.name);
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            return contextList;
        }

        public IList<Result> RetrievingUnfilteredResult(Query request)
        {
            IList<Result> unFilteredResults = null;

            try
            {
                //calling DB
            }
            catch (Exception)
            {

                throw;
            }
            finally { }

            return unFilteredResults;


        }

        public bool PersistResultsToDB(IList<Result> unfilteredList)
        {
            throw new NotImplementedException();
        }
    }
}
