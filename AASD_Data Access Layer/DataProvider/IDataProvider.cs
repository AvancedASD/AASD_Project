using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Created by Jegan Boopathy

namespace AASD_Data_Access_Layer.DataProvider
{
    /// <summary>
    /// Common interface for Dependency inversion principle which will be invoked by Busineess Gateway in Business Layer
    /// </summary>
  public  interface IDataProvider : IQueryData, IResultData
    {
        
    }
}
