using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Institutions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum IncidentUpdateStatus
    {
        [EnumMember(Value = @"INVESTIGATING")]
        INVESTIGATING = 0,
    
        [EnumMember(Value = @"IDENTIFIED")]
        IDENTIFIED = 1,
    
        [EnumMember(Value = @"SCHEDULED")]
        SCHEDULED = 2,
    
        [EnumMember(Value = @"RESOLVED")]
        RESOLVED = 3,
    
        [EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 4,
    
}
}