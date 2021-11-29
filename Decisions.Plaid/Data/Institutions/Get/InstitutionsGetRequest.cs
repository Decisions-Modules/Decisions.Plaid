

using System.Runtime.Serialization;
using Decisions.Plaid.Data.Accounts;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Institutions.Get
{
    /// <summary>InstitutionsGetRequest defines the request schema for `/institutions/get`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class InstitutionsGetRequest 
    {
        [Newtonsoft.Json.JsonProperty("client_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Client_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("secret", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Secret { get; set; }
    
        /// <summary>The total number of Institutions to return.</summary>
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(int.MinValue, 500)]
        public int Count { get; set; }
    
        /// <summary>The number of Institutions to skip.</summary>
        [Newtonsoft.Json.JsonProperty("offset", Required = Newtonsoft.Json.Required.Always)]
        public int Offset { get; set; }
    
        /// <summary>Specify an array of Plaid-supported country codes this institution supports, using the ISO-3166-1 alpha-2 country code standard.
        /// <br/></summary>
        [Newtonsoft.Json.JsonProperty("country_codes", Required = Newtonsoft.Json.Required.Always, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        public System.Collections.ObjectModel.Collection<CountryCode> Country_codes { get; set; } = new System.Collections.ObjectModel.Collection<CountryCode>();
    
        [Newtonsoft.Json.JsonProperty("options", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public InstitutionsGetRequestOptions Options { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}