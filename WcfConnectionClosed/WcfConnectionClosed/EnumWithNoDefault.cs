using System.Runtime.Serialization;

namespace WcfConnectionClosed
{
    [DataContract]
    public enum EnumWithNoDefault
    {
        // Uncomment this member to fix the exception
        // [EnumMember]
        // Default = 0,


        [EnumMember]
        One = 1,

        [EnumMember]
        Two = 2
    }
}