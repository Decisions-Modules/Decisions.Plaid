using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Accounts
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum EmailType
    {
        [EnumMember(Value = @"primary")]
        Primary = 0,
    
        [EnumMember(Value = @"secondary")]
        Secondary = 1,
    
        [EnumMember(Value = @"other")]
        Other = 2,
    
}
}