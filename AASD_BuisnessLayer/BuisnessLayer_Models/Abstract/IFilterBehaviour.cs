﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AASD_BuisnessLayer.Entities;

namespace AASD_BuisnessLayer.BuisnessLayer_Models.Abstract
{
    public interface IFilterBehavior
    {
        IList<Filter> GetFilteredData(IList<Result> data);
    }
}
