using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Accounts
{
    /// <summary>Allow or disallow product access by account. Unlisted (e.g. missing) accounts will be considered `new_accounts`.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public class AccountAccess 
    {
        /// <summary>The unique account identifier for this account. This value must match that returned by the data access API for this account.</summary>
        [Newtonsoft.Json.JsonProperty("unique_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Unique_id { get; set; }
    
        /// <summary>Allow the application to see this account (and associated details, including balance) in the list of accounts  If unset, defaults to `true`.</summary>
        [Newtonsoft.Json.JsonProperty("authorized", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Authorized { get; set; } = true;
    
        [Newtonsoft.Json.JsonProperty("account_product_access", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AccountProductAccessNullable Account_product_access { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}