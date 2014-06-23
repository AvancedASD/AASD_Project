using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using FreeBaseApiServiceAgent.DataContractJSon;
using Google.Apis.Freebase.v1;
using Google.Apis.Services;
using Google.Apis.Requests;
using System.IO;
using System.Runtime.Serialization.Json;

namespace FreeBaseApiServiceAgent
{
    public class FreeBaseAPI
    {

        private static string apiKey;
        private static string appName;


        private static volatile FreeBaseAPI instance;
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
            apiKey = ConfigurationSettings.AppSettings["API_Key"];
            appName = ConfigurationSettings.AppSettings["Application_Name"];

        }


        public static T GetFreebaseServiceResults<T>(string query, string context)
        {
            // Create the service.
            var service = new FreebaseService(new BaseClientService.Initializer
            {
                ApplicationName = appName,
                ApiKey = apiKey,
            });

            // Run the request.
            Console.WriteLine("Executing a list request...");
            FreebaseService.SearchRequest v = new FreebaseService.SearchRequest(service);
            string queryJson = "{'id':" + query + ",'name':" + query + ",'type':/" + context + "}";
            v.Query = queryJson;
            var res = v.Execute();
            Newtonsoft.Json.Linq.JObject jObject = Newtonsoft.Json.Linq.JObject.Parse(res);
            //DataResultFreeBase x = CommonUtility.Deserialize<DataResultFreeBase>(res);

            //Desearilizing (json string to Object)
            T obj = Activator.CreateInstance<T>();
            MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(res));
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            obj = (T)serializer.ReadObject(ms);
            ms.Close();
            //obj.result.ForEach(y =>
            //{
            //    Console.WriteLine(y.name);
            //});
            return obj;
        }

    }
}
