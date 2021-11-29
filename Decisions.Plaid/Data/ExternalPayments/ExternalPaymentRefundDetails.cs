
using System.Runtime.Serialization;
using Decisions.Plaid.Data.PaymentInitiation;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.ExternalPayments
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class ExternalPaymentRefundDetails 
    {
        /// <summary>The name of the account holder.</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; }
    
        /// <summary>The International Bank Account Number (IBAN) for the account.</summary>
        [Newtonsoft.Json.JsonProperty("iban", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Iban { get; set; }
    
        [Newtonsoft.Json.JsonProperty("bacs", Required = Newtonsoft.Json.Required.AllowNull)]
        public RecipientBACSNullable Bacs { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}