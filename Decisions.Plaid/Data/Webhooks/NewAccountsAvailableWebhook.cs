using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Webhooks
{
    /// <summary>Fired when Plaid detects a new account for Items created or updated with [Account Select v2](https://plaid.com/docs/link/customization/#account-select). Upon receiving this webhook, you can prompt your users to share new accounts with you through [Account Select v2 update mode](https://plaid.com/docs/link/update-mode/#using-update-mode-to-request-new-accounts).</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class NewAccountsAvailableWebhook 
    {
        /// <summary>`ITEM`</summary>
        [Newtonsoft.Json.JsonProperty("webhook_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Webhook_type { get; set; }
    
        /// <summary>`NEW_ACCOUNTS_AVAILABLE`</summary>
        [Newtonsoft.Json.JsonProperty("webhook_code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Webhook_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("item_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Item_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("error", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Error Error { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}