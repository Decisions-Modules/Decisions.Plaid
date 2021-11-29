using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Accounts
{
    /// <summary>The schema below describes the various `types` and corresponding `subtypes` that Plaid recognizes and reports for financial institution accounts.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class StandaloneAccountType 
    {
        [Newtonsoft.Json.JsonProperty("depository", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Depository { get; set; }
    
        [Newtonsoft.Json.JsonProperty("credit", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Credit { get; set; }
    
        [Newtonsoft.Json.JsonProperty("loan", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Loan { get; set; }
    
        [Newtonsoft.Json.JsonProperty("investment", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Investment { get; set; }
    
        /// <summary>Other or unknown account type. Supported products for `other` accounts are: Balance, Transactions, Identity, and Assets.</summary>
        [Newtonsoft.Json.JsonProperty("other", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Other { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}