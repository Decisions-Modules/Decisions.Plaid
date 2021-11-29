using System.Runtime.Serialization;
using Decisions.Plaid.Data.Accounts;
using Decisions.Plaid.Data.Accounts.Filters;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.LinkToken.Get
{
    /// <summary>An object specifying the arguments originally provided to the `/link/token/create` call.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class LinkTokenGetMetadataResponse 
    {
        /// <summary>The `products` specified in the `/link/token/create` call.</summary>
        [Newtonsoft.Json.JsonProperty("initial_products", Required = Newtonsoft.Json.Required.Always, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<Products.Products> Initial_products { get; set; } = new System.Collections.ObjectModel.Collection<Products.Products>();
    
        /// <summary>The `webhook` specified in the `/link/token/create` call.</summary>
        [Newtonsoft.Json.JsonProperty("webhook", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Webhook { get; set; }
    
        /// <summary>The `country_codes` specified in the `/link/token/create` call.</summary>
        [Newtonsoft.Json.JsonProperty("country_codes", Required = Newtonsoft.Json.Required.Always, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<CountryCode> Country_codes { get; set; } = new System.Collections.ObjectModel.Collection<CountryCode>();
    
        /// <summary>The `language` specified in the `/link/token/create` call.</summary>
        [Newtonsoft.Json.JsonProperty("language", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Language { get; set; }
    
        [Newtonsoft.Json.JsonProperty("account_filters", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AccountFiltersResponse Account_filters { get; set; }
    
        /// <summary>The `redirect_uri` specified in the `/link/token/create` call.</summary>
        [Newtonsoft.Json.JsonProperty("redirect_uri", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Redirect_uri { get; set; }
    
        /// <summary>The `client_name` specified in the `/link/token/create` call.</summary>
        [Newtonsoft.Json.JsonProperty("client_name", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Client_name { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}