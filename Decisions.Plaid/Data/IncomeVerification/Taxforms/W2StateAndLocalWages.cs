using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.IncomeVerification.Taxforms
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class W2StateAndLocalWages 
    {
        /// <summary>State associated with the wage.</summary>
        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State { get; set; }
    
        /// <summary>State identification number of the employer.</summary>
        [Newtonsoft.Json.JsonProperty("employer_state_id_number", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Employer_state_id_number { get; set; }
    
        /// <summary>Wages and tips from the specified state.</summary>
        [Newtonsoft.Json.JsonProperty("state_wages_tips", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State_wages_tips { get; set; }
    
        /// <summary>Income tax from the specified state.</summary>
        [Newtonsoft.Json.JsonProperty("state_income_tax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string State_income_tax { get; set; }
    
        /// <summary>Wages and tips from the locality.</summary>
        [Newtonsoft.Json.JsonProperty("local_wages_tips", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Local_wages_tips { get; set; }
    
        /// <summary>Income tax from the locality.</summary>
        [Newtonsoft.Json.JsonProperty("local_income_tax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Local_income_tax { get; set; }
    
        /// <summary>Name of the locality.</summary>
        [Newtonsoft.Json.JsonProperty("locality_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Locality_name { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}