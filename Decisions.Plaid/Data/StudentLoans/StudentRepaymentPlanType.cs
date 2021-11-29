using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.StudentLoans
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum StudentRepaymentPlanType
    {
        [EnumMember(Value = @"extended graduated")]
        Extended_graduated = 0,
    
        [EnumMember(Value = @"extended standard")]
        Extended_standard = 1,
    
        [EnumMember(Value = @"graduated")]
        Graduated = 2,
    
        [EnumMember(Value = @"income-contingent repayment")]
        IncomeContingent_repayment = 3,
    
        [EnumMember(Value = @"income-based repayment")]
        IncomeBased_repayment = 4,
    
        [EnumMember(Value = @"interest-only")]
        InterestOnly = 5,
    
        [EnumMember(Value = @"other")]
        Other = 6,
    
        [EnumMember(Value = @"pay as you earn")]
        Pay_as_you_earn = 7,
    
        [EnumMember(Value = @"revised pay as you earn")]
        Revised_pay_as_you_earn = 8,
    
        [EnumMember(Value = @"standard")]
        Standard = 9,
    
}
}