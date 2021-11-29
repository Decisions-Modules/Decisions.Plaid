using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Accounts
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum AccountBaseVerification_status
    {
        [EnumMember(Value = @"automatically_verified")]
        Automatically_verified = 0,
    
        [EnumMember(Value = @"pending_automatic_verification")]
        Pending_automatic_verification = 1,
    
        [EnumMember(Value = @"pending_manual_verification")]
        Pending_manual_verification = 2,
    
        [EnumMember(Value = @"manually_verified")]
        Manually_verified = 3,
    
        [EnumMember(Value = @"verification_expired")]
        Verification_expired = 4,
    
        [EnumMember(Value = @"verification_failed")]
        Verification_failed = 5,
    
    }
} 