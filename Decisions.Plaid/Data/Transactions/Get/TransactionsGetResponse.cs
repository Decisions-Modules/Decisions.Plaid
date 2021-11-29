using System.Runtime.Serialization;
using Decisions.Plaid.Data.Accounts;
using Decisions.Plaid.Data.Items;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transactions.Get
{
    /// <summary>TransactionsGetResponse defines the response schema for `/transactions/get`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class TransactionsGetResponse 
    {
        /// <summary>An array containing the `accounts` associated with the Item for which transactions are being returned. Each transaction can be mapped to its corresponding account via the `account_id` field.</summary>
        [Newtonsoft.Json.JsonProperty("accounts", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<AccountBase> Accounts { get; set; } = new System.Collections.ObjectModel.Collection<AccountBase>();
    
        /// <summary>An array containing transactions from the account. Transactions are returned in reverse chronological order, with the most recent at the beginning of the array. The maximum number of transactions returned is determined by the `count` parameter.</summary>
        [Newtonsoft.Json.JsonProperty("transactions", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<Transaction> Transactions { get; set; } = new System.Collections.ObjectModel.Collection<Transaction>();
    
        /// <summary>The total number of transactions available within the date range specified. If `total_transactions` is larger than the size of the `transactions` array, more transactions are available and can be fetched via manipulating the `offset` parameter.</summary>
        [Newtonsoft.Json.JsonProperty("total_transactions", Required = Newtonsoft.Json.Required.Always)]
        public int Total_transactions { get; set; }
    
        [Newtonsoft.Json.JsonProperty("item", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Item Item { get; set; } = new Item();
    
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