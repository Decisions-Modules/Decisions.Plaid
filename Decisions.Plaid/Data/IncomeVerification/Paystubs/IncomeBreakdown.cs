using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.IncomeVerification.Paystubs
{
    /// <summary>An object representing a breakdown of the different income types on the paystub.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [System.Obsolete]
    [DataContract]
    [Writable]
    public  class IncomeBreakdown 
    {
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public IncomeBreakdownType? Type { get; set; }
    
        /// <summary>The hourly rate at which the income is paid.</summary>
        [Newtonsoft.Json.JsonProperty("rate", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Rate { get; set; }
    
        /// <summary>The number of hours logged for this income for this pay period.</summary>
        [Newtonsoft.Json.JsonProperty("hours", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Hours { get; set; }
    
        /// <summary>The total pay for this pay period.</summary>
        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Total { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}