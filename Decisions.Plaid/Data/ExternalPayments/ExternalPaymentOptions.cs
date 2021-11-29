using System.Runtime.Serialization;
using Decisions.Plaid.Data.PaymentInitiation;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.ExternalPayments
{
    /// <summary>Additional payment options</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class ExternalPaymentOptions 
    {
        /// <summary>When `true`, Plaid will attempt to request refund details from the payee's financial institution.  Support varies between financial institutions and will not always be available.  If refund details could be retrieved, they will be available in the `/payment_initiation/payment/get` response.</summary>
        [Newtonsoft.Json.JsonProperty("request_refund_details", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Request_refund_details { get; set; }
    
        /// <summary>The International Bank Account Number (IBAN) for the payer's account. If provided, the end user will be able to send payments only from the specified bank account.</summary>
        [Newtonsoft.Json.JsonProperty("iban", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(34, MinimumLength = 15)]
        public string Iban { get; set; }
    
        [Newtonsoft.Json.JsonProperty("bacs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PaymentInitiationOptionalRestrictionBacs Bacs { get; set; }
    
        /// <summary>The EMI (E-Money Institution) account that this payment is associated with, if any. This EMI account is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests.</summary>
        [Newtonsoft.Json.JsonProperty("emi_account_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 1)]
        public string Emi_account_id { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}