using System.Runtime.Serialization;
using Decisions.Plaid.Data.Accounts;
using Decisions.Plaid.Data.Products;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Scope
{
    /// <summary>The scopes object</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class Scopes 
    {
        [Newtonsoft.Json.JsonProperty("product_access", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ProductAccess Product_access { get; set; }
    
        [Newtonsoft.Json.JsonProperty("accounts", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.Collection<AccountAccess> Accounts { get; set; }
    
        /// <summary>Allow access to newly opened accounts as they are opened. If unset, defaults to `true`.</summary>
        [Newtonsoft.Json.JsonProperty("new_accounts", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? New_accounts { get; set; } = true;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}