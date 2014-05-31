namespace AASD_ServiceLayer
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false, WrapperName="RetrieveSearchResponse")]
    public partial class RetrieveSearchResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="RetrieveSearchResponse1", Namespace="AASD_Contracts/Message", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Response", IsNullable=false)]
        public System.Collections.Generic.List<ResultContract> RetrieveSearchResponse1;
        
        public RetrieveSearchResponse()
        {
        }
        
        public RetrieveSearchResponse(System.Collections.Generic.List<ResultContract> RetrieveSearchResponse1)
        {
            this.RetrieveSearchResponse1 = RetrieveSearchResponse1;
        }
    }
}
