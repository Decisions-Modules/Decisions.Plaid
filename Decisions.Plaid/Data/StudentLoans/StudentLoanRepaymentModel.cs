using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.StudentLoans
{
    /// <summary>Student loan repayment information used to configure Sandbox test data for the Liabilities product</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class StudentLoanRepaymentModel 
    {
        /// <summary>The only currently supported value for this field is `standard`.</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Type { get; set; }
    
        /// <summary>Configures the number of months before repayment starts.</summary>
        [Newtonsoft.Json.JsonProperty("non_repayment_months", Required = Newtonsoft.Json.Required.Always)]
        public double Non_repayment_months { get; set; }
    
        /// <summary>Configures the number of months of repayments before the loan is paid off.</summary>
        [Newtonsoft.Json.JsonProperty("repayment_months", Required = Newtonsoft.Json.Required.Always)]
        public double Repayment_months { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}