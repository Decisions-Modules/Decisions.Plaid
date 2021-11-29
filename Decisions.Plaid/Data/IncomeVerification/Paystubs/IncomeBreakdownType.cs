using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.IncomeVerification.Paystubs
{
    /// <summary>The type of income. Possible values include:
    /// <br/>  `"regular"`: regular income
    /// <br/>  `"overtime"`: overtime income
    /// <br/>  `"bonus"`: bonus income</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum IncomeBreakdownType
    {
        [EnumMember(Value = @"bonus")]
        Bonus = 0,
    
        [EnumMember(Value = @"overtime")]
        Overtime = 1,
    
        [EnumMember(Value = @"regular")]
        Regular = 2,
    
}
}