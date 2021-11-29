using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Investments
{
    /// <summary>Specify the security associated with the holding or investment transaction. When inputting custom security data to the Sandbox, Plaid will perform post-data-retrieval normalization and enrichment. These processes may cause the data returned by the Sandbox to be slightly different from the data you input. An ISO-4217 currency code and a security identifier (`ticker_symbol`, `cusip`, `isin`, or `sedol`) are required.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class SecurityOverride 
    {
        /// <summary>12-character ISIN, a globally unique securities identifier.</summary>
        [Newtonsoft.Json.JsonProperty("isin", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Isin { get; set; }
    
        /// <summary>9-character CUSIP, an identifier assigned to North American securities.</summary>
        [Newtonsoft.Json.JsonProperty("cusip", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Cusip { get; set; }
    
        /// <summary>7-character SEDOL, an identifier assigned to securities in the UK.</summary>
        [Newtonsoft.Json.JsonProperty("sedol", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Sedol { get; set; }
    
        /// <summary>A descriptive name for the security, suitable for display.</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        /// <summary>The security’s trading symbol for publicly traded securities, and otherwise a short identifier if available.</summary>
        [Newtonsoft.Json.JsonProperty("ticker_symbol", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Ticker_symbol { get; set; }
    
        /// <summary>Either a valid `iso_currency_code` or `unofficial_currency_code`</summary>
        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Currency { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}