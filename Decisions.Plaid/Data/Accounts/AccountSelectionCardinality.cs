using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Accounts
{
    /// <summary>The application requires that accounts be limited to a specific cardinality.
    /// <br/>`MULTI_SELECT`: indicates that the user should be allowed to pick multiple accounts.
    /// <br/>`SINGLE_SELECT`: indicates that the user should be allowed to pick only a single account.
    /// <br/>`ALL`: indicates that the user must share all of their accounts and should not be given the opportunity to de-select</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum AccountSelectionCardinality
    {
        [EnumMember(Value = @"SINGLE_SELECT")]
        SINGLE_SELECT = 0,
    
        [EnumMember(Value = @"MULTI_SELECT")]
        MULTI_SELECT = 1,
    
        [EnumMember(Value = @"ALL")]
        ALL = 2,
    
    }
} 