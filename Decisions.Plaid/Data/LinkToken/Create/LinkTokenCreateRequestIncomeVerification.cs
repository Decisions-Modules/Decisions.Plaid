using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.LinkToken.Create
{
    /// <summary>Specifies options for initializing Link for use with the Income (beta) product. This field is required if `income_verification` is included in the `products` array.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class LinkTokenCreateRequestIncomeVerification 
    {
        /// <summary>The `income_verification_id` of the verification instance, as provided by `/income/verification/create`.</summary>
        [Newtonsoft.Json.JsonProperty("income_verification_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.Obsolete]
        public string Income_verification_id { get; set; }
    
        /// <summary>The `asset_report_id` of an asset report associated with the user, as provided by `/asset_report/create`. Providing an `asset_report_id` is optional and can be used to verify the user through a streamlined flow. If provided, the bank linking flow will be skipped.</summary>
        [Newtonsoft.Json.JsonProperty("asset_report_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Asset_report_id { get; set; }
    
        /// <summary>The ID of a precheck created with `/income/verification/precheck`. Will be used to improve conversion of the income verification flow.</summary>
        [Newtonsoft.Json.JsonProperty("precheck_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Precheck_id { get; set; }
    
        /// <summary>An array of access tokens corresponding to the Items that will be cross-referenced with the product data. If the `transactions` product was not initialized for the Items during link, it will be initialized after this Link session.</summary>
        [Newtonsoft.Json.JsonProperty("access_tokens", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.Collection<string> Access_tokens { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}