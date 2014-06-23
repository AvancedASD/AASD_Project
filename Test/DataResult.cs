using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [DataContract]
    class DataResult
    {
        [DataMember]
        public string status { get; set; }
        [DataMember]
        public List<Result> result { get; set; }
        [DataMember]
        public string cursor { get; set; }
        [DataMember]
        public string cost { get; set; }
        [DataMember]
        public string hits { get; set; }
    }
}
