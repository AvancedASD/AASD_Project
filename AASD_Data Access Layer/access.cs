using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AASD_Data_Access_Layer.DataProvider;

namespace AASD_Data_Access_Layer
{
    class access
    {
        static void Main(string[] args)
        {
            /*using (AASD_DBEntities aasd_DBEntities = new AASD_DBEntities() )
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
            Guid id = new Guid("3EEE7E3F-3484-4BCA-A80E-D6BF7788D201");
            Guid id1 = new Guid("30860d0c-4c24-4d95-b54b-22a09bdc9e94");
            AASD_DB_Result q = new AASD_DB_Result();
            q.Query_Id = id;
            q.Result_Id = id1;
            q.Display_Url = "www.display.com";
            q.Creation_TimeStamp= System.DateTime.Now;
            q.Description = "description";
            q.Result_Url = "www.request.com";
            q.Title = "Title";
            DataProvider.IDataProvider obj = (DataProvider.ResultRepository)(new ResultRepository());
            Console.WriteLine(((IResultData)obj).insertData(q));
            
            

        }
    }
}
