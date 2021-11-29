

using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Items
{
    /// <summary>Metadata about the Item.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class Item 
    {
        /// <summary>The Plaid Item ID. The `item_id` is always unique; linking the same account at the same institution twice will result in two Items with different `item_id` values. Like all Plaid identifiers, the `item_id` is case-sensitive.</summary>
        [Newtonsoft.Json.JsonProperty("item_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Item_id { get; set; }
    
        /// <summary>The Plaid Institution ID associated with the Item. Field is `null` for Items created via Same Day Micro-deposits.</summary>
        [Newtonsoft.Json.JsonProperty("institution_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Institution_id { get; set; }
    
        /// <summary>The URL registered to receive webhooks for the Item.</summary>
        [Newtonsoft.Json.JsonProperty("webhook", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Webhook { get; set; }
    
        [Newtonsoft.Json.JsonProperty("error", Required = Newtonsoft.Json.Required.AllowNull)]
        public Error Error { get; set; }
    
        /// <summary>A list of products available for the Item that have not yet been accessed.</summary>
        [Newtonsoft.Json.JsonProperty("available_products", Required = Newtonsoft.Json.Required.Always, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<Products.Products> Available_products { get; set; } = new System.Collections.ObjectModel.Collection<Products.Products>();
    
        /// <summary>A list of products that have been billed for the Item. Note - `billed_products` is populated in all environments but only requests in Production are billed.
        /// <br/></summary>
        [Newtonsoft.Json.JsonProperty("billed_products", Required = Newtonsoft.Json.Required.Always, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<Products.Products> Billed_products { get; set; } = new System.Collections.ObjectModel.Collection<Products.Products>();
    
        /// <summary>A list of authorized products for the Item.
        /// <br/></summary>
        [Newtonsoft.Json.JsonProperty("products", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public System.Collections.ObjectModel.Collection<Products.Products> Products { get; set; }
    
        /// <summary>The RFC 3339 timestamp after which the consent provided by the end user will expire. Upon consent expiration, the item will enter the `ITEM_LOGIN_REQUIRED` error state. To circumvent the `ITEM_LOGIN_REQUIRED` error and maintain continuous consent, the end user can reauthenticate via Link’s update mode in advance of the consent expiration time.
        /// <br/>
        /// <br/>Note - This is only relevant for certain OAuth-based institutions. For all other institutions, this field will be null.
        /// <br/></summary>
        [Newtonsoft.Json.JsonProperty("consent_expiration_time", Required = Newtonsoft.Json.Required.AllowNull)]
        public System.DateTime? Consent_expiration_time { get; set; }
    
        /// <summary>Indicates whether an Item requires user interaction to be updated, which can be the case for Items with some forms of two-factor authentication.
        /// <br/>
        /// <br/>`background` - Item can be updated in the background
        /// <br/>
        /// <br/>`user_present_required` - Item requires user interaction to be updated</summary>
        [Newtonsoft.Json.JsonProperty("update_type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ItemUpdate_type Update_type { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}