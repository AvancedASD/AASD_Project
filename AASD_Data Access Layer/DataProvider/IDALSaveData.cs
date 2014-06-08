using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AASD_Data_Access_Layer.DataProvider
{
    interface IDALSaveData
    {
        void insertQueryData();
        void insertResultData();
        void updateQueryData();
        void updateResultData();
    }
}
