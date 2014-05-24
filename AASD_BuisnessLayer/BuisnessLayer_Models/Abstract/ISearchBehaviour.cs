using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AASD_BuisnessLayer.Entities;

namespace AASD_BuisnessLayer.BuisnessLayer_Models.Abstract
{
    public interface ISearchBehaviour
    {
        /// <summary>
        /// Retrieves the Result from Bing API
        /// </summary>
        /// <param name="request">Formed Query </param>
        /// <returns>List of Results</returns>
         IList<Result> RetrieveResults(Query request);
    }
}
