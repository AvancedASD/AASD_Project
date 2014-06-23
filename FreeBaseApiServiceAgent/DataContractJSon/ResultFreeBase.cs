using System.Runtime.Serialization;

namespace FreeBaseApiServiceAgent.DataContractJSon
{
    [DataContract]
    class ResultFreeBase
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
