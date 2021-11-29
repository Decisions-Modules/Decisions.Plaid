using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.PaymentInitiation.Payments
{
    /// <summary>PaymentInitiationPaymentListResponse defines the response schema for `/payment_initiation/payment/list`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class PaymentInitiationPaymentListResponse 
    {
        /// <summary>An array of payments that have been created, associated with the given `client_id`.</summary>
        [Newtonsoft.Json.JsonProperty("payments", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<PaymentInitiationPayment> Payments { get; set; } = new System.Collections.ObjectModel.Collection<PaymentInitiationPayment>();
    
        /// <summary>The value that, when used as the optional `cursor` parameter to `/payment_initiation/payment/list`, will return the next unreturned payment as its first payment.</summary>
        [Newtonsoft.Json.JsonProperty("next_cursor", Required = Newtonsoft.Json.Required.AllowNull)]
        public System.DateTime? Next_cursor { get; set; }
    
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