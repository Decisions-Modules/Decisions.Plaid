using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Sandbox
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum SandboxIncomeFireWebhookRequestVerification_status
    {
        [EnumMember(Value = @"VERIFICATION_STATUS_PROCESSING_COMPLETE")]
        VERIFICATION_STATUS_PROCESSING_COMPLETE = 0,
    
        [EnumMember(Value = @"VERIFICATION_STATUS_DOCUMENT_REJECTED")]
        VERIFICATION_STATUS_DOCUMENT_REJECTED = 1,
    
        [EnumMember(Value = @"VERIFICATION_STATUS_PROCESSING_FAILED")]
        VERIFICATION_STATUS_PROCESSING_FAILED = 2,
    
}
}