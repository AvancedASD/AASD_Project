using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AASD_WebUI.ServiceReference_Search;

namespace AASD_WebUI.Models
{
    public class ResultListViewModel
    {
        public IEnumerable<ResultContract> results { get; set; }
        public PagingInfo pagingInfo { get; set; }
        public QueryViewModel currentQuery { get; set; }
    }
}