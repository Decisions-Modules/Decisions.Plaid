

using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Investments
{
    /// <summary>Fired when new or canceled transactions have been detected on an investment account.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class InvestmentsDefaultUpdateWebhook 
    {
        /// <summary>`INVESTMENTS_TRANSACTIONS`</summary>
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
    
        [Newtonsoft.Json.JsonProperty("error", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Error Error { get; set; }
    
        /// <summary>The number of new transactions reported since the last time this webhook was fired.</summary>
        [Newtonsoft.Json.JsonProperty("new_investments_transactions", Required = Newtonsoft.Json.Required.Always)]
        public double New_investments_transactions { get; set; }
    
        /// <summary>The number of canceled transactions reported since the last time this webhook was fired.</summary>
        [Newtonsoft.Json.JsonProperty("canceled_investments_transactions", Required = Newtonsoft.Json.Required.Always)]
        public double Canceled_investments_transactions { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}