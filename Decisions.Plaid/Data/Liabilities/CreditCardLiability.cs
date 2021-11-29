using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;


namespace Decisions.Plaid.Data.Liabilities
{
    /// <summary>An object representing a credit card account.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class CreditCardLiability 
    {
        /// <summary>The ID of the account that this liability belongs to.</summary>
        [Newtonsoft.Json.JsonProperty("account_id", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Account_id { get; set; }
    
        /// <summary>The various interest rates that apply to the account.</summary>
        [Newtonsoft.Json.JsonProperty("aprs", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<APR> Aprs { get; set; } = new System.Collections.ObjectModel.Collection<APR>();
    
        /// <summary>true if a payment is currently overdue. Availability for this field is limited.</summary>
        [Newtonsoft.Json.JsonProperty("is_overdue", Required = Newtonsoft.Json.Required.AllowNull)]
        public bool? Is_overdue { get; set; }
    
        /// <summary>The amount of the last payment.</summary>
        [Newtonsoft.Json.JsonProperty("last_payment_amount", Required = Newtonsoft.Json.Required.Always)]
        public double Last_payment_amount { get; set; }
    
        /// <summary>The date of the last payment. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD). Availability for this field is limited.</summary>
        [Newtonsoft.Json.JsonProperty("last_payment_date", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Last_payment_date { get; set; }
    
        /// <summary>The date of the last statement. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD).</summary>
        [Newtonsoft.Json.JsonProperty("last_statement_issue_date", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Last_statement_issue_date { get; set; }
    
        /// <summary>The total amount owed as of the last statement issued</summary>
        [Newtonsoft.Json.JsonProperty("last_statement_balance", Required = Newtonsoft.Json.Required.Always)]
        public double Last_statement_balance { get; set; }
    
        /// <summary>The minimum payment due for the next billing cycle.</summary>
        [Newtonsoft.Json.JsonProperty("minimum_payment_amount", Required = Newtonsoft.Json.Required.Always)]
        public double Minimum_payment_amount { get; set; }
    
        /// <summary>The due date for the next payment. The due date is `null` if a payment is not expected. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD).</summary>
        [Newtonsoft.Json.JsonProperty("next_payment_due_date", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Next_payment_due_date { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}