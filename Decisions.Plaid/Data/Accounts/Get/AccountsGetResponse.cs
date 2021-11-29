using System.Runtime.Serialization;
using Decisions.Plaid.Data.Items;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Accounts.Get
{
    /// <summary>AccountsGetResponse defines the response schema for `/accounts/get` and `/accounts/balance/get`.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public class AccountsGetResponse 
    {
        /// <summary>An array of financial institution accounts associated with the Item.
        /// <br/>If `/accounts/balance/get` was called, each account will include real-time balance information.</summary>
        [Newtonsoft.Json.JsonProperty("accounts", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<AccountBase> Accounts { get; set; } = new System.Collections.ObjectModel.Collection<AccountBase>();
    
        [Newtonsoft.Json.JsonProperty("item", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Item Item { get; set; } = new Item();
    
        [Newtonsoft.Json.JsonProperty("request_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Request_id { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
} 