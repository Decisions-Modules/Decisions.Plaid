using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Signal.DecisionReport
{
    /// <summary>SignalDecisionReportRequest defines the request schema for `/signal/decision/report`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class SignalDecisionReportRequest 
    {
        [Newtonsoft.Json.JsonProperty("client_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Client_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("secret", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Secret { get; set; }
    
        /// <summary>Must be the same as the `client_transaction_id` supplied when calling `/signal/evaluate`</summary>
        [Newtonsoft.Json.JsonProperty("client_transaction_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(36, MinimumLength = 1)]
        public string Client_transaction_id { get; set; }
    
        /// <summary>`true` if the ACH transaction was initiated, `false` otherwise.</summary>
        [Newtonsoft.Json.JsonProperty("initiated", Required = Newtonsoft.Json.Required.Always)]
        public bool Initiated { get; set; }
    
        /// <summary>The actual number of days (hold time) since the ACH debit transaction that you wait before making funds available to your customers. The holding time could affect the ACH return rate. For example, use 0 if you make funds available to your customers instantly or the same day following the debit transaction, or 1 if you make funds available the next day following the debit initialization.</summary>
        [Newtonsoft.Json.JsonProperty("days_funds_on_hold", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public int? Days_funds_on_hold { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}