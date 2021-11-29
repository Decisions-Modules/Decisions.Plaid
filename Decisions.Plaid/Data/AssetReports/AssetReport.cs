using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.AssetReports
{
    /// <summary>An object representing an Asset Report</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class AssetReport 
    {
        [Newtonsoft.Json.JsonProperty("asset_report_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Asset_report_id { get; set; }
    
        /// <summary>An identifier you determine and submit for the Asset Report.</summary>
        [Newtonsoft.Json.JsonProperty("client_report_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Client_report_id { get; set; }
    
        /// <summary>The date and time when the Asset Report was created, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (e.g. "2018-04-12T03:32:11Z").</summary>
        [Newtonsoft.Json.JsonProperty("date_generated", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTime Date_generated { get; set; }
    
        /// <summary>The duration of transaction history you requested</summary>
        [Newtonsoft.Json.JsonProperty("days_requested", Required = Newtonsoft.Json.Required.Always)]
        public double Days_requested { get; set; }
    
        [Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public AssetReportUser User { get; set; } = new AssetReportUser();
    
        /// <summary>Data returned by Plaid about each of the Items included in the Asset Report.</summary>
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<AssetReportItem> Items { get; set; } = new System.Collections.ObjectModel.Collection<AssetReportItem>();
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
} 