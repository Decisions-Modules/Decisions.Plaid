using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Accounts
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum PhoneNumberType
    {
        [EnumMember(Value = @"home")]
        Home = 0,
    
        [EnumMember(Value = @"work")]
        Work = 1,
    
        [EnumMember(Value = @"office")]
        Office = 2,
    
        [EnumMember(Value = @"mobile")]
        Mobile = 3,
    
        [EnumMember(Value = @"mobile1")]
        Mobile1 = 4,
    
        [EnumMember(Value = @"other")]
        Other = 5,
    
}
}