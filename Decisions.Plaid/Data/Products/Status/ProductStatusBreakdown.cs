using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Products.Status
{
    /// <summary>A detailed breakdown of the institution's performance for a request type. The values for `success`, `error_plaid`, and `error_institution` sum to 1.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class ProductStatusBreakdown 
    {
        /// <summary>The percentage of login attempts that are successful, expressed as a decimal.</summary>
        [Newtonsoft.Json.JsonProperty("success", Required = Newtonsoft.Json.Required.Always)]
        public double Success { get; set; }
    
        /// <summary>The percentage of logins that are failing due to an internal Plaid issue, expressed as a decimal.
        /// <br/></summary>
        [Newtonsoft.Json.JsonProperty("error_plaid", Required = Newtonsoft.Json.Required.Always)]
        public double Error_plaid { get; set; }
    
        /// <summary>The percentage of logins that are failing due to an issue in the institution's system, expressed as a decimal.</summary>
        [Newtonsoft.Json.JsonProperty("error_institution", Required = Newtonsoft.Json.Required.Always)]
        public double Error_institution { get; set; }
    
        /// <summary>The `refresh_interval` may be `DELAYED` or `STOPPED` even when the success rate is high. This value is only returned for Transactions status breakdowns.</summary>
        [Newtonsoft.Json.JsonProperty("refresh_interval", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ProductStatusBreakdownRefresh_interval Refresh_interval { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}