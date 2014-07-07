using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AASD_BuisnessLayer.Enumeration;
///Created by Arun
namespace AASD_BuisnessLayer.Entities
{
    /// <summary>
    /// This class contains the details of search query ( Will update this class later . Have some doubt for the time being)
    /// </summary>
    public class Filter
    {
        /// <summary>
        ///Bing search query Sample Values : xbox
        /// </summary>
        // public string Description { get; set; }

        /// <summary>
        ///Bing search query Sample Values : xbox
        /// </summary>
        // public string Name { get; set; }

        /// <summary>
        ///Bing search query Sample Values : xbox
        /// </summary>
        // public string Title { get; set; }
        public Guid ResultId { get; set; }

        /// <summary>
        /// mapped to a particular Query Search
        /// </summary>
        public Guid QueryId { get; set; }

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
