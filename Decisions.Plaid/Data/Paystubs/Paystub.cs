using System.Runtime.Serialization;
using Decisions.Plaid.Data.Employees;
using Decisions.Plaid.Data.IncomeVerification.Paystubs;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;


namespace Decisions.Plaid.Data.Paystubs
{
    /// <summary>An object representing data extracted from the end user's paystub.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class Paystub 
    {
        [Newtonsoft.Json.JsonProperty("deductions", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Deductions Deductions { get; set; } = new Deductions();
    
        /// <summary>An identifier of the document referenced by the document metadata.</summary>
        [Newtonsoft.Json.JsonProperty("doc_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Doc_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("earnings", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Earnings Earnings { get; set; } = new Earnings();
    
        [Newtonsoft.Json.JsonProperty("employee", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Employee Employee { get; set; } = new Employee();
    
        [Newtonsoft.Json.JsonProperty("employer", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public PaystubEmployer Employer { get; set; } = new PaystubEmployer();
    
        [Newtonsoft.Json.JsonProperty("employment_details", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public EmploymentDetails Employment_details { get; set; }
    
        [Newtonsoft.Json.JsonProperty("net_pay", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public NetPay Net_pay { get; set; } = new NetPay();
    
        [Newtonsoft.Json.JsonProperty("pay_period_details", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public PayPeriodDetails Pay_period_details { get; set; } = new PayPeriodDetails();
    
        [Newtonsoft.Json.JsonProperty("paystub_details", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PaystubDetails Paystub_details { get; set; }
    
        [Newtonsoft.Json.JsonProperty("income_breakdown", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.Obsolete]
        public System.Collections.ObjectModel.Collection<IncomeBreakdown> Income_breakdown { get; set; }
    
        [Newtonsoft.Json.JsonProperty("ytd_earnings", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PaystubYTDDetails Ytd_earnings { get; set; }
    
        [Newtonsoft.Json.JsonProperty("verification", Required = Newtonsoft.Json.Required.AllowNull)]
        public PaystubVerification Verification { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}