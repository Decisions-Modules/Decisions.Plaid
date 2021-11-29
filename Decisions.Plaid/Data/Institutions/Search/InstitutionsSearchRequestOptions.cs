using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Institutions.Search
{
    /// <summary>An optional object to filter `/institutions/search` results.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class InstitutionsSearchRequestOptions 
    {
        /// <summary>Limit results to institutions with or without OAuth login flows. This is primarily relevant to institutions with European country codes</summary>
        [Newtonsoft.Json.JsonProperty("oauth", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Oauth { get; set; }
    
        /// <summary>When true, return the institution's homepage URL, logo and primary brand color.</summary>
        [Newtonsoft.Json.JsonProperty("include_optional_metadata", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Include_optional_metadata { get; set; }
    
        /// <summary>When `true`, returns metadata related to the Auth product indicating which auth methods are supported.</summary>
        [Newtonsoft.Json.JsonProperty("include_auth_metadata", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Include_auth_metadata { get; set; } = false;
    
        /// <summary>When `true`, returns metadata related to the Payment Initiation product indicating which payment configurations are supported.</summary>
        [Newtonsoft.Json.JsonProperty("include_payment_initiation_metadata", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Include_payment_initiation_metadata { get; set; } = false;
    
        [Newtonsoft.Json.JsonProperty("payment_initiation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public InstitutionsSearchPaymentInitiationOptions Payment_initiation { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}