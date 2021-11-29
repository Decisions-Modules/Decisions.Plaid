

using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.IncomeVerification.Paystubs;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.IncomeVerification.Summary
{
    /// <summary>IncomeVerificationSummaryGetResponse defines the response schema for `/income/verification/summary/get`.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class IncomeVerificationSummaryGetResponse 
    {
        /// <summary>A list of income summaries.</summary>
        [Newtonsoft.Json.JsonProperty("income_summaries", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<IncomeSummary> Income_summaries { get; set; } = new System.Collections.ObjectModel.Collection<IncomeSummary>();
    
        [Newtonsoft.Json.JsonProperty("error", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Error Error { get; set; }
    
        [Newtonsoft.Json.JsonProperty("request_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Request_id { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}