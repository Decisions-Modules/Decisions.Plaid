using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Paystubs
{
    /// <summary>The frequency at which the employee is paid. Possible values: `MONTHLY`, `BI-WEEKLY`, `WEEKLY`, `SEMI-MONTHLY`.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum PaystubPayFrequency
    {
        [EnumMember(Value = @"MONTHLY")]
        MONTHLY = 0,
    
        [EnumMember(Value = @"BI-WEEKLY")]
        BIWEEKLY = 1,
    
        [EnumMember(Value = @"WEEKLY")]
        WEEKLY = 2,
    
        [EnumMember(Value = @"SEMI-MONTHLY")]
        SEMIMONTHLY = 3,
    
}
}