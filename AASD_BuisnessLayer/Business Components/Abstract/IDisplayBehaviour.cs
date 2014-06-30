using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AASD_BuisnessLayer.Entities;

namespace AASD_BuisnessLayer.BuisnessLayer_Models.Abstract
{
    public interface IDisplayBehaviour
    {
        /// <summary>
        /// Display the Result from filter result
        /// </summary>
        /// <param name="request">Formed Query </param>
        /// <returns>List of Display Results</returns>
        IList<Display> DisplayResults(IList<Filter> filteredResult);
    }
}
