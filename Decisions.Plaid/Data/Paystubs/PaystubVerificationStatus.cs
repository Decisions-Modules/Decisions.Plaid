using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Paystubs
{
    /// <summary>Derived verification status.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum PaystubVerificationStatus
    {
        [EnumMember(Value = @"PAYSTUB_VERIFICATION_STATUS_UNKNOWN")]
        PAYSTUB_VERIFICATION_STATUS_UNKNOWN = 0,
    
        [EnumMember(Value = @"PAYSTUB_VERIFICATION_STATUS_VERIFIED")]
        PAYSTUB_VERIFICATION_STATUS_VERIFIED = 1,
    
        [EnumMember(Value = @"PAYSTUB_VERIFICATION_STATUS_FRAUDULENT")]
        PAYSTUB_VERIFICATION_STATUS_FRAUDULENT = 2,
    
}
}