using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transactions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum TransactionBaseTransaction_type
    {
        [EnumMember(Value = @"digital")]
        Digital = 0,
    
        [EnumMember(Value = @"place")]
        Place = 1,
    
        [EnumMember(Value = @"special")]
        Special = 2,
    
        [EnumMember(Value = @"unresolved")]
        Unresolved = 3,
    
}
}