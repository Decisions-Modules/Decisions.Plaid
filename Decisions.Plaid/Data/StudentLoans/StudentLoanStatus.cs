

using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.StudentLoans
{
    /// <summary>An object representing the status of the student loan</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class StudentLoanStatus 
    {
        /// <summary>The date until which the loan will be in its current status. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD).
        /// <br/></summary>
        [Newtonsoft.Json.JsonProperty("end_date", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? End_date { get; set; }
    
        /// <summary>The status type of the student loan</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public StudentLoanStatusType? Type { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}