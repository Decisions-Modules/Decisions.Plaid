using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.StudentLoans
{
    /// <summary>An object representing the repayment plan for the student loan</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class StudentRepaymentPlan 
    {
        /// <summary>The description of the repayment plan as provided by the servicer.</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Description { get; set; }
    
        /// <summary>The type of the repayment plan.</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public StudentRepaymentPlanType? Type { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}