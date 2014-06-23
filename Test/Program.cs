﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AASD_BingAPIService;
using AASD_BuisnessLayer;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
//using AASD_ServiceLayer;
using Test.AASDServiceReference;
using Google.Apis.Freebase.v1;
using Google.Apis.Services;
using Google.Apis.Requests;
//using Newtonsoft.Json;
using System.IO;
using System.Text;
using RestSharp;

namespace Test
{
    class Program
    {

        public static string Serialize<T>(T obj)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            MemoryStream ms = new MemoryStream();
            serializer.WriteObject(ms, obj);
            string retVal = Encoding.UTF8.GetString(ms.ToArray());
            return retVal;
        }

        public static T Deserialize<T>(string json)
        {
            T obj = Activator.CreateInstance<T>();
            MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(json));
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(obj.GetType());
            obj = (T)serializer.ReadObject(ms);
            ms.Close();
            return obj;
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {


            //FreebaseService service = new FreebaseService(new BaseClientService.Initializer
            //{

            //});
            ////{ Key = Api_Key };
            //IClientService x = 
            //String query = "[{\"id\":null,\"name\":null,\"type\":\"/astronomy/planet\"}]";
            //FreebaseService.SearchRequest request = new FreebaseService.SearchRequest(query) ;
            //string response = request.MqlOutput(query);
            //Console.WriteLine(response);

            Console.WriteLine("Discovery API Sample");
            Console.WriteLine("====================");
            try
            {
                Program x = new Program();
                x.Run().Wait();
            }
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();



            //var service = new FreebaseService(new BaseClientService.Initializer
            //    {
            //        ApplicationName = "AASD_Name",
            //        ApiKey = Api_Key,
            //    });

            //// Run the request.
            //Console.WriteLine("Executing a list request...");
            //var result = await service.Apis.List().ExecuteAsync();

            //// Display the results.
            //if (result.Items != null)
            //{
            //    foreach (DirectoryList.ItemsData api in result.Items)
            //    {
            //        Console.WriteLine(api.Id + " - " + api.Title);
            //    }
            //}


            //using (AASDServiceClient client = new AASDServiceClient())
            //{
            //    RetrieveSearchRequest retrieveSearchRequest = new RetrieveSearchRequest();
            //    retrieveSearchRequest.Request = new QueryContract() { Query = "asas", Market = "en-us" };
            //    ResultContract[] lstResultContracts = client.RetrieveSearch(retrieveSearchRequest);

            //    Console.WriteLine(lstResultContracts[0].Title);
            //}
        }

        private async Task Run()
        {
            string Api_Key = "AIzaSyADil-IR-E-iqu9lCwP1a2DzjjU0jpMSVo";
            // Create the service.
            var service = new FreebaseService(new BaseClientService.Initializer
            {
                ApplicationName = "AASD_Name",
                ApiKey = Api_Key,
            });

            // Run the request.
            Console.WriteLine("Executing a list request...");
            FreebaseService.SearchRequest v = new FreebaseService.SearchRequest(service);
            string query = "{'id':Apple,'name':'Apple Product','type':'/Company'}";
            v.Query = query;
            //v.ExecuteAsync();
            //string p = v.Output;
            //string f = v.MqlOutput;
            var res = v.Execute();
            Newtonsoft.Json.Linq.JObject jObject = Newtonsoft.Json.Linq.JObject.Parse(res);
            DataResult x = Deserialize<DataResult>(res);
            //var x = jObject.status;

            x.result.ForEach(y =>
            {
                Console.WriteLine(y.name);
            });


            // Display the results.
            //if (result.Items != null)
            //{
            //    foreach (DirectoryList.ItemsData api in result.Items)
            //    {
            //        Console.WriteLine(api.Id + " - " + api.Title);
            //    }
            //}
        }

        //private async Task Run()
        //{
        //    var client = new RestClient();
        //    client.BaseUrl = "https://www.freebase.com/api/service/mqlread";
        //    var request = new RestRequest(Method.GET);
        //    Query q = new Query() { name = "Germany", type = "/Country" };
        //    string js = q.ToJsonString();
        //    request.AddParameter("query", js);
        //    request.RequestFormat = DataFormat.Json;
        //    RestResponse response = (RestResponse)client.Execute(request);
        //    Console.WriteLine("My output :" + "\n" + response.Content);

        //}

    }
}
