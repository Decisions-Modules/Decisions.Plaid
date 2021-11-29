using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Items.Status
{
    /// <summary>Information about the last successful and failed investments update for the Item.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class ItemStatusInvestments 
    {
        /// <summary>[ISO 8601](https://wikipedia.org/wiki/ISO_8601) timestamp of the last successful investments update for the Item. The status will update each time Plaid successfully connects with the institution, regardless of whether any new data is available in the update.</summary>
        [Newtonsoft.Json.JsonProperty("last_successful_update", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? Last_successful_update { get; set; }
    
        /// <summary>[ISO 8601](https://wikipedia.org/wiki/ISO_8601) timestamp of the last failed investments update for the Item. The status will update each time Plaid fails an attempt to connect with the institution, regardless of whether any new data is available in the update.</summary>
        [Newtonsoft.Json.JsonProperty("last_failed_update", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? Last_failed_update { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}