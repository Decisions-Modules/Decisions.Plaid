using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.PaymentInitiation
{
    /// <summary>Metadata that captures what specific payment configurations an institution supports when making Payment Initiation requests.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class PaymentInitiationMetadata 
    {
        /// <summary>Indicates whether the institution supports payments from a different country.</summary>
        [Newtonsoft.Json.JsonProperty("supports_international_payments", Required = Newtonsoft.Json.Required.Always)]
        public bool Supports_international_payments { get; set; }
    
        /// <summary>A mapping of currency to maximum payment amount (denominated in the smallest unit of currency) supported by the insitution.
        /// <br/>
        /// <br/>Example: `{"GBP": "10000"}`
        /// <br/></summary>
        [Newtonsoft.Json.JsonProperty("maximum_payment_amount", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.Dictionary<string, string> Maximum_payment_amount { get; set; } = new System.Collections.Generic.Dictionary<string, string>();
    
        /// <summary>Indicates whether the institution supports returning refund details when initiating a payment.</summary>
        [Newtonsoft.Json.JsonProperty("supports_refund_details", Required = Newtonsoft.Json.Required.Always)]
        public bool Supports_refund_details { get; set; }
    
        [Newtonsoft.Json.JsonProperty("standing_order_metadata", Required = Newtonsoft.Json.Required.AllowNull)]
        public PaymentInitiationStandingOrderMetadata Standing_order_metadata { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}