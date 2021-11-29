using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Paystubs
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class PaystubDeduction 
    {
        /// <summary>The description of the deduction, as provided on the paystub. For example: `"401(k)"`, `"FICA MED TAX"`.</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Type { get; set; }
    
        /// <summary>`true` if the deduction is pre-tax; `false` otherwise.</summary>
        [Newtonsoft.Json.JsonProperty("is_pretax", Required = Newtonsoft.Json.Required.AllowNull)]
        public bool? Is_pretax { get; set; }
    
        /// <summary>The amount of the deduction.</summary>
        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Total { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}