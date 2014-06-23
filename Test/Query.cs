using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Test
{
    [DataContract]
    class Query
    {
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public string name { get; set; }
        public string ToJsonString()
        {
            return "{" + JsonConvert.SerializeObject("query", Formatting.Indented) + ":" +
            JsonConvert.SerializeObject(this, Formatting.Indented) + "\n" + "}";
        }
    }

}
