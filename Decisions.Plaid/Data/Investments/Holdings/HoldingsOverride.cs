using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Investments.Holdings
{
    /// <summary>Specify the holdings on the account.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class HoldingsOverride 
    {
        /// <summary>The last price given by the institution for this security</summary>
        [Newtonsoft.Json.JsonProperty("institution_price", Required = Newtonsoft.Json.Required.Always)]
        public double Institution_price { get; set; }
    
        /// <summary>The date at which `institution_price` was current. Must be formatted as an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) date.</summary>
        [Newtonsoft.Json.JsonProperty("institution_price_as_of", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Institution_price_as_of { get; set; }
    
        /// <summary>The average original value of the holding. Multiple cost basis values for the same security purchased at different prices are not supported.</summary>
        [Newtonsoft.Json.JsonProperty("cost_basis", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Cost_basis { get; set; }
    
        /// <summary>The total quantity of the asset held, as reported by the financial institution.</summary>
        [Newtonsoft.Json.JsonProperty("quantity", Required = Newtonsoft.Json.Required.Always)]
        public double Quantity { get; set; }
    
        /// <summary>Either a valid `iso_currency_code` or `unofficial_currency_code`</summary>
        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Currency { get; set; }
    
        [Newtonsoft.Json.JsonProperty("security", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public SecurityOverride Security { get; set; } = new SecurityOverride();
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}