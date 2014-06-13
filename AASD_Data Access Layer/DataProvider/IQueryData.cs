using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AASD_Data_Access_Layer.DataProvider;

namespace AASD_Data_Access_Layer.DataProvider
{
    interface IQueryData
    {
        int insertData(object queryObject);
       // int updateData(AASD_DB_Query queryObject);
        int deleteData(Guid id);
        object showData(Guid id);

    }
}
