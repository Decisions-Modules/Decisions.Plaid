using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Number
{
    /// <summary>Account and bank identifier number data used to configure the test account. All values are optional.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class Numbers 
    {
        /// <summary>Will be used for the account number.</summary>
        [Newtonsoft.Json.JsonProperty("account", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Account { get; set; }
    
        /// <summary>Must be a valid ACH routing number.</summary>
        [Newtonsoft.Json.JsonProperty("ach_routing", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Ach_routing { get; set; }
    
        /// <summary>Must be a valid wire transfer routing number.</summary>
        [Newtonsoft.Json.JsonProperty("ach_wire_routing", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Ach_wire_routing { get; set; }
    
        /// <summary>EFT institution number. Must be specified alongside `eft_branch`.</summary>
        [Newtonsoft.Json.JsonProperty("eft_institution", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Eft_institution { get; set; }
    
        /// <summary>EFT branch number. Must be specified alongside `eft_institution`.</summary>
        [Newtonsoft.Json.JsonProperty("eft_branch", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Eft_branch { get; set; }
    
        /// <summary>Bank identifier code (BIC). Must be specified alongside `international_iban`.</summary>
        [Newtonsoft.Json.JsonProperty("international_bic", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string International_bic { get; set; }
    
        /// <summary>International bank account number (IBAN). If no account number is specified via `account`, will also be used as the account number by default. Must be specified alongside `international_bic`.</summary>
        [Newtonsoft.Json.JsonProperty("international_iban", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string International_iban { get; set; }
    
        /// <summary>BACS sort code</summary>
        [Newtonsoft.Json.JsonProperty("bacs_sort_code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Bacs_sort_code { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}