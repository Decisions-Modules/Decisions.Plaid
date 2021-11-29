using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Items.Application
{
    /// <summary>User authentication parameters, for clients making a request without an `access_token`. This is only allowed for select clients and will not be supported in the future. Most clients should call /item/import to obtain an access token before making a request.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class ItemApplicationListUserAuth 
    {
        /// <summary>Account username.</summary>
        [Newtonsoft.Json.JsonProperty("user_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string User_id { get; set; }
    
        /// <summary>Account username hashed by FI.</summary>
        [Newtonsoft.Json.JsonProperty("fi_username_hash", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Fi_username_hash { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}