using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Products.Status
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum ProductStatusStatus
    {
        [EnumMember(Value = @"HEALTHY")]
        HEALTHY = 0,
    
        [EnumMember(Value = @"DEGRADED")]
        DEGRADED = 1,
    
        [EnumMember(Value = @"DOWN")]
        DOWN = 2,
    
}
}