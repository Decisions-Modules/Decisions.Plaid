using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.PaymentInitiation.Refund
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum PaymentInitiationRefundStatus
    {
        [EnumMember(Value = @"PROCESSING")]
        PROCESSING = 0,
    
        [EnumMember(Value = @"INITIATED")]
        INITIATED = 1,
    
        [EnumMember(Value = @"EXECUTED")]
        EXECUTED = 2,
    
        [EnumMember(Value = @"FAILED")]
        FAILED = 3,
    
}
}