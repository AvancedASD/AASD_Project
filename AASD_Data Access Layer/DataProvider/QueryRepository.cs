﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

//Created by Jegan Boopathy

namespace AASD_Data_Access_Layer.DataProvider
{
    /// <summary>
    /// 
    /// </summary>
    public class QueryRepository : IDataProvider
    {

        /// <summary>
        /// Insert records into the table
        /// </summary>
        /// <param name="queryData"></param>
        /// <returns></returns>
        public int insertData(object queryData)
        {
            try
            {
                Console.WriteLine((queryData));
                if (queryData == null || ((AASD_DB_Query)queryData).Query_Id == null
                    || ((AASD_DB_Query)queryData).Creation_Time == null
                    || ((AASD_DB_Query)queryData).Search_string == null)
                {
                    throw new ArgumentNullException("Empty input");
                }
                
                AASD_DBEntities1 queryObject = new AASD_DBEntities1();
                queryObject.AASD_DB_Query.Add((AASD_DB_Query)queryData);
                return queryObject.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        /// <summary>
        /// delete records in the table
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int deleteData(Guid id)
        {
            try
            {
                if (id == null)
                {
                    throw new ArgumentNullException("id");
                }
                AASD_DBEntities1 queryObject = new AASD_DBEntities1();
                AASD_DB_Result deleteResult = queryObject.AASD_DB_Result.Single(query => query.Query_Id == id);
                AASD_DB_Query deleteQuery = queryObject.AASD_DB_Query.Single(query => query.Query_Id == id);
                queryObject.AASD_DB_Result.Remove(deleteResult);
                queryObject.AASD_DB_Query.Remove(deleteQuery);
                return queryObject.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        /// <summary>
        /// Retrieve records from table
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IList<object> showData(Guid id)
        {
            try
            {
                IList<object> oo = new List<object>();
                if (id == null)
                {
                    throw new ArgumentNullException("id");
                }
                AASD_DBEntities1 queryObject = new AASD_DBEntities1();
                var query = (from q in queryObject.AASD_DB_Query
                             where q.Query_Id == id
                             select q).First();

                //Assigning query object values to Result Object
                AASD_DB_Query returnObject = new AASD_DB_Query();
                returnObject.Query_Id = query.Query_Id;
                returnObject.Search_string = query.Search_string;
                returnObject.Context = query.Context;
                returnObject.Creation_Time = query.Creation_Time;
                oo.Add(returnObject);
                return oo;

            }

            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
