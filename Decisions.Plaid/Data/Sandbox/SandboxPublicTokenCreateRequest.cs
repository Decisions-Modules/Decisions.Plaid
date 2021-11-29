using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Sandbox
{
    /// <summary>SandboxPublicTokenCreateRequest defines the request schema for `/sandbox/public_token/create`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class SandboxPublicTokenCreateRequest 
    {
        [Newtonsoft.Json.JsonProperty("client_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Client_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("secret", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Secret { get; set; }
    
        /// <summary>The ID of the institution the Item will be associated with</summary>
        [Newtonsoft.Json.JsonProperty("institution_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Institution_id { get; set; }
    
        /// <summary>The products to initially pull for the Item. May be any products that the specified `institution_id`  supports. This array may not be empty.</summary>
        [Newtonsoft.Json.JsonProperty("initial_products", Required = Newtonsoft.Json.Required.Always, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        public System.Collections.ObjectModel.Collection<Products.Products> Initial_products { get; set; } = new System.Collections.ObjectModel.Collection<Products.Products>();
    
        [Newtonsoft.Json.JsonProperty("options", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SandboxPublicTokenCreateRequestOptions Options { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}