using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Webhooks
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum PaymentStatusUpdateWebhookNew_payment_status
    {
        [EnumMember(Value = @"PAYMENT_STATUS_INPUT_NEEDED")]
        PAYMENT_STATUS_INPUT_NEEDED = 0,
    
        [EnumMember(Value = @"PAYMENT_STATUS_PROCESSING")]
        PAYMENT_STATUS_PROCESSING = 1,
    
        [EnumMember(Value = @"PAYMENT_STATUS_INITIATED")]
        PAYMENT_STATUS_INITIATED = 2,
    
        [EnumMember(Value = @"PAYMENT_STATUS_COMPLETED")]
        PAYMENT_STATUS_COMPLETED = 3,
    
        [EnumMember(Value = @"PAYMENT_STATUS_INSUFFICIENT_FUNDS")]
        PAYMENT_STATUS_INSUFFICIENT_FUNDS = 4,
    
        [EnumMember(Value = @"PAYMENT_STATUS_FAILED")]
        PAYMENT_STATUS_FAILED = 5,
    
        [EnumMember(Value = @"PAYMENT_STATUS_BLOCKED")]
        PAYMENT_STATUS_BLOCKED = 6,
    
        [EnumMember(Value = @"PAYMENT_STATUS_UNKNOWN")]
        PAYMENT_STATUS_UNKNOWN = 7,
    
}
}