using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Paystubs
{
    /// <summary>Commonly used term to describe the earning line item.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum EarningsBreakdownCanonicalDescription
    {
        [EnumMember(Value = @"BONUS")]
        BONUS = 0,
    
        [EnumMember(Value = @"COMMISSION")]
        COMMISSION = 1,
    
        [EnumMember(Value = @"OVERTIME")]
        OVERTIME = 2,
    
        [EnumMember(Value = @"PAID TIME OFF")]
        PAID_TIME_OFF = 3,
    
        [EnumMember(Value = @"REGULAR PAY")]
        REGULAR_PAY = 4,
    
        [EnumMember(Value = @"VACATION")]
        VACATION = 5,
    
        [EnumMember(Value = @"OTHER")]
        OTHER = 6,
    
}
}