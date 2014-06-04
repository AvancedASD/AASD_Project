using System.Collections.Generic;
using System.Web.UI.MobileControls;
using AASD_ServiceLayer.DataContract;
using AASD_ServiceLayer.MessageContract;

namespace AASD_ServiceLayer
{


    [System.ServiceModel.ServiceBehaviorAttribute(InstanceContextMode = System.ServiceModel.InstanceContextMode.PerCall, ConcurrencyMode = System.ServiceModel.ConcurrencyMode.Single)]
    public class AASDService : IAASDService
    {

        public virtual RetrieveSearchResponse RetrieveSearch(RetrieveSearchRequest1 request)
        {
            RetrieveSearchResponse retrieveSearchResponse = null;
            List<ResultContract> lstResult = new List<ResultContract>();
            ResultContract rstContract = new ResultContract()
            {
                Description = "asasa asasa",
                DisplayUrl = "https://github.com/AvancedASD/AASD_Project/tree/develop/AASD_ServiceLayer/Schema",
                Title = "test",
                Url = "https://github.com/AvancedASD/AASD_Project/tree/develop/AASD_ServiceLayer/Schema"
            };
            lstResult.Add(rstContract);

            retrieveSearchResponse = new RetrieveSearchResponse();
            retrieveSearchResponse.listResultContract = lstResult;
            return retrieveSearchResponse;
        }
    }
}
