using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AASD_BuisnessLayer.BuisnessLayer_Models.Abstract;
using AASD_BuisnessLayer.Entities;

namespace AASD_BuisnessLayer.BuisnessLayer_Models.Concrete.SearchBehaviors
{
    // FOr the time being any one of the search class is enough, we will deal with all the search related business functionality here. - Santosh
    class BingSearch : ISearchBehaviour
    {
        public IList<Result> RetrieveResults(Query request)
        {
            throw new NotImplementedException();
        }
    }
}
