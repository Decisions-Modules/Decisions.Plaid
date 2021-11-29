using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Investments.Transactions
{
    /// <summary>An optional object to filter `/investments/transactions/get` results. If provided, must be non-`null`.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class InvestmentsTransactionsGetRequestOptions 
    {
        /// <summary>An array of `account_ids` to retrieve for the Item.</summary>
        [Newtonsoft.Json.JsonProperty("account_ids", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.Collection<string> Account_ids { get; set; }
    
        /// <summary>The number of transactions to fetch.
        /// <br/></summary>
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(1, 500)]
        public int Count { get; set; } = 100;
    
        /// <summary>The number of transactions to skip when fetching transaction history</summary>
        [Newtonsoft.Json.JsonProperty("offset", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public int Offset { get; set; } = 0;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}