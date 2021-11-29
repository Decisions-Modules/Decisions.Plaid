

using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.PaymentInitiation.Refund
{
    /// <summary>PaymentInitiationRefund defines a payment initiation refund</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class PaymentInitiationRefund 
    {
        /// <summary>The ID of the refund. Like all Plaid identifiers, the `refund_id` is case sensitive.</summary>
        [Newtonsoft.Json.JsonProperty("refund_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Refund_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public PaymentAmount Amount { get; set; } = new PaymentAmount();
    
        /// <summary>The status of the refund.
        /// <br/>
        /// <br/>`PROCESSING`: The refund is currently being processed. The refund will automatically exit this state when processing is complete.
        /// <br/>
        /// <br/>`INITIATED`: The refund has been successfully initiated.
        /// <br/>
        /// <br/>`EXECUTED`: Indicates that the refund has been successfully executed.
        /// <br/>
        /// <br/>`FAILED`: The refund has failed to be executed. This error is retryable once the root cause is resolved.</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PaymentInitiationRefundStatus Status { get; set; }
    
        /// <summary>The date and time of the last time the `status` was updated, in IS0 8601 format</summary>
        [Newtonsoft.Json.JsonProperty("last_status_update", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTime Last_status_update { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}