namespace AASD_ServiceLayer
{
    
    
    [System.ServiceModel.ServiceBehaviorAttribute(InstanceContextMode=System.ServiceModel.InstanceContextMode.PerCall, ConcurrencyMode=System.ServiceModel.ConcurrencyMode.Single)]
    public class AASDService : IAASDService
    {
        
        public virtual RetrieveSearchResponse RetrieveSearch(RetrieveSearchRequest1 request)
        {
            throw new System.NotImplementedException();
        }
    }
}
