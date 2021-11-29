using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Accounts
{
    /// <summary>ISO-3166-1 alpha-2 country code standard.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum CountryCode
    {
        [EnumMember(Value = @"US")]
        US = 0,
    
        [EnumMember(Value = @"GB")]
        GB = 1,
    
        [EnumMember(Value = @"ES")]
        ES = 2,
    
        [EnumMember(Value = @"NL")]
        NL = 3,
    
        [EnumMember(Value = @"FR")]
        FR = 4,
    
        [EnumMember(Value = @"IE")]
        IE = 5,
    
        [EnumMember(Value = @"CA")]
        CA = 6,
    
        [EnumMember(Value = @"DE")]
        DE = 7,
    
}
}