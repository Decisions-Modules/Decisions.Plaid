using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Accounts.Balance
{
    /// <summary>An optional object to filter `/accounts/balance/get` results.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public class AccountsBalanceGetRequestOptions 
    {
        /// <summary>A list of `account_ids` to retrieve for the Item. The default value is `null`.
        /// <br/>
        /// <br/>Note: An error will be returned if a provided `account_id` is not associated with the Item.</summary>
        [Newtonsoft.Json.JsonProperty("account_ids", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.Collection<string> Account_ids { get; set; }
    
        [Newtonsoft.Json.JsonProperty("min_last_updated_datetime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime Min_last_updated_datetime { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
} 