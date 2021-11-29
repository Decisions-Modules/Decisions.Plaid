using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Accounts
{
    /// <summary>An array of account subtypes to display in Link. If not specified, all account subtypes will be shown. For a full list of valid types and subtypes, see the [Account schema](https://plaid.com/docs/api/accounts#accounts-schema). </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class AccountSubtypes : System.Collections.ObjectModel.Collection<AccountSubtype?>
    {
    
    }
} 