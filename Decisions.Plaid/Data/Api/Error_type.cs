using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Api
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum Error_type
    {
        [EnumMember(Value = @"INVALID_REQUEST")]
        INVALID_REQUEST = 0,
    
        [EnumMember(Value = @"INVALID_RESULT")]
        INVALID_RESULT = 1,
    
        [EnumMember(Value = @"INVALID_INPUT")]
        INVALID_INPUT = 2,
    
        [EnumMember(Value = @"INSTITUTION_ERROR")]
        INSTITUTION_ERROR = 3,
    
        [EnumMember(Value = @"RATE_LIMIT_EXCEEDED")]
        RATE_LIMIT_EXCEEDED = 4,
    
        [EnumMember(Value = @"API_ERROR")]
        API_ERROR = 5,
    
        [EnumMember(Value = @"ITEM_ERROR")]
        ITEM_ERROR = 6,
    
        [EnumMember(Value = @"ASSET_REPORT_ERROR")]
        ASSET_REPORT_ERROR = 7,
    
        [EnumMember(Value = @"RECAPTCHA_ERROR")]
        RECAPTCHA_ERROR = 8,
    
        [EnumMember(Value = @"OAUTH_ERROR")]
        OAUTH_ERROR = 9,
    
        [EnumMember(Value = @"PAYMENT_ERROR")]
        PAYMENT_ERROR = 10,
    
        [EnumMember(Value = @"BANK_TRANSFER_ERROR")]
        BANK_TRANSFER_ERROR = 11,
    
        [EnumMember(Value = @"INCOME_VERIFICATION_ERROR")]
        INCOME_VERIFICATION_ERROR = 12,
    
}
}