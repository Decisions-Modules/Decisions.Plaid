using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transactions
{
    /// <summary>A representation of where a transaction took place</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class Location 
    {
        /// <summary>The street address where the transaction occurred.</summary>
        [Newtonsoft.Json.JsonProperty("address", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Address { get; set; }
    
        /// <summary>The city where the transaction occurred.</summary>
        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.AllowNull)]
        public string City { get; set; }
    
        /// <summary>The region or state where the transaction occurred.</summary>
        [Newtonsoft.Json.JsonProperty("region", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Region { get; set; }
    
        /// <summary>The postal code where the transaction occurred.</summary>
        [Newtonsoft.Json.JsonProperty("postal_code", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Postal_code { get; set; }
    
        /// <summary>The ISO 3166-1 alpha-2 country code where the transaction occurred.</summary>
        [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Country { get; set; }
    
        /// <summary>The latitude where the transaction occurred.</summary>
        [Newtonsoft.Json.JsonProperty("lat", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Lat { get; set; }
    
        /// <summary>The longitude where the transaction occurred.</summary>
        [Newtonsoft.Json.JsonProperty("lon", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Lon { get; set; }
    
        /// <summary>The merchant defined store number where the transaction occurred.</summary>
        [Newtonsoft.Json.JsonProperty("store_number", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Store_number { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}