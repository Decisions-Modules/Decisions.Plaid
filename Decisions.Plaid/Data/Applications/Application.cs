using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Applications
{
    /// <summary>Metadata about the application</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class Application 
    {
        [Newtonsoft.Json.JsonProperty("application_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Application_id { get; set; }
    
        /// <summary>The name of the application</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; }
    
        /// <summary>The date this application was linked in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) (YYYY-MM-DD) format in UTC.</summary>
        [Newtonsoft.Json.JsonProperty("created_at", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Created_at { get; set; }
    
        /// <summary>A URL that links to the application logo image.</summary>
        [Newtonsoft.Json.JsonProperty("logo_url", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Logo_url { get; set; }
    
        /// <summary>The URL for the application's website</summary>
        [Newtonsoft.Json.JsonProperty("application_url", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Application_url { get; set; }
    
        /// <summary>A string provided by the connected app stating why they use their respective enabled products.</summary>
        [Newtonsoft.Json.JsonProperty("reason_for_access", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Reason_for_access { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}