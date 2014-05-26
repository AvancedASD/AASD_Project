using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AASD_BuisnessLayer.BuisnessLayer_Models.Abstract;

namespace AASD_BuisnessLayer.BuisnessLayer_Models.Concrete.SearchEngines
{
    //Later we can add some sepcific functionality
    class SearchEngine_Standart : SearchEngine
    {
        public SearchEngine_Standart(IFilterBehavior filter, ISearchBehaviour search) :
            base(filter, search) { }
    }
}
