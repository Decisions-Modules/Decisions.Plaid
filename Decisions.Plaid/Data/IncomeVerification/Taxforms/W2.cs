using System.Runtime.Serialization;
using Decisions.Plaid.Data.Employees;
using Decisions.Plaid.Data.Paystubs;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.IncomeVerification.Taxforms
{
    /// <summary>W2 is an object that represents income data taken from a W2 tax document.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class W2 
    {
        [Newtonsoft.Json.JsonProperty("employer", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PaystubEmployer Employer { get; set; }
    
        [Newtonsoft.Json.JsonProperty("employee", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Employee Employee { get; set; }
    
        /// <summary>The tax year of the W2 document.</summary>
        [Newtonsoft.Json.JsonProperty("tax_year", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Tax_year { get; set; }
    
        /// <summary>An employee identification number or EIN.</summary>
        [Newtonsoft.Json.JsonProperty("employer_id_number", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Employer_id_number { get; set; }
    
        /// <summary>Wages from tips and other compensation.</summary>
        [Newtonsoft.Json.JsonProperty("wages_tips_other_comp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Wages_tips_other_comp { get; set; }
    
        /// <summary>Federal income tax withheld for the tax year.</summary>
        [Newtonsoft.Json.JsonProperty("federal_income_tax_withheld", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Federal_income_tax_withheld { get; set; }
    
        /// <summary>Wages from social security.</summary>
        [Newtonsoft.Json.JsonProperty("social_security_wages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Social_security_wages { get; set; }
    
        /// <summary>Social security tax withheld for the tax year.</summary>
        [Newtonsoft.Json.JsonProperty("social_security_tax_withheld", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Social_security_tax_withheld { get; set; }
    
        /// <summary>Wages and tips from medicare.</summary>
        [Newtonsoft.Json.JsonProperty("medicare_wages_and_tips", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Medicare_wages_and_tips { get; set; }
    
        /// <summary>Medicare tax withheld for the tax year.</summary>
        [Newtonsoft.Json.JsonProperty("medicare_tax_withheld", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Medicare_tax_withheld { get; set; }
    
        /// <summary>Tips from social security.</summary>
        [Newtonsoft.Json.JsonProperty("social_security_tips", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Social_security_tips { get; set; }
    
        /// <summary>Allocated tips.</summary>
        [Newtonsoft.Json.JsonProperty("allocated_tips", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Allocated_tips { get; set; }
    
        /// <summary>Contents from box 9 on the W2.</summary>
        [Newtonsoft.Json.JsonProperty("box_9", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Box_9 { get; set; }
    
        /// <summary>Dependent care benefits.</summary>
        [Newtonsoft.Json.JsonProperty("dependent_care_benefits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Dependent_care_benefits { get; set; }
    
        /// <summary>Nonqualified plans.</summary>
        [Newtonsoft.Json.JsonProperty("nonqualified_plans", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Nonqualified_plans { get; set; }
    
        [Newtonsoft.Json.JsonProperty("box_12", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.Collection<W2Box12> Box_12 { get; set; }
    
        /// <summary>Statutory employee.</summary>
        [Newtonsoft.Json.JsonProperty("statutory_employee", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Statutory_employee { get; set; }
    
        /// <summary>Retirement plan.</summary>
        [Newtonsoft.Json.JsonProperty("retirement_plan", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Retirement_plan { get; set; }
    
        /// <summary>Third party sick pay.</summary>
        [Newtonsoft.Json.JsonProperty("third_party_sick_pay", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Third_party_sick_pay { get; set; }
    
        /// <summary>Other.</summary>
        [Newtonsoft.Json.JsonProperty("other", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Other { get; set; }
    
        [Newtonsoft.Json.JsonProperty("state_and_local_wages", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.Collection<W2StateAndLocalWages> State_and_local_wages { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}