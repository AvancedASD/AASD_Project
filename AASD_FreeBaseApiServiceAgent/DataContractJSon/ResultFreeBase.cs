using System.Runtime.Serialization;

namespace AASD_FreeBaseApiServiceAgent.DataContractJSon
{
    [DataContract]
    public class ResultFreeBase
    {
        [DataMember]
        public string mid { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string lang { get; set; }
        [DataMember]
        public string score { get; set; }
    }
}
