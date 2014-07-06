using System.Runtime.Serialization;

namespace Test
{
    [DataContract]
    class Result
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
