using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Accounts
{
    /// <summary>Allow the application to access specific products on this account</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class AccountProductAccess 
    {
        /// <summary>Allow the application to access account data. Only used by certain partners. If relevant to the partner and unset, defaults to `true`.</summary>
        [Newtonsoft.Json.JsonProperty("account_data", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Account_data { get; set; } = true;
    
        /// <summary>Allow the application to access bank statements. Only used by certain partners. If relevant to the partner and unset, defaults to `true`.</summary>
        [Newtonsoft.Json.JsonProperty("statements", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Statements { get; set; } = true;
    
        /// <summary>Allow the application to access tax documents. Only used by certain partners. If relevant to the partner and unset, defaults to `true`.</summary>
        [Newtonsoft.Json.JsonProperty("tax_documents", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Tax_documents { get; set; } = true;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
} 