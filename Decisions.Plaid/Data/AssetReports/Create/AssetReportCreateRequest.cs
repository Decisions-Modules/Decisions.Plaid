using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.AssetReports.Create
{
    /// <summary>AssetReportCreateRequest defines the request schema for `/asset_report/create`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class AssetReportCreateRequest 
    {
        [Newtonsoft.Json.JsonProperty("client_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Client_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("secret", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Secret { get; set; }
    
        /// <summary>An array of access tokens corresponding to the Items that will be included in the report. The `assets` product must have been initialized for the Items during link; the Assets product cannot be added after initialization.</summary>
        [Newtonsoft.Json.JsonProperty("access_tokens", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        [System.ComponentModel.DataAnnotations.MaxLength(99)]
        public System.Collections.ObjectModel.Collection<string> Access_tokens { get; set; } = new System.Collections.ObjectModel.Collection<string>();
    
        /// <summary>The maximum integer number of days of history to include in the Asset Report. If using Fannie Mae Day 1 Certainty, `days_requested` must be at least 61 for new originations or at least 31 for refinancings.</summary>
        [Newtonsoft.Json.JsonProperty("days_requested", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0, 731)]
        public int Days_requested { get; set; }
    
        [Newtonsoft.Json.JsonProperty("options", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AssetReportCreateRequestOptions Options { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}