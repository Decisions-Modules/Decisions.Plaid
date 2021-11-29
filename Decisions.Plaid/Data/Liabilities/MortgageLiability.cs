using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;


namespace Decisions.Plaid.Data.Liabilities
{
    /// <summary>Contains details about a mortgage account.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class MortgageLiability 
    {
        /// <summary>The ID of the account that this liability belongs to.</summary>
        [Newtonsoft.Json.JsonProperty("account_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Account_id { get; set; }
    
        /// <summary>The account number of the loan.</summary>
        [Newtonsoft.Json.JsonProperty("account_number", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Account_number { get; set; }
    
        /// <summary>The current outstanding amount charged for late payment.</summary>
        [Newtonsoft.Json.JsonProperty("current_late_fee", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Current_late_fee { get; set; }
    
        /// <summary>Total amount held in escrow to pay taxes and insurance on behalf of the borrower.</summary>
        [Newtonsoft.Json.JsonProperty("escrow_balance", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Escrow_balance { get; set; }
    
        /// <summary>Indicates whether the borrower has private mortgage insurance in effect.</summary>
        [Newtonsoft.Json.JsonProperty("has_pmi", Required = Newtonsoft.Json.Required.AllowNull)]
        public bool? Has_pmi { get; set; }
    
        /// <summary>Indicates whether the borrower will pay a penalty for early payoff of mortgage.</summary>
        [Newtonsoft.Json.JsonProperty("has_prepayment_penalty", Required = Newtonsoft.Json.Required.AllowNull)]
        public bool? Has_prepayment_penalty { get; set; }
    
        [Newtonsoft.Json.JsonProperty("interest_rate", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public MortgageInterestRate Interest_rate { get; set; } = new MortgageInterestRate();
    
        /// <summary>The amount of the last payment.</summary>
        [Newtonsoft.Json.JsonProperty("last_payment_amount", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Last_payment_amount { get; set; }
    
        /// <summary>The date of the last payment. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD).</summary>
        [Newtonsoft.Json.JsonProperty("last_payment_date", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Last_payment_date { get; set; }
    
        /// <summary>Description of the type of loan, for example `conventional`, `fixed`, or `variable`. This field is provided directly from the loan servicer and does not have an enumerated set of possible values.</summary>
        [Newtonsoft.Json.JsonProperty("loan_type_description", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Loan_type_description { get; set; }
    
        /// <summary>Full duration of mortgage as at origination (e.g. `10 year`).</summary>
        [Newtonsoft.Json.JsonProperty("loan_term", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Loan_term { get; set; }
    
        /// <summary>Original date on which mortgage is due in full. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD).</summary>
        [Newtonsoft.Json.JsonProperty("maturity_date", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Maturity_date { get; set; }
    
        /// <summary>The amount of the next payment.</summary>
        [Newtonsoft.Json.JsonProperty("next_monthly_payment", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Next_monthly_payment { get; set; }
    
        /// <summary>The due date for the next payment. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD).</summary>
        [Newtonsoft.Json.JsonProperty("next_payment_due_date", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Next_payment_due_date { get; set; }
    
        /// <summary>The date on which the loan was initially lent. Dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD).</summary>
        [Newtonsoft.Json.JsonProperty("origination_date", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Origination_date { get; set; }
    
        /// <summary>The original principal balance of the mortgage.</summary>
        [Newtonsoft.Json.JsonProperty("origination_principal_amount", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Origination_principal_amount { get; set; }
    
        /// <summary>Amount of loan (principal + interest) past due for payment.</summary>
        [Newtonsoft.Json.JsonProperty("past_due_amount", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Past_due_amount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("property_address", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public MortgagePropertyAddress Property_address { get; set; } = new MortgagePropertyAddress();
    
        /// <summary>The year to date (YTD) interest paid.</summary>
        [Newtonsoft.Json.JsonProperty("ytd_interest_paid", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Ytd_interest_paid { get; set; }
    
        /// <summary>The YTD principal paid.</summary>
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