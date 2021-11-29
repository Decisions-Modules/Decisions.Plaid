using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Investments.Transactions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum InvestmentTransactionType
    {
        [EnumMember(Value = @"buy")]
        Buy = 0,
    
        [EnumMember(Value = @"sell")]
        Sell = 1,
    
        [EnumMember(Value = @"cancel")]
        Cancel = 2,
    
        [EnumMember(Value = @"cash")]
        Cash = 3,
    
        [EnumMember(Value = @"fee")]
        Fee = 4,
    
        [EnumMember(Value = @"transfer")]
        Transfer = 5,
    
}
}