using System.Runtime.Serialization;

namespace WcfConnectionClosed
{
    [DataContract]
    public class TryEnumWithNoDefaultValueResponse
    {
        [DataMember]
        public EnumWithNoDefault Value { get; set; }
    }
}