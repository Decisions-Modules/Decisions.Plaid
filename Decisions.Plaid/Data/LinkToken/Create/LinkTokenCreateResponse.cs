using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.LinkToken.Create
{
    /// <summary>LinkTokenCreateResponse defines the response schema for `/link/token/create`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class LinkTokenCreateResponse 
    {
        /// <summary>A `link_token`, which can be supplied to Link in order to initialize it and receive a `public_token`, which can be exchanged for an `access_token`.</summary>
        [Newtonsoft.Json.JsonProperty("link_token", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Link_token { get; set; }
    
        /// <summary>The expiration date for the `link_token`, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format. A `link_token` created to generate a `public_token` that will be exchanged for a new `access_token` expires after 4 hours. A `link_token` created for an existing Item (such as when updating an existing `access_token` by launching Link in update mode) expires after 30 minutes.</summary>
        [Newtonsoft.Json.JsonProperty("expiration", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTime Expiration { get; set; }
    
        [Newtonsoft.Json.JsonProperty("request_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Request_id { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}