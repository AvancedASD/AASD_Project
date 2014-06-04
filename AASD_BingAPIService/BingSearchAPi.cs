using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Globalization;

// Bing Search API code sample that demonstrates the Web service operation.
using AASD_BingAPIService.Class;

namespace AASD_BingAPIService
{
    public static class BingSearchAPi
    {

        // Replace this value with your account key.

        private const string AccountKey = "tSxQSyyi/+iW/7YUsMMYrtL6QVz9O7xxKdpMxXPQPvI=";

        //private static void Main(string[] args)
        //{

        //    try
        //    {

        //        MakeRequest();

        //    }

        //    catch (Exception ex)
        //    {

        //        string innerMessage =

        //            (ex.InnerException != null)
        //                ? ex.InnerException.Message
        //                : String.Empty;

        //        Console.WriteLine("{0}\n{1}", ex.Message, innerMessage);

        //    }

        //}

        public static IList<WebResultExt> MakeRequest(QueryExt request)
        {
            // This is the query expression.

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

            IList<WebResultExt> x = new List<WebResultExt>();
            var webResults = webQuery.Execute();

            if (webResults.Count() > 0 && webResults != null)
            {

                foreach (var result in webResults)
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
                        }
                        );

                    Console.WriteLine("{0}\n\t{1}\n\n", result.Title, result.Url, result.Description);

                }
            }

            Console.ReadLine();
            return x;
        }

    }
}