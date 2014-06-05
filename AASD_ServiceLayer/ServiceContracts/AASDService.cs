using System;
using System.Collections.Generic;
using System.Web.UI.MobileControls;
using AASD_BuisnessLayer.BuisnessLayer_Models.Concrete.SearchBehaviors;
using AASD_BuisnessLayer.Entities;
using AASD_ServiceLayer.DataContract;
using AASD_ServiceLayer.MessageContract;
using AASD_ServiceLayer.Translators;
using AASD_BuisnessLayer;

namespace AASD_ServiceLayer
{


    [System.ServiceModel.ServiceBehaviorAttribute(InstanceContextMode = System.ServiceModel.InstanceContextMode.PerCall, ConcurrencyMode = System.ServiceModel.ConcurrencyMode.Single)]
    public class AASDService : IAASDService
    {

        public virtual RetrieveSearchResponse RetrieveSearch(RetrieveSearchRequest1 request)
        {
            RetrieveSearchResponse retrieveSearchResponse = null;
            List<ResultContract> lstResult = null;

            try
            {
                if (request.RetrieveSearchRequest != null)
                {

                    BingSearch bingSearch = new BingSearch();
                    IList<Result> resultListEntity =
                        bingSearch.RetrieveResults(Translators.Translator.ConvertQueryContractTOEntity(request));
                    lstResult = Translator.ConvertResultEntityToContract(resultListEntity);

                    retrieveSearchResponse = new RetrieveSearchResponse();
                    retrieveSearchResponse.listResultContract = lstResult;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
            }
            
            return retrieveSearchResponse;
        }
    }
}
