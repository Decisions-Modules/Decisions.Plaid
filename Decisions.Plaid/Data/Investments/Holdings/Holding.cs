using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Investments.Holdings
{
    /// <summary>A securities holding at an institution.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class Holding 
    {
        /// <summary>The Plaid `account_id` associated with the holding.</summary>
        [Newtonsoft.Json.JsonProperty("account_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Account_id { get; set; }
    
        /// <summary>The Plaid `security_id` associated with the holding.</summary>
        [Newtonsoft.Json.JsonProperty("security_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Security_id { get; set; }
    
        /// <summary>The last price given by the institution for this security.</summary>
        [Newtonsoft.Json.JsonProperty("institution_price", Required = Newtonsoft.Json.Required.Always)]
        public double Institution_price { get; set; }
    
        /// <summary>The date at which `institution_price` was current.</summary>
        [Newtonsoft.Json.JsonProperty("institution_price_as_of", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Institution_price_as_of { get; set; }
    
        /// <summary>The value of the holding, as reported by the institution.</summary>
        [Newtonsoft.Json.JsonProperty("institution_value", Required = Newtonsoft.Json.Required.Always)]
        public double Institution_value { get; set; }
    
        /// <summary>The cost basis of the holding.</summary>
        [Newtonsoft.Json.JsonProperty("cost_basis", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Cost_basis { get; set; }
    
        /// <summary>The total quantity of the asset held, as reported by the financial institution. If the security is an option, `quantity` will reflect the total number of options (typically the number of contracts multiplied by 100), not the number of contracts.</summary>
        [Newtonsoft.Json.JsonProperty("quantity", Required = Newtonsoft.Json.Required.Always)]
        public double Quantity { get; set; }
    
        /// <summary>The ISO-4217 currency code of the holding. Always `null` if `unofficial_currency_code` is non-`null`.</summary>
        [Newtonsoft.Json.JsonProperty("iso_currency_code", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Iso_currency_code { get; set; }
    
        /// <summary>The unofficial currency code associated with the holding. Always `null` if `iso_currency_code` is non-`null`. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.
        /// <br/>
        /// <br/>See the [currency code schema](https://plaid.com/docs/api/accounts#currency-code-schema) for a full listing of supported `iso_currency_code`s.
        /// <br/></summary>
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