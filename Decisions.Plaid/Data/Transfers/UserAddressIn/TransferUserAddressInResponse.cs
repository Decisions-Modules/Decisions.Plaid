using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transfers.UserAddressIn
{
    /// <summary>The address associated with the account holder.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class TransferUserAddressInResponse 
    {
        /// <summary>The street number and name (i.e., "100 Market St.").</summary>
        [Newtonsoft.Json.JsonProperty("street", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Street { get; set; }
    
        /// <summary>Ex. "San Francisco"</summary>
        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.AllowNull)]
        public string City { get; set; }
    
        /// <summary>The state or province (e.g., "California").</summary>
        [Newtonsoft.Json.JsonProperty("region", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Region { get; set; }
    
        /// <summary>The postal code (e.g., "94103").</summary>
        [Newtonsoft.Json.JsonProperty("postal_code", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Postal_code { get; set; }
    
        /// <summary>A two-letter country code (e.g., "US").</summary>
        [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Country { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}