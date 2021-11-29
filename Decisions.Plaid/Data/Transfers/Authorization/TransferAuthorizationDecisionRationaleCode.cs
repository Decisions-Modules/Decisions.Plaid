using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transfers.Authorization
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum TransferAuthorizationDecisionRationaleCode
    {
        [EnumMember(Value = @"NSF")]
        NSF = 0,
    
        [EnumMember(Value = @"RISK")]
        RISK = 1,
    
        [EnumMember(Value = @"MANUALLY_VERIFIED_ITEM")]
        MANUALLY_VERIFIED_ITEM = 2,
    
        [EnumMember(Value = @"LOGIN_REQUIRED")]
        LOGIN_REQUIRED = 3,
    
        [EnumMember(Value = @"ERROR")]
        ERROR = 4,
    
}
}