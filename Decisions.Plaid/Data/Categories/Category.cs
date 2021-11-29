using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Categories
{
    /// <summary>Information describing a transaction category</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class Category 
    {
        /// <summary>An identifying number for the category. `category_id` is a Plaid-specific identifier and does not necessarily correspond to merchant category codes.</summary>
        [Newtonsoft.Json.JsonProperty("category_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Category_id { get; set; }
    
        /// <summary>`place` for physical transactions or `special` for other transactions such as bank charges.</summary>
        [Newtonsoft.Json.JsonProperty("group", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Group { get; set; }
    
        /// <summary>A hierarchical array of the categories to which this `category_id` belongs.</summary>
        [Newtonsoft.Json.JsonProperty("hierarchy", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<string> Hierarchy { get; set; } = new System.Collections.ObjectModel.Collection<string>();
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}