namespace AASD_ServiceLayer
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false, WrapperName="RetrieveSearchRequest1")]
    public partial class RetrieveSearchRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="AASD_Contracts/Message", Order=0, Name="RetrieveSearchRequest")]
        public RetrieveSearchRequest RetrieveSearchRequest;
        
        public RetrieveSearchRequest1()
        {
        }
        
        public RetrieveSearchRequest1(RetrieveSearchRequest RetrieveSearchRequest)
        {
            this.RetrieveSearchRequest = RetrieveSearchRequest;
        }
    }
}
