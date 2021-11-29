

using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.PaymentInitiation
{
    /// <summary>Metadata specifically related to valid Payment Initiation standing order configurations for the institution.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class PaymentInitiationStandingOrderMetadata 
    {
        /// <summary>Indicates whether the institution supports closed-ended standing orders by providing an end date.</summary>
        [Newtonsoft.Json.JsonProperty("supports_standing_order_end_date", Required = Newtonsoft.Json.Required.Always)]
        public bool Supports_standing_order_end_date { get; set; }
    
        /// <summary>This is only applicable to `MONTHLY` standing orders. Indicates whether the institution supports negative integers (-1 to -5) for setting up a `MONTHLY` standing order relative to the end of the month.</summary>
        [Newtonsoft.Json.JsonProperty("supports_standing_order_negative_execution_days", Required = Newtonsoft.Json.Required.Always)]
        public bool Supports_standing_order_negative_execution_days { get; set; }
    
        /// <summary>A list of the valid standing order intervals supported by the institution.</summary>
        [Newtonsoft.Json.JsonProperty("valid_standing_order_intervals", Required = Newtonsoft.Json.Required.Always, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<PaymentScheduleInterval> Valid_standing_order_intervals { get; set; } = new System.Collections.ObjectModel.Collection<PaymentScheduleInterval>();
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}