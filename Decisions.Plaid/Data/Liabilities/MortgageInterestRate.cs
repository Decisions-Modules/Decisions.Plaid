using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Liabilities
{
    /// <summary>Object containing metadata about the interest rate for the mortgage.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class MortgageInterestRate 
    {
        /// <summary>Percentage value (interest rate of current mortgage, not APR) of interest payable on a loan.</summary>
        [Newtonsoft.Json.JsonProperty("percentage", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Percentage { get; set; }
    
        /// <summary>The type of interest charged (fixed or variable).</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Type { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}