using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transactions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum TransactionPayment_channel
    {
        [EnumMember(Value = @"online")]
        Online = 0,
    
        [EnumMember(Value = @"in store")]
        In_store = 1,
    
        [EnumMember(Value = @"other")]
        Other = 2,
    
}
}