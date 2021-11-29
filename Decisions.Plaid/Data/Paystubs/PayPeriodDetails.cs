using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Paystubs
{
    /// <summary>Details about the pay period.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class PayPeriodDetails 
    {
        /// <summary>The amount of the paycheck.</summary>
        [Newtonsoft.Json.JsonProperty("check_amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Check_amount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("distribution_breakdown", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.Collection<DistributionBreakdown> Distribution_breakdown { get; set; }
    
        /// <summary>The pay period end date, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format: "yyyy-mm-dd".</summary>
        [Newtonsoft.Json.JsonProperty("end_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? End_date { get; set; }
    
        /// <summary>Total earnings before tax/deductions.</summary>
        [Newtonsoft.Json.JsonProperty("gross_earnings", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Gross_earnings { get; set; }
    
        /// <summary>The date on which the paystub was issued, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format ("yyyy-mm-dd").</summary>
        [Newtonsoft.Json.JsonProperty("pay_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Pay_date { get; set; }
    
        /// <summary>The frequency at which an individual is paid.</summary>
        [Newtonsoft.Json.JsonProperty("pay_frequency", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PayPeriodDetailsPay_frequency? Pay_frequency { get; set; }
    
        /// <summary>The date on which the paystub was issued, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format ("yyyy-mm-dd").</summary>
        [Newtonsoft.Json.JsonProperty("pay_day", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        [System.Obsolete]
        public System.DateTime? Pay_day { get; set; }
    
        /// <summary>The pay period start date, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format: "yyyy-mm-dd".</summary>
        [Newtonsoft.Json.JsonProperty("start_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Start_date { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}