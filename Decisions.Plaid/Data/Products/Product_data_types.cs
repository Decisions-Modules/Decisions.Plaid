using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Products
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum Product_data_types
    {
        [EnumMember(Value = @"ACCOUNT_BALANCE")]
        ACCOUNT_BALANCE = 0,
    
        [EnumMember(Value = @"ACCOUNT_USER_INFO")]
        ACCOUNT_USER_INFO = 1,
    
        [EnumMember(Value = @"ACCOUNT_TRANSACTIONS")]
        ACCOUNT_TRANSACTIONS = 2,
    
}
}