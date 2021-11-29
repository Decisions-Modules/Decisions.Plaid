using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.DepositSwitch.Create
{
    /// <summary>Options to configure the `/deposit_switch/create` request. If provided, cannot be `null`.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class DepositSwitchCreateRequestOptions 
    {
        /// <summary>The URL registered to receive webhooks when the status of a deposit switch request has changed.
        /// <br/></summary>
        [Newtonsoft.Json.JsonProperty("webhook", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Webhook { get; set; }
    
        /// <summary>An array of access tokens corresponding to transaction items to use when attempting to match the user to their Payroll Provider. These tokens must be created by the same client id as the one creating the switch, and have access to the transactions product.</summary>
        [Newtonsoft.Json.JsonProperty("transaction_item_access_tokens", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(99)]
        public System.Collections.ObjectModel.Collection<string> Transaction_item_access_tokens { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}