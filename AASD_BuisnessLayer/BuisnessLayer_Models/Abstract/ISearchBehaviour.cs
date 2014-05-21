using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AASD_BuisnessLayer.BuisnessLayer_Models.Abstract
{
    public interface ISearchBehaviour
    {
        Object GetResults(Object request);
    }
}
