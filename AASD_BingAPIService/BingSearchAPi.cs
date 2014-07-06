using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Globalization;

// Bing Search API code sample that demonstrates the Web service operation.
using AASD_BingAPIService.Class;
using System.Configuration;
using AAASD_TraceLayer.Concrete;
using NLog;

namespace AASD_BingAPIService
{
    public class BingSearchAPi
    {

        private static string AccountKey;
        private static string appName;


        private static BingSearchAPi instance;
        private static object syncRoot = new Object();


        public static BingSearchAPi Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new BingSearchAPi();
                    }
                }

                return instance;
            }
        }

        private BingSearchAPi()
        {
            AccountKey = ConfigurationSettings.AppSettings["API_Key"];
            appName = ConfigurationSettings.AppSettings["Application_Name"];
        }

        public IList<WebResultExt> MakeRequest(QueryExt request)
        {
            IList<WebResultExt> x = new List<WebResultExt>();
            try
            {
                AccountKey = "tSxQSyyi/+iW/7YUsMMYrtL6QVz9O7xxKdpMxXPQPvI=";

                string query = "Microsoft Products";

                // Create a Bing container.

                string rootUrl = "https://api.datamarket.azure.com/Bing/Search";

                var bingContainer = new BingSearchContainer(new Uri(rootUrl));

                // The market to use.

                string market = "en-us";

                // Configure bingContainer to use your credentials.

                bingContainer.Credentials = new NetworkCredential(AccountKey, AccountKey);

                // Build the query, limiting to 10 results.

                var webQuery =

                    bingContainer.Web(request.SearchQuery, request.Options, request.WebSearchOptions, request.Market, request.Adult, Convert.ToDouble(request.Latitude, CultureInfo.InvariantCulture), Convert.ToDouble(request.Longitude, CultureInfo.InvariantCulture), request.WebFileType);

                webQuery = webQuery.AddQueryOption("$top", 100);

                // Run the query and display the results.


                var webResults = webQuery.Execute();

                if (webResults != null)
                {
                    webResults.ToList<WebResult>().ForEach(result =>
                    {
                        x.Add(
                            new WebResultExt()
                            {
                                Description = result.Description,
                                QueryId = request.QueryId,
                                DisplayUrl = result.DisplayUrl,
                                Title = result.Title,
                                ResultId = result.ID,
                                Url = result.Url
                            });
                    });
                }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                LogWriter.Instance.writeException(Convert.ToString(this), Convert.ToString(this.GetType()), e.Message);
                throw e;
            }
            finally
            {
                LogWriter.Instance.writeTrace(Convert.ToString(this), Convert.ToString(this.GetType()), "tracing - AASD -BIng api_Layer- successful");
            }
            // This is the query expression.

            return x;
        }

    }
}