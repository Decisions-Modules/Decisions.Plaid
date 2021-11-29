using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.PaymentInitiation.Payments
{
    /// <summary>PaymentInitiationPaymentTokenCreateResponse defines the response schema for `/payment_initiation/payment/token/create`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class PaymentInitiationPaymentTokenCreateResponse 
    {
        /// <summary>A `payment_token` that can be provided to Link initialization to enter the payment initiation flow</summary>
        [Newtonsoft.Json.JsonProperty("payment_token", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Payment_token { get; set; }
    
        /// <summary>The date and time at which the token will expire, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format. A `payment_token` expires after 15 minutes.</summary>
        [Newtonsoft.Json.JsonProperty("payment_token_expiration_time", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTime Payment_token_expiration_time { get; set; }
    
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