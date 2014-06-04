using AASD_ServiceLayer.DataContract;
using AASD_ServiceLayer.MessageContract;

namespace AASD_ServiceLayer.MessageContract
{
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false, WrapperName="RetrieveSearchResponse")]
    public partial class RetrieveSearchResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="listResultContract", Namespace="AASD_Contracts/Message", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Response", IsNullable=false)]
        public System.Collections.Generic.List<ResultContract> listResultContract;
        
        public RetrieveSearchResponse()
        {
        }
        
        public RetrieveSearchResponse(System.Collections.Generic.List<ResultContract> listResultContract)
        {
            this.listResultContract = listResultContract;
        }
    }
}
