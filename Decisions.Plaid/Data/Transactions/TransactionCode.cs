using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transactions
{
    /// <summary>An identifier classifying the transaction type.
    /// <br/>
    /// <br/>This field is only populated for European institutions. For institutions in the US and Canada, this field is set to `null`.
    /// <br/>
    /// <br/>`adjustment:` Bank adjustment
    /// <br/>
    /// <br/>`atm:` Cash deposit or withdrawal via an automated teller machine
    /// <br/>
    /// <br/>`bank charge:` Charge or fee levied by the institution
    /// <br/>
    /// <br/>`bill payment`: Payment of a bill
    /// <br/>
    /// <br/>`cash:` Cash deposit or withdrawal
    /// <br/>
    /// <br/>`cashback:` Cash withdrawal while making a debit card purchase
    /// <br/>
    /// <br/>`cheque:` Document ordering the payment of money to another person or organization
    /// <br/>
    /// <br/>`direct debit:` Automatic withdrawal of funds initiated by a third party at a regular interval
    /// <br/>
    /// <br/>`interest:` Interest earned or incurred
    /// <br/>
    /// <br/>`purchase:` Purchase made with a debit or credit card
    /// <br/>
    /// <br/>`standing order:` Payment instructed by the account holder to a third party at a regular interval
    /// <br/>
    /// <br/>`transfer:` Transfer of money between accounts</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum TransactionCode
    {
        [EnumMember(Value = @"adjustment")]
        Adjustment = 0,
    
        [EnumMember(Value = @"atm")]
        Atm = 1,
    
        [EnumMember(Value = @"bank charge")]
        Bank_charge = 2,
    
        [EnumMember(Value = @"bill payment")]
        Bill_payment = 3,
    
        [EnumMember(Value = @"cash")]
        Cash = 4,
    
        [EnumMember(Value = @"cashback")]
        Cashback = 5,
    
        [EnumMember(Value = @"cheque")]
        Cheque = 6,
    
        [EnumMember(Value = @"direct debit")]
        Direct_debit = 7,
    
        [EnumMember(Value = @"interest")]
        Interest = 8,
    
        [EnumMember(Value = @"purchase")]
        Purchase = 9,
    
        [EnumMember(Value = @"standing order")]
        Standing_order = 10,
    
        [EnumMember(Value = @"transfer")]
        Transfer = 11,
    
}
}