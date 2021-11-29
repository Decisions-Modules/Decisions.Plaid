using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.IncomeVerification.Precheck
{
    /// <summary>IncomeVerificationPrecheckRequest defines the request schema for `/income/verification/precheck`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class IncomeVerificationPrecheckRequest 
    {
        [Newtonsoft.Json.JsonProperty("client_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Client_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("secret", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Secret { get; set; }
    
        [Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IncomeVerificationPrecheckUser User { get; set; }
    
        [Newtonsoft.Json.JsonProperty("employer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IncomeVerificationPrecheckEmployer Employer { get; set; }
    
        [Newtonsoft.Json.JsonProperty("transactions_access_token", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.Obsolete]
        public string Transactions_access_token { get; set; }
    
        /// <summary>An array of access tokens corresponding to the Items that will be cross-referenced with the product data. If the `transactions` product was not initialized for the Items during link, it will be initialized after this Link session.</summary>
        [Newtonsoft.Json.JsonProperty("transactions_access_tokens", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.Collection<string> Transactions_access_tokens { get; set; }
    
        [Newtonsoft.Json.JsonProperty("us_military_info", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IncomeVerificationPrecheckMilitaryInfo Us_military_info { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}