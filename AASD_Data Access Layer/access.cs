using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            DataProvider.IDALShowData obj =  (new DataProvider.DALShowData());
            obj.selectQueryData();
            
            

        }
    }
}
