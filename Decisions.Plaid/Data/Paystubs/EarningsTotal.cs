using System.Runtime.Serialization;
using Decisions.Plaid.Data.Employees;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Paystubs
{
    /// <summary>An object representing both the current pay period and year to date amount for an earning category.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class EarningsTotal 
    {
        /// <summary>Total amount of the earnings for this pay period</summary>
        [Newtonsoft.Json.JsonProperty("current_amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Current_amount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("current_pay", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Pay Current_pay { get; set; }
    
        [Newtonsoft.Json.JsonProperty("ytd_pay", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Pay Ytd_pay { get; set; }
    
        /// <summary>Total number of hours worked for this pay period</summary>
        [Newtonsoft.Json.JsonProperty("hours", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Hours { get; set; }
    
        /// <summary>The ISO-4217 currency code of the line item. Always `null` if `unofficial_currency_code` is non-null.</summary>
        [Newtonsoft.Json.JsonProperty("iso_currency_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Iso_currency_code { get; set; }
    
        /// <summary>The unofficial currency code associated with the security. Always `null` if `iso_currency_code` is non-`null`. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.
        /// <br/>
        /// <br/>See the [currency code schema](https://plaid.com/docs/api/accounts#currency-code-schema) for a full listing of supported `iso_currency_code`s.</summary>
        [Newtonsoft.Json.JsonProperty("unofficial_currency_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Unofficial_currency_code { get; set; }
    
        /// <summary>The total year-to-date amount of the earnings</summary>
        [Newtonsoft.Json.JsonProperty("ytd_amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Ytd_amount { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}