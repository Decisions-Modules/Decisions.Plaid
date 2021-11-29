using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Institutions.Get
{
    /// <summary>An optional object to filter `/institutions/get` results.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class InstitutionsGetRequestOptions 
    {
        /// <summary>Filter the Institutions based on which products they support. </summary>
        [Newtonsoft.Json.JsonProperty("products", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public System.Collections.ObjectModel.Collection<Products.Products> Products { get; set; }
    
        /// <summary>Specify an array of routing numbers to filter institutions. The response will only return institutions that match all of the routing numbers in the array.</summary>
        [Newtonsoft.Json.JsonProperty("routing_numbers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.Collection<string> Routing_numbers { get; set; }
    
        /// <summary>Limit results to institutions with or without OAuth login flows. This is primarily relevant to institutions with European country codes.</summary>
        [Newtonsoft.Json.JsonProperty("oauth", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Oauth { get; set; }
    
        /// <summary>When `true`, return the institution's homepage URL, logo and primary brand color.
        /// <br/>
        /// <br/>Note that Plaid does not own any of the logos shared by the API, and that by accessing or using these logos, you agree that you are doing so at your own risk and will, if necessary, obtain all required permissions from the appropriate rights holders and adhere to any applicable usage guidelines. Plaid disclaims all express or implied warranties with respect to the logos.</summary>
        [Newtonsoft.Json.JsonProperty("include_optional_metadata", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Include_optional_metadata { get; set; }
    
        /// <summary>When `true`, returns metadata related to the Auth product indicating which auth methods are supported.</summary>
        [Newtonsoft.Json.JsonProperty("include_auth_metadata", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Include_auth_metadata { get; set; } = false;
    
        /// <summary>When `true`, returns metadata related to the Payment Initiation product indicating which payment configurations are supported.</summary>
        [Newtonsoft.Json.JsonProperty("include_payment_initiation_metadata", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Include_payment_initiation_metadata { get; set; } = false;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}