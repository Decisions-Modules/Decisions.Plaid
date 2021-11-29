using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Accounts
{
    /// <summary>`investment:` Investment account
    /// <br/>
    /// <br/>`credit:` Credit card
    /// <br/>
    /// <br/>`depository:` Depository account
    /// <br/>
    /// <br/>`loan:` Loan account
    /// <br/>
    /// <br/>`brokerage`: An investment account. Used for `/assets/` endpoints only; other endpoints use `investment`.
    /// <br/>
    /// <br/>`other:` Non-specified account type
    /// <br/>
    /// <br/>See the [Account type schema](https://plaid.com/docs/api/accounts#account-type-schema) for a full listing of account types and corresponding subtypes.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum AccountType
    {
        [EnumMember(Value = @"investment")]
        Investment = 0,
    
        [EnumMember(Value = @"credit")]
        Credit = 1,
    
        [EnumMember(Value = @"depository")]
        Depository = 2,
    
        [EnumMember(Value = @"loan")]
        Loan = 3,
    
        [EnumMember(Value = @"brokerage")]
        Brokerage = 4,
    
        [EnumMember(Value = @"other")]
        Other = 5,
    
    }
} 