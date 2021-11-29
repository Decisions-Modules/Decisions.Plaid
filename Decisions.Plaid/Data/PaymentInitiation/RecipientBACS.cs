using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.PaymentInitiation
{
    /// <summary>An object containing a BACS account number and sort code. If an IBAN is not provided or if this recipient needs to accept domestic GBP-denominated payments, BACS data is required.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class RecipientBACS 
    {
        /// <summary>The account number of the account. Maximum of 10 characters.</summary>
        [Newtonsoft.Json.JsonProperty("account", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(10, MinimumLength = 1)]
        public string Account { get; set; }
    
        /// <summary>The 6-character sort code of the account.</summary>
        [Newtonsoft.Json.JsonProperty("sort_code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(6, MinimumLength = 6)]
        public string Sort_code { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}