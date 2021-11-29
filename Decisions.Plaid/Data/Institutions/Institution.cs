
using System.Runtime.Serialization;
using Decisions.Plaid.Data.Accounts;
using Decisions.Plaid.Data.Auth;
using Decisions.Plaid.Data.PaymentInitiation;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Institutions
{
    /// <summary>Details relating to a specific financial institution</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class Institution 
    {
        /// <summary>Unique identifier for the institution</summary>
        [Newtonsoft.Json.JsonProperty("institution_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Institution_id { get; set; }
    
        /// <summary>The official name of the institution</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; }
    
        /// <summary>A list of the Plaid products supported by the institution. Note that only institutions that support Instant Auth will return `auth` in the product array; institutions that do not list `auth` may still support other Auth methods such as Instant Match or Automated Micro-deposit Verification. For more details, see [Full Auth coverage](https://plaid.com/docs/auth/coverage/).</summary>
        [Newtonsoft.Json.JsonProperty("products", Required = Newtonsoft.Json.Required.Always, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<Products.Products> Products { get; set; } = new System.Collections.ObjectModel.Collection<Products.Products>();
    
        /// <summary>A list of the country codes supported by the institution.</summary>
        [Newtonsoft.Json.JsonProperty("country_codes", Required = Newtonsoft.Json.Required.Always, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<CountryCode> Country_codes { get; set; } = new System.Collections.ObjectModel.Collection<CountryCode>();
    
        /// <summary>The URL for the institution's website</summary>
        [Newtonsoft.Json.JsonProperty("url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Url { get; set; }
    
        /// <summary>Hexadecimal representation of the primary color used by the institution</summary>
        [Newtonsoft.Json.JsonProperty("primary_color", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Primary_color { get; set; }
    
        /// <summary>Base64 encoded representation of the institution's logo</summary>
        [Newtonsoft.Json.JsonProperty("logo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Logo { get; set; }
    
        /// <summary>A  list of routing numbers associated with the institution. This list is provided for the purpose of looking up institutions by routing number. It is not comprehensive and should never be used as a complete list of routing numbers for an institution.</summary>
        [Newtonsoft.Json.JsonProperty("routing_numbers", Required = Newtonsoft.Json.Required.AllowNull)]
        public System.Collections.ObjectModel.Collection<string> Routing_numbers { get; set; }
    
        /// <summary>Indicates that the institution has an OAuth login flow. This is primarily relevant to institutions with European country codes.</summary>
        [Newtonsoft.Json.JsonProperty("oauth", Required = Newtonsoft.Json.Required.Always)]
        public bool Oauth { get; set; }
    
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public InstitutionStatus Status { get; set; }
    
        [Newtonsoft.Json.JsonProperty("payment_initiation_metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PaymentInitiationMetadata Payment_initiation_metadata { get; set; }
    
        [Newtonsoft.Json.JsonProperty("auth_metadata", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AuthMetadata Auth_metadata { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}