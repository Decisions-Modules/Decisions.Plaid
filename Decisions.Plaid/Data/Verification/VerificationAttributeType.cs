using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Verification
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum VerificationAttributeType
    {
        [EnumMember(Value = @"VERIFICATION_ATTRIBUTE_TYPE_UNKNOWN")]
        VERIFICATION_ATTRIBUTE_TYPE_UNKNOWN = 0,
    
        [EnumMember(Value = @"VERIFICATION_ATTRIBUTE_TYPE_AMOUNT_MATCH")]
        VERIFICATION_ATTRIBUTE_TYPE_AMOUNT_MATCH = 1,
    
        [EnumMember(Value = @"VERIFICATION_ATTRIBUTE_TYPE_DATE_MATCH")]
        VERIFICATION_ATTRIBUTE_TYPE_DATE_MATCH = 2,
    
        [EnumMember(Value = @"VERIFICATION_ATTRIBUTE_TYPE_DATE_MISMATCH")]
        VERIFICATION_ATTRIBUTE_TYPE_DATE_MISMATCH = 3,
    
        [EnumMember(Value = @"VERIFICATION_ATTRIBUTE_TYPE_FILE_TAMPERING")]
        VERIFICATION_ATTRIBUTE_TYPE_FILE_TAMPERING = 4,
    
}
}