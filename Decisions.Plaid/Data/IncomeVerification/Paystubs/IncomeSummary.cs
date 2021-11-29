using System.Runtime.Serialization;
using Decisions.Plaid.Data.Employees;
using Decisions.Plaid.Data.IncomeVerification.Precheck;
using Decisions.Plaid.Data.Transactions;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.IncomeVerification.Paystubs
{
    /// <summary>The verified fields from a paystub verification. All fields are provided as reported on the paystub.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class IncomeSummary 
    {
        [Newtonsoft.Json.JsonProperty("employer_name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public EmployerIncomeSummaryFieldString Employer_name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("employee_name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public EmployeeIncomeSummaryFieldString Employee_name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("ytd_gross_income", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public YTDGrossIncomeSummaryFieldNumber Ytd_gross_income { get; set; }
    
        [Newtonsoft.Json.JsonProperty("ytd_net_income", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public YTDNetIncomeSummaryFieldNumber Ytd_net_income { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pay_frequency", Required = Newtonsoft.Json.Required.AllowNull)]
        public PayFrequency Pay_frequency { get; set; }
    
        [Newtonsoft.Json.JsonProperty("projected_wage", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ProjectedIncomeSummaryFieldNumber Projected_wage { get; set; }
    
        [Newtonsoft.Json.JsonProperty("verified_transaction", Required = Newtonsoft.Json.Required.AllowNull)]
        public TransactionData Verified_transaction { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}