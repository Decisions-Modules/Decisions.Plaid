using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.AssetReports.Refresh
{
    /// <summary>AssetReportRefreshRequest defines the request schema for `/asset_report/refresh`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class AssetReportRefreshRequest 
    {
        [Newtonsoft.Json.JsonProperty("client_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Client_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("secret", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Secret { get; set; }
    
        [Newtonsoft.Json.JsonProperty("asset_report_token", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Asset_report_token { get; set; }
    
        /// <summary>The maximum number of days of history to include in the Asset Report. Must be an integer. If not specified, the value from the original call to `/asset_report/create` will be used.</summary>
        [Newtonsoft.Json.JsonProperty("days_requested", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0, 731)]
        public int? Days_requested { get; set; }
    
        [Newtonsoft.Json.JsonProperty("options", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AssetReportRefreshRequestOptions Options { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}