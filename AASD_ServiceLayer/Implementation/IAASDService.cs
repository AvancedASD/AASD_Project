namespace AASD_ServiceLayer
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="AASD_Contracts/WebService", ConfigurationName="IAASDService")]
    public interface IAASDService
    {
        
        // CODEGEN: Generating message contract since the operation RetrieveSearch is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="AASD_Contracts/WebService/IAASDService/RetrieveSearch", ReplyAction="AASD_Contracts/WebService/IAASDService/RetrieveSearchResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        RetrieveSearchResponse RetrieveSearch(RetrieveSearchRequest1 request);
    }
}
