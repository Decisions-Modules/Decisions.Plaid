using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.StudentLoans
{
    /// <summary>Information about the student's eligibility in the Public Service Loan Forgiveness program. This is only returned if the institution is Fedloan (`ins_116527`). </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class PSLFStatus 
    {
        /// <summary>The estimated date borrower will have completed 120 qualifying monthly payments. Returned in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD).</summary>
        [Newtonsoft.Json.JsonProperty("estimated_eligibility_date", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Estimated_eligibility_date { get; set; }
    
        /// <summary>The number of qualifying payments that have been made.</summary>
        [Newtonsoft.Json.JsonProperty("payments_made", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Payments_made { get; set; }
    
        /// <summary>The number of qualifying payments remaining.</summary>
        [Newtonsoft.Json.JsonProperty("payments_remaining", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Payments_remaining { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}