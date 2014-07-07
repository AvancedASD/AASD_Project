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
using AAASD_TraceLayer;
using AAASD_TraceLayer.Concrete;
using AASD_Data_Access_Layer.DataProvider;
using AASD_Data_Access_Layer;
using AASD_BuisnessLayer.Enumeration;
using System.Data.SqlClient;
using System.Dynamic;
///Created by Arun
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
            catch (Exception e)
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


        private dynamic SqlDataReaderToExpando(SqlDataReader reader)
        {
            var expandoObject = new ExpandoObject() as IDictionary<string, object>;

            for (var i = 0; i < reader.FieldCount; i++)
                expandoObject.Add(reader.GetName(i), reader[i]);

            return expandoObject;
        }

        private IEnumerable<dynamic> GetDynamicSqlData(string connectionstring, string sql)
        {
            using (var conn = new SqlConnection(connectionstring))
            {
                using (var comm = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    using (var reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return SqlDataReaderToExpando(reader);
                        }
                    }
                    conn.Close();
                }
            }
        }

        #region comment
        /*
        public IEnumerable<T> RetrievingUnfilteredResult<T>(Query request)
        {
            var properties = typeof(T).GetProperties();
            string connnectionString = "Data Source=PINTU-THINK\\PINTU;Initial Catalog=AASD_DB;Persist Security Info=True;User ID=sa;Password=sa;MultipleActiveResultSets=True;App=EntityFramework";
            string retrievalQuery = "select * from [dbo].[AASD_DB_Result] where Query_Id =" + request.QueryId;
            using (var conn = new SqlConnection(connnectionString))
            {
                using (var comm = new SqlCommand(retrievalQuery, conn))
                {
                    conn.Open();
                    using (var reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var element = Activator.CreateInstance<T>();

                            foreach (var f in properties)
                            {
                                var o = reader[f.Name];
                                if (o.GetType() != typeof(DBNull)) f.SetValue(element, o, null);
                            }
                            yield return element;
                        }
                    }
                    conn.Close();
                }
            }
        }
        */
        #endregion

        public IList<Result> RetrievingUnfilteredResult(Query request)
        {

            IList<Result> unFilteredResults = new List<Result>();
            IList<object> op = null;
        


            try
            {
                Console.WriteLine("retrieve results method new");
                //calling DB
                IDataProvider dataobjret = (ResultRepository)(new ResultRepository());

                // IResultData retresobj = new ResultRepository();
                op = ((IResultData)dataobjret).showData(request.QueryId);
                foreach (AASD_DB_Result o in op)
                {
                    Result r = new Result()
                    {
                        ResultId = o.Result_Id,
                        QueryId = o.Query_Id,
                        DisplayUrl = o.Display_Url,
                        Title = o.Title,
                        Description = o.Description,
                        Url = o.Result_Url,
                        ResulType = QueryResultType.Unfiltered
                    };
                    unFilteredResults.Add(r);

                }

            }
            catch (Exception)
            {

                throw;
            }
            finally { }

            return unFilteredResults;


        }

        public bool PersistResultsToDB(Query q, IList<Result> unfilteredList)
        {
            bool queryResponse = false;
            bool resultResponse = false;

            #region comment
            #endregion

            ////throw new NotImplementedException();
            //// IData
            int res1;
            int res2;
            Console.WriteLine("isnide persist");
            try
            {
                IDataProvider queryobj = (QueryRepository)(new QueryRepository());
                IDataProvider dataobj = (ResultRepository)(new ResultRepository());

                // IQueryData queryobj = new QueryRepository();
                //QueryforDB ap = new QueryforDB();
                AASD_DB_Query ap = new AASD_DB_Query();

                ap.Context = q.Context;
                ap.Query_Id = q.QueryId;
                ap.Search_string = q.SearchQuery;
                ap.Creation_Time = System.DateTime.Now;
                res1 = ((IQueryData)queryobj).insertData(ap);
                // IResultData dataobj = new ResultRepository();
                foreach (Result r in unfilteredList)
                {

                    AASD_DB_Result resdbobj = new AASD_DB_Result()
                    {
                        Query_Id = q.QueryId,
                        Result_Id = r.ResultId,
                        // Display_Url =du,
                        Display_Url = r.DisplayUrl,
                        Creation_TimeStamp = System.DateTime.Now,
                        Description = r.Description,
                        //Result_Url = ru,
                        Result_Url = r.Url,
                        //if(r.Title.Length>50)
                        //Title = titl
                        Title = r.Title
                        // else
                        //   Title=r.Title


                    };


                    res2 = ((IResultData)dataobj).insertData(resdbobj);

                }
            }
            catch (Exception e)
            {
                throw e;
            }
            if (res1 == 1)
                return true;
            else
                return false;
            
        }
    }
}
