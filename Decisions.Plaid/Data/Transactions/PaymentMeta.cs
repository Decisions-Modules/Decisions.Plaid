using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transactions
{
    /// <summary>Transaction information specific to inter-bank transfers. If the transaction was not an inter-bank transfer, all fields will be `null`.
    /// <br/>
    /// <br/>If the `transactions` object was returned by a Transactions endpoint such as `/transactions/get`, the `payment_meta` key will always appear, but no data elements are guaranteed. If the `transactions` object was returned by an Assets endpoint such as `/asset_report/get/` or `/asset_report/pdf/get`, this field will only appear in an Asset Report with Insights.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class PaymentMeta 
    {
        /// <summary>The transaction reference number supplied by the financial institution.</summary>
        [Newtonsoft.Json.JsonProperty("reference_number", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Reference_number { get; set; }
    
        /// <summary>The ACH PPD ID for the payer.</summary>
        [Newtonsoft.Json.JsonProperty("ppd_id", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Ppd_id { get; set; }
    
        /// <summary>For transfers, the party that is receiving the transaction.</summary>
        [Newtonsoft.Json.JsonProperty("payee", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Payee { get; set; }
    
        /// <summary>The party initiating a wire transfer. Will be `null` if the transaction is not a wire transfer.</summary>
        [Newtonsoft.Json.JsonProperty("by_order_of", Required = Newtonsoft.Json.Required.AllowNull)]
        public string By_order_of { get; set; }
    
        /// <summary>For transfers, the party that is paying the transaction.</summary>
        [Newtonsoft.Json.JsonProperty("payer", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Payer { get; set; }
    
        /// <summary>The type of transfer, e.g. 'ACH'</summary>
        [Newtonsoft.Json.JsonProperty("payment_method", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Payment_method { get; set; }
    
        /// <summary>The name of the payment processor</summary>
        [Newtonsoft.Json.JsonProperty("payment_processor", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Payment_processor { get; set; }
    
        /// <summary>The payer-supplied description of the transfer.</summary>
        [Newtonsoft.Json.JsonProperty("reason", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Reason { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}