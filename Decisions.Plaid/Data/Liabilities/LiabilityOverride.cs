
using System.Runtime.Serialization;
using Decisions.Plaid.Data.Accounts;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.StudentLoans;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Liabilities
{
    /// <summary>Used to configure Sandbox test data for the Liabilities product</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class LiabilityOverride 
    {
        /// <summary>The type of the liability object, either `credit` or `student`. Mortgages are not currently supported in the custom Sandbox.</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Type { get; set; }
    
        /// <summary>The purchase APR percentage value. For simplicity, this is the only interest rate used to calculate interest charges. Can only be set if `type` is `credit`.</summary>
        [Newtonsoft.Json.JsonProperty("purchase_apr", Required = Newtonsoft.Json.Required.Always)]
        public double Purchase_apr { get; set; }
    
        /// <summary>The cash APR percentage value. Can only be set if `type` is `credit`.</summary>
        [Newtonsoft.Json.JsonProperty("cash_apr", Required = Newtonsoft.Json.Required.Always)]
        public double Cash_apr { get; set; }
    
        /// <summary>The balance transfer APR percentage value. Can only be set if `type` is `credit`. Can only be set if `type` is `credit`.</summary>
        [Newtonsoft.Json.JsonProperty("balance_transfer_apr", Required = Newtonsoft.Json.Required.Always)]
        public double Balance_transfer_apr { get; set; }
    
        /// <summary>The special APR percentage value. Can only be set if `type` is `credit`.</summary>
        [Newtonsoft.Json.JsonProperty("special_apr", Required = Newtonsoft.Json.Required.Always)]
        public double Special_apr { get; set; }
    
        /// <summary>Override the `last_payment_amount` field. Can only be set if `type` is `credit`.</summary>
        [Newtonsoft.Json.JsonProperty("last_payment_amount", Required = Newtonsoft.Json.Required.Always)]
        public double Last_payment_amount { get; set; }
    
        /// <summary>Override the `minimum_payment_amount` field. Can only be set if `type` is `credit` or `student`.</summary>
        [Newtonsoft.Json.JsonProperty("minimum_payment_amount", Required = Newtonsoft.Json.Required.Always)]
        public double Minimum_payment_amount { get; set; }
    
        /// <summary>Override the `is_overdue` field</summary>
        [Newtonsoft.Json.JsonProperty("is_overdue", Required = Newtonsoft.Json.Required.Always)]
        public bool Is_overdue { get; set; }
    
        /// <summary>The date on which the loan was initially lent, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) (YYYY-MM-DD) format. Can only be set if `type` is `student`.</summary>
        [Newtonsoft.Json.JsonProperty("origination_date", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Origination_date { get; set; }
    
        /// <summary>The original loan principal. Can only be set if `type` is `student`.</summary>
        [Newtonsoft.Json.JsonProperty("principal", Required = Newtonsoft.Json.Required.Always)]
        public double Principal { get; set; }
    
        /// <summary>The interest rate on the loan as a percentage. Can only be set if `type` is `student`.</summary>
        [Newtonsoft.Json.JsonProperty("nominal_apr", Required = Newtonsoft.Json.Required.Always)]
        public double Nominal_apr { get; set; }
    
        /// <summary>If set, interest capitalization begins at the given number of months after loan origination. By default interest is never capitalized. Can only be set if `type` is `student`.</summary>
        [Newtonsoft.Json.JsonProperty("interest_capitalization_grace_period_months", Required = Newtonsoft.Json.Required.Always)]
        public double Interest_capitalization_grace_period_months { get; set; }
    
        [Newtonsoft.Json.JsonProperty("repayment_model", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public StudentLoanRepaymentModel Repayment_model { get; set; } = new StudentLoanRepaymentModel();
    
        /// <summary>Override the `expected_payoff_date` field. Can only be set if `type` is `student`.</summary>
        [Newtonsoft.Json.JsonProperty("expected_payoff_date", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Expected_payoff_date { get; set; }
    
        /// <summary>Override the `guarantor` field. Can only be set if `type` is `student`.</summary>
        [Newtonsoft.Json.JsonProperty("guarantor", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Guarantor { get; set; }
    
        /// <summary>Override the `is_federal` field. Can only be set if `type` is `student`.</summary>
        [Newtonsoft.Json.JsonProperty("is_federal", Required = Newtonsoft.Json.Required.Always)]
        public bool Is_federal { get; set; }
    
        /// <summary>Override the `loan_name` field. Can only be set if `type` is `student`.</summary>
        [Newtonsoft.Json.JsonProperty("loan_name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Loan_name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("loan_status", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public StudentLoanStatus Loan_status { get; set; } = new StudentLoanStatus();
    
        /// <summary>Override the `payment_reference_number` field. Can only be set if `type` is `student`.</summary>
        [Newtonsoft.Json.JsonProperty("payment_reference_number", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Payment_reference_number { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pslf_status", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public PSLFStatus Pslf_status { get; set; } = new PSLFStatus();
    
        /// <summary>Override the `repayment_plan.description` field. Can only be set if `type` is `student`.</summary>
        [Newtonsoft.Json.JsonProperty("repayment_plan_description", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Repayment_plan_description { get; set; }
    
        /// <summary>Override the `repayment_plan.type` field. Can only be set if `type` is `student`. Possible values are: `"extended graduated"`, `"extended standard"`, `"graduated"`, `"income-contingent repayment"`, `"income-based repayment"`, `"interest only"`, `"other"`, `"pay as you earn"`, `"revised pay as you earn"`, or `"standard"`.</summary>
        [Newtonsoft.Json.JsonProperty("repayment_plan_type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Repayment_plan_type { get; set; }
    
        /// <summary>Override the `sequence_number` field. Can only be set if `type` is `student`.</summary>
        [Newtonsoft.Json.JsonProperty("sequence_number", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Sequence_number { get; set; }
    
        [Newtonsoft.Json.JsonProperty("servicer_address", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Address Servicer_address { get; set; } = new Address();
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}