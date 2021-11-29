using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Liabilities
{
    /// <summary>Object containing fields describing property address.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class MortgagePropertyAddress 
    {
        /// <summary>The city name.</summary>
        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.AllowNull)]
        public string City { get; set; }
    
        /// <summary>The ISO 3166-1 alpha-2 country code.</summary>
        [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Country { get; set; }
    
        /// <summary>The five or nine digit postal code.</summary>
        [Newtonsoft.Json.JsonProperty("postal_code", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Postal_code { get; set; }
    
        /// <summary>The region or state (example "NC").</summary>
        [Newtonsoft.Json.JsonProperty("region", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Region { get; set; }
    
        /// <summary>The full street address (example "564 Main Street, Apt 15").</summary>
        [Newtonsoft.Json.JsonProperty("street", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Street { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}