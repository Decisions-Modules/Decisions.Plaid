using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Signal.Evaluate
{
    /// <summary>SignalEvaluateRequest defines the request schema for `/signal/evaluate`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class SignalEvaluateRequest 
    {
        [Newtonsoft.Json.JsonProperty("client_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Client_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("secret", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Secret { get; set; }
    
        [Newtonsoft.Json.JsonProperty("access_token", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Access_token { get; set; }
    
        /// <summary>The `account_id` of the account whose verification status is to be modified</summary>
        [Newtonsoft.Json.JsonProperty("account_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Account_id { get; set; }
    
        /// <summary>The unique ID that you would like to use to refer to this transaction. For your convenience mapping your internal data, you could use your internal ID/identifier for this transaction. The max length for this field is 36 characters.</summary>
        [Newtonsoft.Json.JsonProperty("client_transaction_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(36, MinimumLength = 1)]
        public string Client_transaction_id { get; set; }
    
        /// <summary>The transaction amount, in USD (e.g. `102.05`)</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
        public double Amount { get; set; }
    
        /// <summary>`true` if the end user is present while initiating the ACH transfer and the endpoint is being called; `false` otherwise (for example, when the ACH transfer is scheduled and the end user is not present, or you call this endpoint after the ACH transfer but before submitting the Nacha file for ACH processing).</summary>
        [Newtonsoft.Json.JsonProperty("user_present", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? User_present { get; set; }
    
        /// <summary>A unique ID that identifies the end user in your system. This ID is used to correlate requests by a user with multiple Items. The max length for this field is 36 characters.</summary>
        [Newtonsoft.Json.JsonProperty("client_user_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(36)]
        public string Client_user_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SignalUser User { get; set; }
    
        [Newtonsoft.Json.JsonProperty("device", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SignalDevice Device { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}