using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AASD_BingAPIService.Class
{
    public class WebResultExt
    {
        /// <summary>
        /// This is the Id of the particular result record
        /// </summary>
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

    }
}
