using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AASD_Data_Access_Layer.DataProvider;

namespace AASD_Data_Access_Layer.DataProvider
{
   public interface IResultData 
    {
         int insertData(object resultObject);
       // int updateData(AASD_DB_Result resultObject);
        int deleteData(Guid id);
        IList<object> showData(Guid id);

    }
}
