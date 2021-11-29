using System.Runtime.Serialization;
using Decisions.Plaid.Data.Transfers;
using Decisions.Plaid.Data.Transfers.Events;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Sandbox
{
    /// <summary>Defines the request schema for `/sandbox/transfer/simulate`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class SandboxTransferSimulateRequest 
    {
        [Newtonsoft.Json.JsonProperty("client_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Client_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("secret", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Secret { get; set; }
    
        [Newtonsoft.Json.JsonProperty("transfer_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Transfer_id { get; set; }
    
        /// <summary>The asynchronous event to be simulated. May be: `posted`, `failed`, or `reversed`.
        /// <br/>
        /// <br/>An error will be returned if the event type is incompatible with the current transfer status. Compatible status --&gt; event type transitions include:
        /// <br/>
        /// <br/>`pending` --&gt; `failed`
        /// <br/>
        /// <br/>`pending` --&gt; `posted`
        /// <br/>
        /// <br/>`posted` --&gt; `reversed`
        /// <br/></summary>
        [Newtonsoft.Json.JsonProperty("event_type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Event_type { get; set; }
    
        [Newtonsoft.Json.JsonProperty("failure_reason", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public TransferFailure Failure_reason { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}