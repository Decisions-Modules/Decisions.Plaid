using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;

using Decisions.Plaid.Data.Products;
using Decisions.Plaid.Data.Scope;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Items
{
    /// <summary>Describes the connected application for a particular end user.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class ConnectedApplication 
    {
        [Newtonsoft.Json.JsonProperty("application_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Application_id { get; set; }
    
        /// <summary>The name of the application</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; }
    
        /// <summary>A URL that links to the application logo image (will be deprecated in the future, please use logo_url).</summary>
        [Newtonsoft.Json.JsonProperty("logo", Required = Newtonsoft.Json.Required.AllowNull)]
        [System.Obsolete]
        public string Logo { get; set; }
    
        /// <summary>A URL that links to the application logo image.</summary>
        [Newtonsoft.Json.JsonProperty("logo_url", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Logo_url { get; set; }
    
        /// <summary>The URL for the application's website</summary>
        [Newtonsoft.Json.JsonProperty("application_url", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Application_url { get; set; }
    
        /// <summary>A string provided by the connected app stating why they use their respective enabled products.</summary>
        [Newtonsoft.Json.JsonProperty("reason_for_access", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Reason_for_access { get; set; }
    
        /// <summary>The date this application was linked in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) (YYYY-MM-DD) format in UTC.</summary>
        [Newtonsoft.Json.JsonProperty("created_at", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Created_at { get; set; }
    
        /// <summary>(Deprecated) A list of enums representing the data collected and products enabled for this connected application.</summary>
        [Newtonsoft.Json.JsonProperty("product_data_types", Required = Newtonsoft.Json.Required.Always, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<Product_data_types> Product_data_types { get; set; } = new System.Collections.ObjectModel.Collection<Product_data_types>();
    
        [Newtonsoft.Json.JsonProperty("scopes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ScopesNullable Scopes { get; set; }
    
        [Newtonsoft.Json.JsonProperty("requested_scopes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RequestedScopes Requested_scopes { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}