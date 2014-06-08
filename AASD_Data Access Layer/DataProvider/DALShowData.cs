using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AASD_Data_Access_Layer.DataProvider
{
    class DALShowData : IDALShowData
    {
        public AASD_DB_Query selectQueryData()
        {
            AASD_DBEntities queryObject = new AASD_DBEntities();
            IEnumerable<AASD_DB_Query> query = from q in queryObject.AASD_DB_Query
                                               select q;
            //Console.WriteLine(query);
          /*  AASD_DB_Query qObj = new AASD_DB_Query();
            qObj.Query_Id = Guid.NewGuid();
            foreach (var res in query)
            {
                qObj = (AASD_DB_Query)res;
                Console.WriteLine("ID: " + qObj);
            }
            */
            return (AASD_DB_Query)query;
        }
        public AASD_DB_Result selectResultData()
        {
            AASD_DBEntities resultObject = new AASD_DBEntities();
            IEnumerable<AASD_DB_Result> query = from q in resultObject.AASD_DB_Result
                                               select q;
            return (AASD_DB_Result)query;
        }
    }
}
