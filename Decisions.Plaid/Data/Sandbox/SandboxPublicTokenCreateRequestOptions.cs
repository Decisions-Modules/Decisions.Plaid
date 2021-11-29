using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Sandbox
{
    /// <summary>An optional set of options to be used when configuring the Item. If specified, must not be `null`.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class SandboxPublicTokenCreateRequestOptions 
    {
        /// <summary>Specify a webhook to associate with the new Item.</summary>
        [Newtonsoft.Json.JsonProperty("webhook", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Webhook { get; set; }
    
        [Newtonsoft.Json.JsonProperty("override_username", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Override_username { get; set; }
    
        [Newtonsoft.Json.JsonProperty("override_password", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Override_password { get; set; }
    
        [Newtonsoft.Json.JsonProperty("transactions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SandboxPublicTokenCreateRequestOptionsTransactions Transactions { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}