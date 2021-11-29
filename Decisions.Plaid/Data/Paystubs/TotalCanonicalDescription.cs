using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Paystubs
{
    /// <summary>Commonly used term to describe the line item.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum TotalCanonicalDescription
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
    
        [EnumMember(Value = @"EMPLOYEE MEDICARE")]
        EMPLOYEE_MEDICARE = 6,
    
        [EnumMember(Value = @"FICA")]
        FICA = 7,
    
        [EnumMember(Value = @"SOCIAL SECURITY EMPLOYEE TAX")]
        SOCIAL_SECURITY_EMPLOYEE_TAX = 8,
    
        [EnumMember(Value = @"MEDICAL")]
        MEDICAL = 9,
    
        [EnumMember(Value = @"VISION")]
        VISION = 10,
    
        [EnumMember(Value = @"DENTAL")]
        DENTAL = 11,
    
        [EnumMember(Value = @"NET PAY")]
        NET_PAY = 12,
    
        [EnumMember(Value = @"TAXES")]
        TAXES = 13,
    
        [EnumMember(Value = @"NOT_FOUND")]
        NOT_FOUND = 14,
    
        [EnumMember(Value = @"OTHER")]
        OTHER = 15,
    
}
}