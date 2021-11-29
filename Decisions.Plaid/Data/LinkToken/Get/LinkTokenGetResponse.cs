using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.LinkToken.Get
{
    /// <summary>LinkTokenGetResponse defines the response schema for `/link/token/get`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class LinkTokenGetResponse 
    {
        /// <summary>A `link_token`, which can be supplied to Link in order to initialize it and receive a `public_token`, which can be exchanged for an `access_token`.</summary>
        [Newtonsoft.Json.JsonProperty("link_token", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Link_token { get; set; }
    
        /// <summary>The creation timestamp for the `link_token`, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format.</summary>
        [Newtonsoft.Json.JsonProperty("created_at", Required = Newtonsoft.Json.Required.AllowNull)]
        public System.DateTime? Created_at { get; set; }
    
        /// <summary>The expiration timestamp for the `link_token`, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format.</summary>
        [Newtonsoft.Json.JsonProperty("expiration", Required = Newtonsoft.Json.Required.AllowNull)]
        public System.DateTime? Expiration { get; set; }
    
        [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public LinkTokenGetMetadataResponse Metadata { get; set; } = new LinkTokenGetMetadataResponse();
    
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