using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AASD_BuisnessLayer.Enumeration;

namespace AASD_BuisnessLayer.Entities
{
    /// <summary>
    /// This class contains a particular result record obtained from a search query results
    /// </summary>
    public class QueryResult
    {
        /// <summary>
        /// This is the Id of the particular result record
        /// </summary>
        public Guid ResultID { get; set; }

        /// <summary>
        /// mapped to a particular Query Search
        /// </summary>
        public Guid QueryID { get; set; }

        /// <summary>
        /// This contains the title of the result
        /// </summary>
        public String Title { get; set; }

        /// <summary>
        /// Description of the result record
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// Display url of the result record (e.g: without http)
        /// </summary>
        public String DisplayUrl { get; set; }

        /// <summary>
        /// Display url of the result record (e.g: with http)
        /// </summary>
        public String Url { get; set; }

        /// <summary>
        /// Says whether filtered or Unfiltere data 
        /// </summary>
        public QueryResultType ResulType { get; set; }

    }
}
