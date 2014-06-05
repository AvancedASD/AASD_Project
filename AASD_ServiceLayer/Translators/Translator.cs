using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AASD_BuisnessLayer;
using AASD_BuisnessLayer.Entities;
using AASD_ServiceLayer;
using AASD_ServiceLayer.DataContract;
using AASD_ServiceLayer.MessageContract;

namespace AASD_ServiceLayer.Translators
{
    public static class Translator
    {
        public static Query ConvertQueryContractTOEntity(RetrieveSearchRequest1 contract)
        {
            Query entity = null;

            if (contract != null)
            {
                entity = new Query()
                {
                    SearchQuery = contract.RetrieveSearchRequest.Request.Query,
                    Adult = contract.RetrieveSearchRequest.Request.Adult,
                    Latitude = contract.RetrieveSearchRequest.Request.Latitude,
                    Longitude = contract.RetrieveSearchRequest.Request.Longitude,
                    Market = contract.RetrieveSearchRequest.Request.Market,
                    Options = contract.RetrieveSearchRequest.Request.Options,
                    QueryId = Guid.NewGuid(),
                    WebFileType = contract.RetrieveSearchRequest.Request.WebFileType,
                    WebSearchOptions = contract.RetrieveSearchRequest.Request.WebSearchOptions
                };
            }

            return entity;
        }

        public static List<DataContract.ResultContract> ConvertResultEntityToContract(IList<Result> entityList)
        {
            List<ResultContract> contractList = null;

            if (entityList != null && entityList.Count > 0)
            {
                contractList = new List<ResultContract>();
                entityList.ToList().ForEach(x =>
                {
                    contractList.Add(new ResultContract()
                    {
                        Description = x.Description,
                        DisplayUrl = x.DisplayUrl,
                        Title = x.Title,
                        Url = x.Url
                    });

                });
            }

            return contractList;
        }
    }
}