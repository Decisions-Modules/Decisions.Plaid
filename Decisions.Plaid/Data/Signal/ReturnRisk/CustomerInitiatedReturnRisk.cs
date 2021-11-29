using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Signal.ReturnRisk
{
    /// <summary>The object contains a risk score and a risk tier that evaluate the transaction return risk of an unauthorized debit. Common return codes in this category include: “R05”, "R07", "R10", "R11", "R29". These returns typically have a return time frame of up to 60 calendar days. During this period, the customer of financial institutions can dispute a transaction as unauthorized.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class CustomerInitiatedReturnRisk 
    {
        [Newtonsoft.Json.JsonProperty("score", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0, 100)]
        public int Score { get; set; }
    
        [Newtonsoft.Json.JsonProperty("risk_tier", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(1, 5)]
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