using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
///Created by Santosh
namespace AASD_BuisnessLayer.Entities
{
    /// <summary>
    /// This class contains the details of search query
    /// </summary>
    public class Query
    {
        /// <summary>
        ///Search ID mapped to a particular search
        /// </summary>
        public Guid QueryId { get; set; }

        /// <summary>
        ///Search ID mapped to a particular search
        /// </summary>
        public string Context { get; set; }

        /// <summary>
        ///Bing search query Sample Values : xbox
        /// </summary>
        public string SearchQuery { get; set; }

        /// <summary>
        /// Specifies options for this request for all Sources. Valid values are: DisableLocationDetection, EnableHighlighting. Sample Values : EnableHighlighting
        /// </summary>
        public string Options { get; set; }

        /// <summary>
        /// Specify options for a request to the Web SourceType. Valid values are: DisableHostCollapsing, DisableQueryAlterations. Sample Values : DisableQueryAlterations
        /// </summary>
        public string WebSearchOptions { get; set; }

        /// <summary>
        /// Market. Note: Not all Sources support all markets. Sample Values : en-US
        /// </summary>
        public string Market { get; set; }

        /// <summary>
        /// Adult setting is used for filtering sexually explicit content Sample Values : Moderate
        /// </summary>
        public string Adult { get; set; }

        /// <summary>
        /// Latitude Sample Values : 47.603450
        /// </summary>
        public string Latitude { get; set; }

        /// <summary>
        /// Longitude Sample Values : -122.329696
        /// </summary>
        public string Longitude { get; set; }

        /// <summary>
        /// File extensions to return Sample Values : XLS
        /// </summary>
        public string WebFileType { get; set; }

    }
}
