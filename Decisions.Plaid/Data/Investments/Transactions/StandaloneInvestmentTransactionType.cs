using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Misc
{
    /// <summary>Valid values for investment transaction types and subtypes. Note that transactions representing inflow of cash will appear as negative amounts, outflow of cash will appear as positive amounts.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class StandaloneInvestmentTransactionType 
    {
        [Newtonsoft.Json.JsonProperty("buy", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Buy { get; set; }
    
        [Newtonsoft.Json.JsonProperty("sell", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Sell { get; set; }
    
        /// <summary>A cancellation of a pending transaction</summary>
        [Newtonsoft.Json.JsonProperty("cancel", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Cancel { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cash", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Cash { get; set; }
    
        [Newtonsoft.Json.JsonProperty("fee", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Fee { get; set; }
    
        [Newtonsoft.Json.JsonProperty("transfer", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Transfer { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}