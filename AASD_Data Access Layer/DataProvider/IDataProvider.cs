using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AASD_Data_Access_Layer.DataProvider
{
    interface IDataProvider : IDALShowData, IDALSaveData, IDALDeleteData
    {
        /*
         void insertQueryData();
          void insertResultData();
          void updateQueryData();
          void updateResultData();
          void deleteQueryData();
          void deleteResultData();
          AASD_DB_Query selectQueryData();
          AASD_DB_Result selectResultData();
          
        */
    }
}
