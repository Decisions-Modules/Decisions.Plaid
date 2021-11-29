

using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.PaymentInitiation.Recipient
{
    /// <summary>PaymentInitiationRecipient defines a payment initiation recipient</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class PaymentInitiationRecipient 
    {
        /// <summary>The ID of the recipient.</summary>
        [Newtonsoft.Json.JsonProperty("recipient_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Recipient_id { get; set; }
    
        /// <summary>The name of the recipient.</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PaymentInitiationAddress Address { get; set; }
    
        /// <summary>The International Bank Account Number (IBAN) for the recipient.</summary>
        [Newtonsoft.Json.JsonProperty("iban", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Iban { get; set; }
    
        [Newtonsoft.Json.JsonProperty("bacs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RecipientBACSNullable Bacs { get; set; }
    
        /// <summary>The EMI (E-Money Institution) recipient that this recipient is associated with, if any. This EMI recipient is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests.</summary>
        [Newtonsoft.Json.JsonProperty("emi_recipient_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Emi_recipient_id { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}