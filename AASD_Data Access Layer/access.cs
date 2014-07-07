using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AASD_Data_Access_Layer.DataProvider;

//Created by Jegan Boopathy

namespace AASD_Data_Access_Layer
{
    class access
    {
        static void Main(string[] args)
        {
            /*using (AASD_DBEntities1 aasd_DBEntities = new AASD_DBEntities1() )
            {
                var l = from e in aasd_DBEntities.AASD_DB_Query
                        select e;
                foreach (var res in l)
                {
                    Console.WriteLine("ID: " + res.Query_Id);
                }
                Console.ReadLine();
            }
            */
            Guid id = Guid.NewGuid();
            //Guid id1 = new Guid("30860d0c-4c24-4d95-b54b-22a09bdc9e94");
            //AASD_DB_Result q = new AASD_DB_Result();
          
            //q.Query_Id = id;
            //q.Result_Id = id1;
            /*q.Display_Url = "www.display.com";
            q.Creation_TimeStamp= System.DateTime.Now;
            q.Description = "description";
            q.Result_Url = "www.request.com";
            q.Title = "Title";*/
            AASD_DB_Query q = new AASD_DB_Query();
            q.Creation_Time = System.DateTime.Now;
            q.Context = "music";
            q.Search_string = "Germany";
            q.Query_Id = id;
            //DataProvider.IDataProvider obj = (DataProvider.ResultRepository)(new ResultRepository());
            DataProvider.IDataProvider obj = (DataProvider.QueryRepository)(new QueryRepository());
            Console.WriteLine(((IQueryData)obj).insertData(q));
            
            

        }
    }
}
