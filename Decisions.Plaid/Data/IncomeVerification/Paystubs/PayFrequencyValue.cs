using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.IncomeVerification.Paystubs
{
    /// <summary>The frequency of the pay period.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum PayFrequencyValue
    {
        [EnumMember(Value = @"monthly")]
        Monthly = 0,
    
        [EnumMember(Value = @"semimonthly")]
        Semimonthly = 1,
    
        [EnumMember(Value = @"weekly")]
        Weekly = 2,
    
        [EnumMember(Value = @"biweekly")]
        Biweekly = 3,
    
        [EnumMember(Value = @"unknown")]
        Unknown = 4,
    
}
}