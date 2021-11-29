using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.PaymentInitiation
{
    /// <summary>The amount and currency of a payment</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class PaymentAmount 
    {
        /// <summary>The ISO-4217 currency code of the payment. For standing orders, `"GBP"` must be used.</summary>
        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(3, MinimumLength = 3)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PaymentAmountCurrency Currency { get; set; }
    
        /// <summary>The amount of the payment. Must contain at most two digits of precision e.g. `1.23`. Minimum accepted value is `1`.</summary>
        [Newtonsoft.Json.JsonProperty("value", Required = Newtonsoft.Json.Required.Always)]
        public double Value { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}