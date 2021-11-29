using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transactions.Stream
{
    /// <summary>Object with data pertaining to an amount on the transaction stream.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class TransactionStreamAmount 
    {
        /// <summary>represents the numerical value of an amount.</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Amount { get; set; }
    
        /// <summary>The ISO-4217 currency code of the amount. Always `null` if `unofficial_currency_code` is non-`null`.
        /// <br/>
        /// <br/>See the [currency code schema](https://plaid.com/docs/api/accounts#currency-code-schema) for a full listing of supported `iso_currency_code`s.</summary>
        [Newtonsoft.Json.JsonProperty("iso_currency_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Iso_currency_code { get; set; }
    
        /// <summary>The unofficial currency code of the amount. Always `null` if `iso_currency_code` is non-`null`. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.</summary>
        [Newtonsoft.Json.JsonProperty("unofficial_currency_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
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