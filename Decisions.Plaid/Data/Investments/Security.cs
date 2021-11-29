using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Investments
{
    /// <summary>Contains details about a security</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class Security 
    {
        /// <summary>A unique, Plaid-specific identifier for the security, used to associate securities with holdings. Like all Plaid identifiers, the `security_id` is case sensitive.</summary>
        [Newtonsoft.Json.JsonProperty("security_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Security_id { get; set; }
    
        /// <summary>12-character ISIN, a globally unique securities identifier.</summary>
        [Newtonsoft.Json.JsonProperty("isin", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Isin { get; set; }
    
        /// <summary>9-character CUSIP, an identifier assigned to North American securities.</summary>
        [Newtonsoft.Json.JsonProperty("cusip", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Cusip { get; set; }
    
        /// <summary>7-character SEDOL, an identifier assigned to securities in the UK.</summary>
        [Newtonsoft.Json.JsonProperty("sedol", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Sedol { get; set; }
    
        /// <summary>An identifier given to the security by the institution</summary>
        [Newtonsoft.Json.JsonProperty("institution_security_id", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Institution_security_id { get; set; }
    
        /// <summary>If `institution_security_id` is present, this field indicates the Plaid `institution_id` of the institution to whom the identifier belongs.</summary>
        [Newtonsoft.Json.JsonProperty("institution_id", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Institution_id { get; set; }
    
        /// <summary>In certain cases, Plaid will provide the ID of another security whose performance resembles this security, typically when the original security has low volume, or when a private security can be modeled with a publicly traded security.</summary>
        [Newtonsoft.Json.JsonProperty("proxy_security_id", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Proxy_security_id { get; set; }
    
        /// <summary>A descriptive name for the security, suitable for display.</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Name { get; set; }
    
        /// <summary>The security’s trading symbol for publicly traded securities, and otherwise a short identifier if available.</summary>
        [Newtonsoft.Json.JsonProperty("ticker_symbol", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Ticker_symbol { get; set; }
    
        /// <summary>Indicates that a security is a highly liquid asset and can be treated like cash.</summary>
        [Newtonsoft.Json.JsonProperty("is_cash_equivalent", Required = Newtonsoft.Json.Required.AllowNull)]
        public bool? Is_cash_equivalent { get; set; }
    
        /// <summary>The security type of the holding. Valid security types are:
        /// <br/>
        /// <br/>`cash`: Cash, currency, and money market funds
        /// <br/>
        /// <br/>`derivative`: Options, warrants, and other derivative instruments
        /// <br/>
        /// <br/>`equity`: Domestic and foreign equities
        /// <br/>
        /// <br/>`etf`: Multi-asset exchange-traded investment funds
        /// <br/>
        /// <br/>`fixed income`: Bonds and certificates of deposit (CDs)
        /// <br/>
        /// <br/>`loan`: Loans and loan receivables.
        /// <br/>
        /// <br/>`mutual fund`: Open- and closed-end vehicles pooling funds of multiple investors.
        /// <br/>
        /// <br/>`other`: Unknown or other investment types</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Type { get; set; }
    
        /// <summary>Price of the security at the close of the previous trading session. `null` for non-public securities. If the security is a foreign currency or a cryptocurrency this field will be updated daily and will be priced in USD.</summary>
        [Newtonsoft.Json.JsonProperty("close_price", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Close_price { get; set; }
    
        /// <summary>Date for which `close_price` is accurate. Always `null` if `close_price` is `null`.</summary>
        [Newtonsoft.Json.JsonProperty("close_price_as_of", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Close_price_as_of { get; set; }
    
        /// <summary>The ISO-4217 currency code of the price given. Always `null` if `unofficial_currency_code` is non-`null`.</summary>
        [Newtonsoft.Json.JsonProperty("iso_currency_code", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Iso_currency_code { get; set; }
    
        /// <summary>The unofficial currency code associated with the security. Always `null` if `iso_currency_code` is non-`null`. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.
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