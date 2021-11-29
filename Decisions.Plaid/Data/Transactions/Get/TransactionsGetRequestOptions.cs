using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transactions.Get
{
    /// <summary>An optional object to be used with the request. If specified, `options` must not be `null`.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class TransactionsGetRequestOptions 
    {
        /// <summary>A list of `account_ids` to retrieve for the Item
        /// <br/>
        /// <br/>Note: An error will be returned if a provided `account_id` is not associated with the Item.</summary>
        [Newtonsoft.Json.JsonProperty("account_ids", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.Collection<string> Account_ids { get; set; }
    
        /// <summary>The number of transactions to fetch.</summary>
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(1, 500)]
        public int Count { get; set; } = 100;
    
        /// <summary>The number of transactions to skip. The default value is 0.</summary>
        [Newtonsoft.Json.JsonProperty("offset", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public int Offset { get; set; } = 0;
    
        /// <summary>Include the raw unparsed transaction description from the financial institution. This field is disabled by default. If you need this information in addition to the parsed data provided, contact your Plaid Account Manager.</summary>
        [Newtonsoft.Json.JsonProperty("include_original_description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Include_original_description { get; set; } = false;
    
        /// <summary>Include the `personal_finance_category` object in the response. This feature is currently in beta – to request access, contact transactions-feedback@plaid.com.</summary>
        [Newtonsoft.Json.JsonProperty("include_personal_finance_category_beta", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Include_personal_finance_category_beta { get; set; } = false;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}