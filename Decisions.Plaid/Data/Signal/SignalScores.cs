

using System.Runtime.Serialization;
using Decisions.Plaid.Data.Signal.ReturnRisk;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Signal
{
    /// <summary>Risk scoring details broken down by risk category.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class SignalScores 
    {
        [Newtonsoft.Json.JsonProperty("customer_initiated_return_risk", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CustomerInitiatedReturnRisk Customer_initiated_return_risk { get; set; }
    
        [Newtonsoft.Json.JsonProperty("bank_initiated_return_risk", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BankInitiatedReturnRisk Bank_initiated_return_risk { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}