using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AASD_BuisnessLayer.BuisnessLayer_Models.Abstract;

namespace AASD_BuisnessLayer.BuisnessLayer_Models.Concrete.FilterBehaviors
{
    //This is just an example. Later we can delete this filter and create new filters
    class DuplicateDataFilter : IFilterBehavior
    {
        //Delete duplicate data
        public object GetFilteredData(object data)
        {
            throw new NotImplementedException();
        }
    }
}
