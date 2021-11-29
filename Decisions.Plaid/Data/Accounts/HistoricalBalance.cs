using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;


namespace Decisions.Plaid.Data.Accounts
{
    /// <summary>An object representing a balance held by an account in the past</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class HistoricalBalance 
    {
        /// <summary>The date of the calculated historical balance, in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD)</summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Date { get; set; }
    
        /// <summary>The total amount of funds in the account, calculated from the `current` balance in the `balance` object by subtracting inflows and adding back outflows according to the posted date of each transaction.
        /// <br/>
        /// <br/>If the account has any pending transactions, historical balance amounts on or after the date of the earliest pending transaction may differ if retrieved in subsequent Asset Reports as a result of those pending transactions posting.</summary>
        [Newtonsoft.Json.JsonProperty("current", Required = Newtonsoft.Json.Required.Always)]
        public double Current { get; set; }
    
        /// <summary>The ISO-4217 currency code of the balance. Always `null` if `unofficial_currency_code` is non-`null`.</summary>
        [Newtonsoft.Json.JsonProperty("iso_currency_code", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Iso_currency_code { get; set; }
    
        /// <summary>The unofficial currency code associated with the balance. Always `null` if `iso_currency_code` is non-`null`.
        /// <br/>
        /// <br/>See the [currency code schema](https://plaid.com/docs/api/accounts#currency-code-schema) for a full listing of supported `iso_currency_code`s.</summary>
        [Newtonsoft.Json.JsonProperty("unofficial_currency_code", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Unofficial_currency_code { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}