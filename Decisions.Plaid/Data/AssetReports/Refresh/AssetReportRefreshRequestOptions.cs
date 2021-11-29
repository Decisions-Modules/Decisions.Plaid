using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.AssetReports.Refresh
{
    /// <summary>An optional object to filter `/asset_report/refresh` results. If provided, cannot be `null`. If not specified, the `options` from the original call to `/asset_report/create` will be used.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class AssetReportRefreshRequestOptions 
    {
        /// <summary>Client-generated identifier, which can be used by lenders to track loan applications.</summary>
        [Newtonsoft.Json.JsonProperty("client_report_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Client_report_id { get; set; }
    
        /// <summary>URL to which Plaid will send Assets webhooks, for example when the requested Asset Report is ready.</summary>
        [Newtonsoft.Json.JsonProperty("webhook", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Webhook { get; set; }
    
        [Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AssetReportUser User { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}