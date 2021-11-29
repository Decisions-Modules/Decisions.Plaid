using System.Runtime.Serialization;
using Decisions.Plaid.Data.Accounts;
using Decisions.Plaid.Data.Items;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Investments.Transactions
{
    /// <summary>InvestmentsTransactionsGetResponse defines the response schema for `/investments/transactions/get`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class InvestmentsTransactionsGetResponse 
    {
        [Newtonsoft.Json.JsonProperty("item", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Item Item { get; set; } = new Item();
    
        /// <summary>The accounts for which transaction history is being fetched.</summary>
        [Newtonsoft.Json.JsonProperty("accounts", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<AccountBase> Accounts { get; set; } = new System.Collections.ObjectModel.Collection<AccountBase>();
    
        /// <summary>All securities for which there is a corresponding transaction being fetched.</summary>
        [Newtonsoft.Json.JsonProperty("securities", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<Security> Securities { get; set; } = new System.Collections.ObjectModel.Collection<Security>();
    
        /// <summary>The transactions being fetched</summary>
        [Newtonsoft.Json.JsonProperty("investment_transactions", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<InvestmentTransaction> Investment_transactions { get; set; } = new System.Collections.ObjectModel.Collection<InvestmentTransaction>();
    
        /// <summary>The total number of transactions available within the date range specified. If `total_investment_transactions` is larger than the size of the `transactions` array, more transactions are available and can be fetched via manipulating the `offset` parameter.'</summary>
        [Newtonsoft.Json.JsonProperty("total_investment_transactions", Required = Newtonsoft.Json.Required.Always)]
        public int Total_investment_transactions { get; set; }
    
        [Newtonsoft.Json.JsonProperty("request_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Request_id { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}