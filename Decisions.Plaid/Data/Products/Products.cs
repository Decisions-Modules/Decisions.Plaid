using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Products
{
    /// <summary>A list of products that an institution can support. All Items must be initialized with at least one product. The Balance product is always available and does not need to be specified during initialization.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum Products
    {
        [EnumMember(Value = @"assets")]
        Assets = 0,
    
        [EnumMember(Value = @"auth")]
        Auth = 1,
    
        [EnumMember(Value = @"balance")]
        Balance = 2,
    
        [EnumMember(Value = @"identity")]
        Identity = 3,
    
        [EnumMember(Value = @"investments")]
        Investments = 4,
    
        [EnumMember(Value = @"liabilities")]
        Liabilities = 5,
    
        [EnumMember(Value = @"payment_initiation")]
        Payment_initiation = 6,
    
        [EnumMember(Value = @"transactions")]
        Transactions = 7,
    
        [EnumMember(Value = @"credit_details")]
        Credit_details = 8,
    
        [EnumMember(Value = @"income")]
        Income = 9,
    
        [EnumMember(Value = @"income_verification")]
        Income_verification = 10,
    
        [EnumMember(Value = @"deposit_switch")]
        Deposit_switch = 11,
    
        [EnumMember(Value = @"standing_orders")]
        Standing_orders = 12,
    
        [EnumMember(Value = @"transfer")]
        Transfer = 13,
    
}
}