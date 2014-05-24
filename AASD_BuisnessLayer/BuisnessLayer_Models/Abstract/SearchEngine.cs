using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AASD_BuisnessLayer.Entities;

namespace AASD_BuisnessLayer.BuisnessLayer_Models.Abstract
{
    abstract class SearchEngine
    {
        private IFilterBehavior _filter = null;
        private ISearchBehaviour _search = null;

        public IFilterBehavior filter { get { return _filter; } set { _filter = value; } }
        public ISearchBehaviour search { get { return _search; } set { _search = value; } }

        public SearchEngine(IFilterBehavior filter, ISearchBehaviour search)
        {
            _filter = filter;
            _search = search;
        }

        public Object FilterData(IList<Result> data)
        {
            Object filteredData = _filter.GetFilteredData(data);
            return filteredData;
        }

        public Object GetResults(Query request)
        {
            Object result = _search.RetrieveResults(request);
            return result;
        }
    }
}
