using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WcfConnectionClosed
{
    [DataContract]
    public class TryDeferredExecutionResponse
    {
        [DataMember]
        public IEnumerable<Table> Tables { get; set; }
    }
}