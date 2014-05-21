using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AASD_BuisnessLayer.BuisnessLayer_Models.Abstract;


namespace AASD_BuisnessLayer.BuisnessLayer_Models.Concrete.FilterBehaviors
{
    //This is just an example. Later we can delete this filter and create new filters- IVAN
    // FOr the time being any one of the search class is enough, we will deal with all the Filter related business functionality here. - Santosh
    class DateFilter : IFilterBehavior
    {
        //Delete old data
        public object GetFilteredData(object data)
        {
            throw new NotImplementedException();
        }
    }
}
