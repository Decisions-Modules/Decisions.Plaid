

using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Paystubs
{
    /// <summary>An object representing details that can be found on the paystub.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [System.Obsolete]
    [DataContract]
    [Writable]
    public  class PaystubDetails 
    {
        /// <summary>Beginning date of the pay period on the paystub in the 'YYYY-MM-DD' format.</summary>
        [Newtonsoft.Json.JsonProperty("pay_period_start_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Pay_period_start_date { get; set; }
    
        /// <summary>Ending date of the pay period on the paystub in the 'YYYY-MM-DD' format.</summary>
        [Newtonsoft.Json.JsonProperty("pay_period_end_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Pay_period_end_date { get; set; }
    
        /// <summary>Pay date on the paystub in the 'YYYY-MM-DD' format.</summary>
        [Newtonsoft.Json.JsonProperty("pay_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Pay_date { get; set; }
    
        /// <summary>The name of the payroll provider that generated the paystub, e.g. ADP</summary>
        [Newtonsoft.Json.JsonProperty("paystub_provider", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Paystub_provider { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pay_frequency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PaystubPayFrequency? Pay_frequency { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}