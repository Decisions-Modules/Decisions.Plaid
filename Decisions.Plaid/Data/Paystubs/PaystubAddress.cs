using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Paystubs
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class PaystubAddress 
    {
        /// <summary>The full city name.</summary>
        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City { get; set; }
    
        /// <summary>The ISO 3166-1 alpha-2 country code.</summary>
        [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Country { get; set; }
    
        /// <summary>The postal code of the address.</summary>
        [Newtonsoft.Json.JsonProperty("postal_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Postal_code { get; set; }
    
        /// <summary>The region or state
        /// <br/>Example: `"NC"`</summary>
        [Newtonsoft.Json.JsonProperty("region", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Region { get; set; }
    
        /// <summary>The full street address.</summary>
        [Newtonsoft.Json.JsonProperty("street", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Street { get; set; }
    
        /// <summary>Street address line 1.</summary>
        [Newtonsoft.Json.JsonProperty("line1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.Obsolete]
        public string Line1 { get; set; }
    
        /// <summary>Street address line 2.</summary>
        [Newtonsoft.Json.JsonProperty("line2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.Obsolete]
        public string Line2 { get; set; }
    
        /// <summary>The region or state
        /// <br/>Example: `"NC"`</summary>
        [Newtonsoft.Json.JsonProperty("state_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.Obsolete]
        public string State_code { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}