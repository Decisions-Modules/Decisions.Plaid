using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Webhooks
{
    /// <summary>The `USER_PERMISSION_REVOKED` webhook is fired to when an end user has used the [my.plaid.com portal](https://my.plaid.com) to revoke the permission that they previously granted to access an Item. Once access to an Item has been revoked, it cannot be restored. If the user subsequently returns to your application, a new Item must be created for the user.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class UserPermissionRevokedWebhook 
    {
        /// <summary>`ITEM`</summary>
        [Newtonsoft.Json.JsonProperty("webhook_type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Webhook_type { get; set; }
    
        /// <summary>`USER_PERMISSION_REVOKED`</summary>
        [Newtonsoft.Json.JsonProperty("webhook_code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Webhook_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("item_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Item_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("error", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Error Error { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}