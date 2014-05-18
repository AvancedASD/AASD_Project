using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AASD_BuisnessLayer.BuisnessLayer_Models.Abstract
{
    interface ISearchBehaviour
    {
        public Object GetResults(Object request);
    }
}
