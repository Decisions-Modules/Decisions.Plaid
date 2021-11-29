using System.Runtime.Serialization;
using Decisions.Plaid.Data.Employees;
using Decisions.Plaid.Data.IncomeVerification.Paystubs;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;


namespace Decisions.Plaid.Data.Paystubs
{
    /// <summary>An object representing data from a paystub.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class PaystubOverride 
    {
        /// <summary>The employer on the paystub.</summary>
        [Newtonsoft.Json.JsonProperty("employer", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Employer2 Employer { get; set; }
    
        /// <summary>The employee on the paystub.</summary>
        [Newtonsoft.Json.JsonProperty("employee", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Employee2 Employee { get; set; }
    
        [Newtonsoft.Json.JsonProperty("income_breakdown", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.Collection<IncomeBreakdown> Income_breakdown { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pay_period_details", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PayPeriodDetails Pay_period_details { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}