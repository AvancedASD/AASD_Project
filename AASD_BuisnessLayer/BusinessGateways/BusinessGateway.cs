using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AASD_BingAPIService;
using AASD_BingAPIService.Class;
using AASD_BuisnessLayer.Entities;


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
                xExt = BingSearchAPi.MakeRequest(ext);

                if (xExt.Count > 0 && xExt != null)
                {
                    //Translate back
                }

            }

            return resultEntity;
        }
    }
}
