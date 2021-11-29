using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Products.Status
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum ProductStatusBreakdownRefresh_interval
    {
        [EnumMember(Value = @"NORMAL")]
        NORMAL = 0,
    
        [EnumMember(Value = @"DELAYED")]
        DELAYED = 1,
    
        [EnumMember(Value = @"STOPPED")]
        STOPPED = 2,
    
}
}