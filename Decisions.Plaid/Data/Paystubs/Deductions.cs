

using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Paystubs
{
    /// <summary>An object with the deduction information found on a paystub.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class Deductions 
    {
        [Newtonsoft.Json.JsonProperty("subtotals", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.Obsolete]
        public System.Collections.ObjectModel.Collection<Total> Subtotals { get; set; }
    
        [Newtonsoft.Json.JsonProperty("breakdown", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<DeductionsBreakdown> Breakdown { get; set; } = new System.Collections.ObjectModel.Collection<DeductionsBreakdown>();
    
        [Newtonsoft.Json.JsonProperty("totals", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.Obsolete]
        public System.Collections.ObjectModel.Collection<Total> Totals { get; set; }
    
        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public DeductionsTotal Total { get; set; } = new DeductionsTotal();
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}