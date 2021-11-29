using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Liabilities
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum Apr_type
    {
        [EnumMember(Value = @"balance_transfer_apr")]
        Balance_transfer_apr = 0,
    
        [EnumMember(Value = @"cash_apr")]
        Cash_apr = 1,
    
        [EnumMember(Value = @"purchase_apr")]
        Purchase_apr = 2,
    
        [EnumMember(Value = @"special")]
        Special = 3,
    
}
}