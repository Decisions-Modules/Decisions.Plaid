using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Signal.ReturnRisk
{
    /// <summary>The object contains a risk score and a risk tier that evaluate the transaction return risk because an account is overdrawn or because an ineligible account is used. Common return codes in this category include: "R01", "R02", "R03", "R04", "R06", “R08”,  "R09", "R13", "R16", "R17", "R20", "R23". These returns have a turnaround time of 2 banking days.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class BankInitiatedReturnRisk 
    {
        [Newtonsoft.Json.JsonProperty("score", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0, 100)]
        public int Score { get; set; }
    
        [Newtonsoft.Json.JsonProperty("risk_tier", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(1, 8)]
        public int Risk_tier { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}