

using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.StudentLoans
{
    /// <summary>Contains details about a student loan account</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class StudentLoan 
    {
        /// <summary>The ID of the account that this liability belongs to.</summary>
        [Newtonsoft.Json.JsonProperty("account_id", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Account_id { get; set; }
    
        /// <summary>The account number of the loan. For some institutions, this may be a masked version of the number (e.g., the last 4 digits instead of the entire number).</summary>
        [Newtonsoft.Json.JsonProperty("account_number", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Account_number { get; set; }
    
        /// <summary>The dates on which loaned funds were disbursed or will be disbursed. These are often in the past. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD).</summary>
        [Newtonsoft.Json.JsonProperty("disbursement_dates", Required = Newtonsoft.Json.Required.AllowNull)]
        public System.Collections.ObjectModel.Collection<System.DateTime> Disbursement_dates { get; set; }
    
        /// <summary>The date when the student loan is expected to be paid off. Availability for this field is limited. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD).</summary>
        [Newtonsoft.Json.JsonProperty("expected_payoff_date", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Expected_payoff_date { get; set; }
    
        /// <summary>The guarantor of the student loan.</summary>
        [Newtonsoft.Json.JsonProperty("guarantor", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Guarantor { get; set; }
    
        /// <summary>The interest rate on the loan as a percentage.</summary>
        [Newtonsoft.Json.JsonProperty("interest_rate_percentage", Required = Newtonsoft.Json.Required.Always)]
        public double Interest_rate_percentage { get; set; }
    
        /// <summary>`true` if a payment is currently overdue. Availability for this field is limited.</summary>
        [Newtonsoft.Json.JsonProperty("is_overdue", Required = Newtonsoft.Json.Required.AllowNull)]
        public bool? Is_overdue { get; set; }
    
        /// <summary>The amount of the last payment.</summary>
        [Newtonsoft.Json.JsonProperty("last_payment_amount", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Last_payment_amount { get; set; }
    
        /// <summary>The date of the last payment. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD).</summary>
        [Newtonsoft.Json.JsonProperty("last_payment_date", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Last_payment_date { get; set; }
    
        /// <summary>The date of the last statement. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD).</summary>
        [Newtonsoft.Json.JsonProperty("last_statement_issue_date", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Last_statement_issue_date { get; set; }
    
        /// <summary>The type of loan, e.g., "Consolidation Loans".</summary>
        [Newtonsoft.Json.JsonProperty("loan_name", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Loan_name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("loan_status", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public StudentLoanStatus Loan_status { get; set; } = new StudentLoanStatus();
    
        /// <summary>The minimum payment due for the next billing cycle. There are some exceptions:
        /// <br/>Some institutions require a minimum payment across all loans associated with an account number. Our API presents that same minimum payment amount on each loan. The institutions that do this are: Great Lakes ( `ins_116861`), Firstmark (`ins_116295`), Commonbond Firstmark Services (`ins_116950`), Nelnet (`ins_116528`), EdFinancial Services (`ins_116304`), Granite State (`ins_116308`), and Oklahoma Student Loan Authority (`ins_116945`).
        /// <br/>Firstmark (`ins_116295` ) will display as $0 if there is an autopay program in effect.</summary>
        [Newtonsoft.Json.JsonProperty("minimum_payment_amount", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Minimum_payment_amount { get; set; }
    
        /// <summary>The due date for the next payment. The due date is `null` if a payment is not expected. A payment is not expected if `loan_status.type` is `deferment`, `in_school`, `consolidated`, `paid in full`, or `transferred`. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD).</summary>
        [Newtonsoft.Json.JsonProperty("next_payment_due_date", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Next_payment_due_date { get; set; }
    
        /// <summary>The date on which the loan was initially lent. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD).
        /// <br/></summary>
        [Newtonsoft.Json.JsonProperty("origination_date", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Origination_date { get; set; }
    
        /// <summary>The original principal balance of the loan.</summary>
        [Newtonsoft.Json.JsonProperty("origination_principal_amount", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Origination_principal_amount { get; set; }
    
        /// <summary>The total dollar amount of the accrued interest balance. For Sallie Mae ( `ins_116944`), this amount is included in the current balance of the loan, so this field will return as `null`.</summary>
        [Newtonsoft.Json.JsonProperty("outstanding_interest_amount", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Outstanding_interest_amount { get; set; }
    
        /// <summary>The relevant account number that should be used to reference this loan for payments. In the majority of cases, `payment_reference_number` will match a`ccount_number,` but in some institutions, such as Great Lakes (`ins_116861`), it will be different.</summary>
        [Newtonsoft.Json.JsonProperty("payment_reference_number", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Payment_reference_number { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pslf_status", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public PSLFStatus Pslf_status { get; set; } = new PSLFStatus();
    
        [Newtonsoft.Json.JsonProperty("repayment_plan", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public StudentRepaymentPlan Repayment_plan { get; set; } = new StudentRepaymentPlan();
    
        /// <summary>The sequence number of the student loan. Heartland ECSI (`ins_116948`) does not make this field available.</summary>
        [Newtonsoft.Json.JsonProperty("sequence_number", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Sequence_number { get; set; }
    
        [Newtonsoft.Json.JsonProperty("servicer_address", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ServicerAddressData Servicer_address { get; set; } = new ServicerAddressData();
    
        /// <summary>The year to date (YTD) interest paid. Availability for this field is limited.</summary>
        [Newtonsoft.Json.JsonProperty("ytd_interest_paid", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Ytd_interest_paid { get; set; }
    
        /// <summary>The year to date (YTD) principal paid. Availability for this field is limited.</summary>
        [Newtonsoft.Json.JsonProperty("ytd_principal_paid", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Ytd_principal_paid { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}