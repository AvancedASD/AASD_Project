using System;

using System.Net;

// Bing Search API code sample that demonstrates the Web service operation.

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

        public static void MakeRequest()
        {
            //try
            //{

            //}
            //catch (Exception)
            //{

            //    throw;
            //}

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

                bingContainer.Web(query, null, null, market, null, null, null, null);

            webQuery = webQuery.AddQueryOption("$top", 100);

            // Run the query and display the results.

            var webResults = webQuery.Execute();

            foreach (var result in webResults)
            {

                Console.WriteLine("{0}\n\t{1}\n\n", result.Title, result.Url, result.Description);

            }

            Console.ReadLine();

        }

    }
}