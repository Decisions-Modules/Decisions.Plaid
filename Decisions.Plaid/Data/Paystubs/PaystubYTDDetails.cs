using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Paystubs
{
    /// <summary>The amount of income earned year to date, as based on paystub data.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [System.Obsolete]
    [DataContract]
    [Writable]
    public  class PaystubYTDDetails 
    {
        /// <summary>Year-to-date gross earnings.</summary>
        [Newtonsoft.Json.JsonProperty("gross_earnings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Gross_earnings { get; set; }
    
        /// <summary>Year-to-date net (take home) earnings.</summary>
        [Newtonsoft.Json.JsonProperty("net_earnings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Net_earnings { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}