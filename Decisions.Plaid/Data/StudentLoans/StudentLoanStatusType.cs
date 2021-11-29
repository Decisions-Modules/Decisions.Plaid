using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.StudentLoans
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum StudentLoanStatusType
    {
        [EnumMember(Value = @"cancelled")]
        Cancelled = 0,
    
        [EnumMember(Value = @"charged off")]
        Charged_off = 1,
    
        [EnumMember(Value = @"claim")]
        Claim = 2,
    
        [EnumMember(Value = @"consolidated")]
        Consolidated = 3,
    
        [EnumMember(Value = @"deferment")]
        Deferment = 4,
    
        [EnumMember(Value = @"delinquent")]
        Delinquent = 5,
    
        [EnumMember(Value = @"discharged")]
        Discharged = 6,
    
        [EnumMember(Value = @"extension")]
        Extension = 7,
    
        [EnumMember(Value = @"forbearance")]
        Forbearance = 8,
    
        [EnumMember(Value = @"in grace")]
        In_grace = 9,
    
        [EnumMember(Value = @"in military")]
        In_military = 10,
    
        [EnumMember(Value = @"in school")]
        In_school = 11,
    
        [EnumMember(Value = @"not fully disbursed")]
        Not_fully_disbursed = 12,
    
        [EnumMember(Value = @"other")]
        Other = 13,
    
        [EnumMember(Value = @"paid in full")]
        Paid_in_full = 14,
    
        [EnumMember(Value = @"refunded")]
        Refunded = 15,
    
        [EnumMember(Value = @"repayment")]
        Repayment = 16,
    
        [EnumMember(Value = @"transferred")]
        Transferred = 17,
    
}
}