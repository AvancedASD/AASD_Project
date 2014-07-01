using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using AASD_FreeBaseApiServiceAgent.DataContractJSon;
//using Google.Apis.Freebase.v1;
//using Google.Apis.Services;
//using Google.Apis.Requests;
using Freebase4net;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Dynamic;
using AAASD_TraceLayer.Concrete;

namespace AASD_FreeBaseApiServiceAgent
{
    public class FreeBaseAPI
    {

        private static string apiKey;
        private static string appName;


        private static FreeBaseAPI instance;
        private static object syncRoot = new Object();


        public static FreeBaseAPI Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new FreeBaseAPI();
                    }
                }

                return instance;
            }
        }

        private FreeBaseAPI()
        {
            //apiKey = ConfigurationSettings.AppSettings["API_Key"];
            //appName = ConfigurationSettings.AppSettings["Application_Name"];
        }


        public DataResultFreeBase GetFreeBaseServiceResults(string query, string context)
        {
            DataResultFreeBase obj = null;
            try
            {
                FreebaseServices.SetApiKey("AIzaSyADil-IR-E-iqu9lCwP1a2DzjjU0jpMSVo");
                SearchService searchService = FreebaseServices.CreateSearchService();
                SearchServiceResponse result = null;
                result = searchService.Read(query, "", "", false, "", "", false, false, 50, "", false, 0, context, ""); ;
                //get status
                var content = result.ResultAsString;
                var status = result.Status;
                obj = CommonUtility.Deserialize<DataResultFreeBase>(content);
            }
            catch (Exception e)
            {
                LogWriter.Instance.writeException(Convert.ToString(this), Convert.ToString(this.GetType()), e.Message);
                throw e;
            }
            finally
            {
                LogWriter.Instance.writeTrace(Convert.ToString(this), Convert.ToString(this.GetType()), "tracing - AASD- Freebase Agent- successful");
            }

            return obj;
        }

    }
}
