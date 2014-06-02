using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AASD_BingAPIService;
using AASD_BuisnessLayer;
//using AASD_ServiceLayer;
using Test.AASDServiceReference;

namespace Test
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            using (AASDServiceClient client = new AASDServiceClient())
            {
                RetrieveSearchRequest retrieveSearchRequest = new RetrieveSearchRequest();
                retrieveSearchRequest.Request = new QueryContract() { Query = "asas" };
                ResultContract[] lstResultContracts = client.RetrieveSearch(retrieveSearchRequest);
                Console.WriteLine(lstResultContracts[0].Title);
            }
        }
    }
}
