using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AASD_Data_Access_Layer.DataProvider
{
    class QueryData : IDataProvider
    {
        
        public int insertData(object queryData)
        {
            try
            {
                if (queryData == null || ((AASD_DB_Query)queryData).Query_Id == null 
                    || ((AASD_DB_Query)queryData).Creation_Time == null
                    || ((AASD_DB_Query)queryData).Search_string == null)
                {
                    throw new ArgumentNullException("Empty input");
                }
                AASD_DBEntities queryObject = new AASD_DBEntities();
                queryObject.AASD_DB_Query.Add((AASD_DB_Query)queryData);
                return queryObject.SaveChanges();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

      
        /*
         * public int updateData()
        {
            throw new NotImplementedException();
        }
         * */

        public int deleteData(Guid id )
        {
            try
            {
                if (id == null)
                {
                    throw new ArgumentNullException("id");
                }
                AASD_DBEntities queryObject = new AASD_DBEntities();
                AASD_DB_Result deleteResult = queryObject.AASD_DB_Result.Single(query => query.Query_Id == id);
                AASD_DB_Query deleteQuery = queryObject.AASD_DB_Query.Single(query => query.Query_Id == id);
                queryObject.AASD_DB_Result.Remove(deleteResult);
                queryObject.AASD_DB_Query.Remove(deleteQuery);
                return queryObject.SaveChanges();
             }
            catch(Exception e)
            {
                throw e;
            }
        }

        public object showData(Guid id)
        {
            try
            {
                if (id == null)
                {
                    throw new ArgumentNullException("id");
                }
                AASD_DBEntities queryObject = new AASD_DBEntities();
                var query = (from q in queryObject.AASD_DB_Query
                             where q.Query_Id == id
                             select q).First();
                return (AASD_DB_Query)query;
            }

            catch (Exception e) 
            {
                throw e;
            }
        }
    }
}
