using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AASD_DataTransferObject.DTOs;
using AASD_BuisnessLayer.Entities;
using AASD_BuisnessLayer.Enumeration;

namespace AASD_DataTransferObject.Translators
{
    /// <summary>
    /// It translates the Entity to DTO and vica-versa 
    /// </summary>
    public class SearchEngineTranslator
    {
        public QueryDto QueryResultsEntityToDto(QueryDetails entity)
        {
            QueryDto x = null;

            if (entity != null)
            {
                x = new QueryDto()
                {
                    searchQuery = entity.SearchQuery,
                };
            }

            return x;
        }
    }
}
