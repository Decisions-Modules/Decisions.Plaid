using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Sandbox
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum SandboxItemSetVerificationStatusRequestVerification_status
    {
        [EnumMember(Value = @"automatically_verified")]
        Automatically_verified = 0,
    
        [EnumMember(Value = @"verification_expired")]
        Verification_expired = 1,
    
}
}