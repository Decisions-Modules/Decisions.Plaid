using System.Runtime.Serialization;
using Decisions.Plaid.Data.Employees;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Paystubs
{
    /// <summary>Information about the accounts that the payment was distributed to.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class DistributionBreakdown 
    {
        /// <summary>Name of the account for the given distribution.</summary>
        [Newtonsoft.Json.JsonProperty("account_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Account_name { get; set; }
    
        /// <summary>The name of the bank that the payment is being deposited to.</summary>
        [Newtonsoft.Json.JsonProperty("bank_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Bank_name { get; set; }
    
        /// <summary>The amount distributed to this account.</summary>
        [Newtonsoft.Json.JsonProperty("current_amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Current_amount { get; set; }
    
        /// <summary>The ISO-4217 currency code of the net pay. Always `null` if `unofficial_currency_code` is non-null.</summary>
        [Newtonsoft.Json.JsonProperty("iso_currency_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Iso_currency_code { get; set; }
    
        /// <summary>The last 2-4 alphanumeric characters of an account's official account number.</summary>
        [Newtonsoft.Json.JsonProperty("mask", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Mask { get; set; }
    
        /// <summary>Type of the account that the paystub was sent to (e.g. 'checking').</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }
    
        /// <summary>The unofficial currency code associated with the net pay. Always `null` if `iso_currency_code` is non-`null`. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.
        /// <br/>
        /// <br/>See the [currency code schema](https://plaid.com/docs/api/accounts#currency-code-schema) for a full listing of supported `iso_currency_code`s.</summary>
        [Newtonsoft.Json.JsonProperty("unofficial_currency_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Unofficial_currency_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("current_pay", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Pay Current_pay { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}