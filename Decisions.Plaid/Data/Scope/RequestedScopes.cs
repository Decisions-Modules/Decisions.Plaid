using System.Runtime.Serialization;
using Decisions.Plaid.Data.Accounts;
using Decisions.Plaid.Data.Accounts.Filters;
using Decisions.Plaid.Data.Products;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Scope
{
    /// <summary>Scope of required and optional account features or content from a ConnectedApplication.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class RequestedScopes 
    {
        [Newtonsoft.Json.JsonProperty("required_product_access", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ProductAccess Required_product_access { get; set; } = new ProductAccess();
    
        [Newtonsoft.Json.JsonProperty("optional_product_access", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ProductAccess Optional_product_access { get; set; } = new ProductAccess();
    
        [Newtonsoft.Json.JsonProperty("account_filters", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AccountFilter Account_filters { get; set; }
    
        [Newtonsoft.Json.JsonProperty("account_selection_cardinality", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AccountSelectionCardinality Account_selection_cardinality { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}