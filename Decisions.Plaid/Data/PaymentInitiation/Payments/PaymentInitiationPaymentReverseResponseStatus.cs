using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.PaymentInitiation.Payments
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum PaymentInitiationPaymentReverseResponseStatus
    {
        [EnumMember(Value = @"PROCESSING")]
        PROCESSING = 0,
    
        [EnumMember(Value = @"EXECUTED")]
        EXECUTED = 1,
    
        [EnumMember(Value = @"INITIATED")]
        INITIATED = 2,
    
        [EnumMember(Value = @"FAILED")]
        FAILED = 3,
    
}
}