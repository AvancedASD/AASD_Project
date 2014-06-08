using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AASD_Data_Access_Layer.DataProvider
{
    interface IDALShowData
    {
        AASD_DB_Query selectQueryData();
        AASD_DB_Result selectResultData();
    }
}
