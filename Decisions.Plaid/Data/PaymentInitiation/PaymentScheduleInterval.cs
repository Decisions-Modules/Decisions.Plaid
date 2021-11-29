using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.PaymentInitiation
{
    /// <summary>The frequency interval of the payment.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum PaymentScheduleInterval
    {
        [EnumMember(Value = @"WEEKLY")]
        WEEKLY = 0,
    
        [EnumMember(Value = @"MONTHLY")]
        MONTHLY = 1,
    
}
}