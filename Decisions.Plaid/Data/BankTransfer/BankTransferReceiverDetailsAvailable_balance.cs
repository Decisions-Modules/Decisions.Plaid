using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.BankTransfer
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum BankTransferReceiverDetailsAvailable_balance
    {
        [EnumMember(Value = @"positive")]
        Positive = 0,
    
        [EnumMember(Value = @"negative")]
        Negative = 1,
    
}
}