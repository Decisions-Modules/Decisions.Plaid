

using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;


namespace Decisions.Plaid.Data.Transactions
{
    /// <summary>A representation of a transaction</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class Transaction : TransactionBase
    {
        /// <summary>The channel used to make a payment.
        /// <br/>`online:` transactions that took place online.
        /// <br/>
        /// <br/>`in store:` transactions that were made at a physical location.
        /// <br/>
        /// <br/>`other:` transactions that relate to banks, e.g. fees or deposits.
        /// <br/>
        /// <br/>This field replaces the `transaction_type` field.
        /// <br/></summary>
        [Newtonsoft.Json.JsonProperty("payment_channel", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TransactionPayment_channel Payment_channel { get; set; }
    
        /// <summary>The date that the transaction was authorized. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format ( `YYYY-MM-DD` ).</summary>
        [Newtonsoft.Json.JsonProperty("authorized_date", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Authorized_date { get; set; }
    
        /// <summary>Date and time when a transaction was authorized in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format ( `YYYY-MM-DDTHH:mm:ssZ` ).
        /// <br/>
        /// <br/>This field is only populated for UK institutions. For institutions in other countries, will be `null`.</summary>
        [Newtonsoft.Json.JsonProperty("authorized_datetime", Required = Newtonsoft.Json.Required.AllowNull)]
        public System.DateTime? Authorized_datetime { get; set; }
    
        /// <summary>Date and time when a transaction was posted in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format ( `YYYY-MM-DDTHH:mm:ssZ` ).
        /// <br/>
        /// <br/>This field is only populated for UK institutions. For institutions in other countries, will be `null`.</summary>
        [Newtonsoft.Json.JsonProperty("datetime", Required = Newtonsoft.Json.Required.AllowNull)]
        public System.DateTime? Datetime { get; set; }
    
        [Newtonsoft.Json.JsonProperty("transaction_code", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TransactionCode? Transaction_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("personal_finance_category", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PersonalFinanceCategory Personal_finance_category { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}