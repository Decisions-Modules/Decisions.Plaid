using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Webhooks
{
    /// <summary>Fired when the status of a deposit switch request has changed.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class DepositSwitchStateUpdateWebhook 
    {
        /// <summary>`"DEPOSIT_SWITCH"`</summary>
        [Newtonsoft.Json.JsonProperty("webhook_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Webhook_type { get; set; }
    
        /// <summary>`"SWITCH_STATE_UPDATE"`</summary>
        [Newtonsoft.Json.JsonProperty("webhook_code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Webhook_code { get; set; }
    
        /// <summary>
        /// <br/>The state, or status, of the deposit switch.
        /// <br/>
        /// <br/>`initialized`: The deposit switch has been initialized with the user entering the information required to submit the deposit switch request.
        /// <br/>
        /// <br/>`processing`: The deposit switch request has been submitted and is being processed.
        /// <br/>
        /// <br/>`completed`: The user's employer has fulfilled and completed the deposit switch request.
        /// <br/>
        /// <br/>`error`: There was an error processing the deposit switch request.
        /// <br/>
        /// <br/>For more information, see the [Deposit Switch API reference](/docs/api/products#deposit_switchget).</summary>
        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State { get; set; }
    
        /// <summary>The ID of the deposit switch.</summary>
        [Newtonsoft.Json.JsonProperty("deposit_switch_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Deposit_switch_id { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}