using System.Runtime.Serialization;

namespace WcfConnectionClosed
{
    [DataContract]
    public class TryReadOnlyDataContractResponse
    {
        [DataMember]
        public string Field1
        {
            get { return string.Empty; }

            // Uncomment the setter to fix the exception
            // set { }
        }
    }
}