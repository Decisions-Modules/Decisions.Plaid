using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Products
{
    /// <summary>The product access being requested. Used to or disallow product access across all accounts. If unset, defaults to all products allowed.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class ProductAccess 
    {
        /// <summary>Allow access to statements. Only used by certain partners. If relevant to the partner and unset, defaults to `true`.</summary>
        [Newtonsoft.Json.JsonProperty("statements", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Statements { get; set; } = true;
    
        /// <summary>Allow access to the Identity product (name, email, phone, address). Only used by certain partners. If relevant to the partner and unset, defaults to `true`.</summary>
        [Newtonsoft.Json.JsonProperty("identity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Identity { get; set; } = true;
    
        /// <summary>Allow access to account number details. Only used by certain partners. If relevant to the partner and unset, defaults to `true`.</summary>
        [Newtonsoft.Json.JsonProperty("auth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Auth { get; set; } = true;
    
        /// <summary>Allow access to transaction details. Only used by certain partners. If relevant to the partner and unset, defaults to `true`.</summary>
        [Newtonsoft.Json.JsonProperty("transactions", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Transactions { get; set; } = true;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}