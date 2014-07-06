using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace AASD_Data_Access_Layer.DataProvider
{
    public class ResultRepository : IDataProvider
  //  public class ResultRepository : IResultData
    {

        public int insertData(object resultData)
        {
            try
            {
                if (resultData == null || ((AASD_DB_Result)resultData).Query_Id == null 
                    || ((AASD_DB_Result)resultData).Result_Id == null 
                    || ((AASD_DB_Result)resultData).Creation_TimeStamp == null)
                {
                    throw new ArgumentNullException("Empty input");
                }

                AASD_DBEntities resultObject = new AASD_DBEntities();
                resultObject.AASD_DB_Result.Add(((AASD_DB_Result)resultData));
                return resultObject.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
                Console.WriteLine(dbEx);
                throw dbEx;
            }
        }

      /*  public int updateData()
        {
            throw new NotImplementedException();
        }
       * */

        public int deleteData(Guid id)
        {
            
            try
            {
                
                if (id == null)
                {
                    throw new ArgumentNullException("id");
                }

                AASD_DBEntities resultObject = new AASD_DBEntities();
                AASD_DB_Result deleteResult = resultObject.AASD_DB_Result.Single(query => query.Result_Id == id);
                resultObject.AASD_DB_Result.Remove(deleteResult);
                return resultObject.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<object> showData(Guid id)
        {
            IList<object> retresobj=new List<object>();
            try
            {
                if (id == null)
                {
                    throw new ArgumentNullException("id");
                }
                AASD_DBEntities resultObject = new AASD_DBEntities();
               // var query = (from q in resultObject.AASD_DB_Result
                           //  where q.Query_Id == id
                            // select q).First();
                 var querys = (from q in resultObject.AASD_DB_Result
                             where q.Query_Id == id
                             select q);
                 Console.WriteLine("inside showData results");
                 Console.WriteLine("querys" + querys);
                //Assigning query object values to Result Object 
                foreach (var query in querys)
                {
                     AASD_DB_Result returnObject = new AASD_DB_Result();
                    
                         returnObject.Query_Id = query.Query_Id;
                         returnObject.Result_Id = query.Result_Id;
                         returnObject.Title = query.Title;
                         returnObject.Display_Url = query.Display_Url;
                         returnObject.Result_Url = query.Result_Url;
                         returnObject.Description = query.Description;
                         returnObject.Creation_TimeStamp = query.Creation_TimeStamp;
                         Console.WriteLine(returnObject.Display_Url);
                     
                     retresobj.Add(returnObject);
                 }

                 Console.ReadLine();
                return retresobj;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
