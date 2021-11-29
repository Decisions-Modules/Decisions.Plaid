using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Auth
{
    /// <summary>Metadata specifically related to which auth methods an institution supports.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class AuthSupportedMethods 
    {
        /// <summary>Indicates if instant auth is supported.</summary>
        [Newtonsoft.Json.JsonProperty("instant_auth", Required = Newtonsoft.Json.Required.Always)]
        public bool Instant_auth { get; set; }
    
        /// <summary>Indicates if instant match is supported.</summary>
        [Newtonsoft.Json.JsonProperty("instant_match", Required = Newtonsoft.Json.Required.Always)]
        public bool Instant_match { get; set; }
    
        /// <summary>Indicates if automated microdeposits are supported.</summary>
        [Newtonsoft.Json.JsonProperty("automated_micro_deposits", Required = Newtonsoft.Json.Required.Always)]
        public bool Automated_micro_deposits { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}