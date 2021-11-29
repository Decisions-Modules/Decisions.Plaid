

using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Liabilities
{
    /// <summary>The webhook of type `LIABILITIES` and code `DEFAULT_UPDATE` will be fired when new or updated liabilities have been detected on a liabilities item.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class LiabilitiesDefaultUpdateWebhook 
    {
        /// <summary>`LIABILITIES`</summary>
        [Newtonsoft.Json.JsonProperty("webhook_type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Webhook_type { get; set; }
    
        /// <summary>`DEFAULT_UPDATE`</summary>
        [Newtonsoft.Json.JsonProperty("webhook_code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Webhook_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("item_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Item_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("error", Required = Newtonsoft.Json.Required.AllowNull)]
        public Error Error { get; set; }
    
        /// <summary>An array of `account_id`'s for accounts that contain new liabilities.</summary>
        [Newtonsoft.Json.JsonProperty("account_ids_with_new_liabilities", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<string> Account_ids_with_new_liabilities { get; set; } = new System.Collections.ObjectModel.Collection<string>();
    
        /// <summary>An object with keys of `account_id`'s that are mapped to their respective liabilities fields that changed.
        /// <br/>
        /// <br/>Example: `{ "XMBvvyMGQ1UoLbKByoMqH3nXMj84ALSdE5B58": ["past_amount_due"] }`
        /// <br/></summary>
        [Newtonsoft.Json.JsonProperty("account_ids_with_updated_liabilities", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.Dictionary<string, System.Collections.ObjectModel.Collection<string>> Account_ids_with_updated_liabilities { get; set; } = new System.Collections.Generic.Dictionary<string, System.Collections.ObjectModel.Collection<string>>();
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}