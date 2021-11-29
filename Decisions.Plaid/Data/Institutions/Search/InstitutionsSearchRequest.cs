

using System.Runtime.Serialization;
using Decisions.Plaid.Data.Accounts;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Institutions.Search
{
    /// <summary>InstitutionsSearchRequest defines the request schema for `/institutions/search`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class InstitutionsSearchRequest 
    {
        [Newtonsoft.Json.JsonProperty("client_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Client_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("secret", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Secret { get; set; }
    
        /// <summary>The search query. Institutions with names matching the query are returned</summary>
        [Newtonsoft.Json.JsonProperty("query", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Query { get; set; }
    
        /// <summary>Filter the Institutions based on whether they support all products listed in `products`. Provide `null` to get institutions regardless of supported products. Note that when `auth` is specified as a product, if you are enabled for Instant Match or Automated Micro-deposits, institutions that support those products will be returned even if `auth` is not present in their product array.</summary>
        [Newtonsoft.Json.JsonProperty("products", Required = Newtonsoft.Json.Required.Always, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        public System.Collections.ObjectModel.Collection<Products.Products> Products { get; set; } = new System.Collections.ObjectModel.Collection<Products.Products>();
    
        /// <summary>Specify an array of Plaid-supported country codes this institution supports, using the ISO-3166-1 alpha-2 country code standard.
        /// <br/></summary>
        [Newtonsoft.Json.JsonProperty("country_codes", Required = Newtonsoft.Json.Required.Always, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<CountryCode> Country_codes { get; set; } = new System.Collections.ObjectModel.Collection<CountryCode>();
    
        [Newtonsoft.Json.JsonProperty("options", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public InstitutionsSearchRequestOptions Options { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}