using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.PaymentInitiation.Payments
{
    /// <summary>PaymentInitiationPaymentReverseResponse defines the response schema for `/payment_initation/payment/reverse`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class PaymentInitiationPaymentReverseResponse 
    {
        /// <summary>A unique ID identifying the refund</summary>
        [Newtonsoft.Json.JsonProperty("refund_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Refund_id { get; set; }
    
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
        public PaymentInitiationPaymentReverseResponseStatus Status { get; set; }
    
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