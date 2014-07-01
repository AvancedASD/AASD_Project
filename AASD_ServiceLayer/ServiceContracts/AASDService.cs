using System;
using System.Collections.Generic;
using System.Web.UI.MobileControls;
using AASD_BuisnessLayer.Entities;
using AASD_ServiceLayer.DataContract;
using AASD_ServiceLayer.MessageContract;
using AASD_ServiceLayer.Translators;
using AASD_BuisnessLayer;
using AASD_BuisnessLayer.BuisnessLayer_Models.Concrete.SearchEngines;
using AAASD_TraceLayer.Concrete;

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

                    SearchEngine_Standart bingSearch = new SearchEngine_Standart();
                    IList<Display> resultListEntity =
                        bingSearch.ExecutingSearchEngine(Translators.Translator.ConvertQueryContractTOEntity(request));
                    lstResult = Translator.ConvertResultEntityToContract(resultListEntity);

                    retrieveSearchResponse = new RetrieveSearchResponse();
                    retrieveSearchResponse.listResultContract = lstResult;
                }
            }
            catch (Exception e)
            {
                LogWriter.Instance.writeException(Convert.ToString(this), Convert.ToString(this.GetType()), e.Message);
                throw e;
            }
            finally
            {
                LogWriter.Instance.writeTrace(Convert.ToString(this), Convert.ToString(this.GetType()), "tracing - AASD - Service_Layer- successful");
            }

            return retrieveSearchResponse;
        }
    }
}
