

using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transactions.Sync
{
    /// <summary>TransactionsSyncResponse defines the response schema for `/transactions/sync`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class TransactionsSyncResponse 
    {
        /// <summary>Transactions that have been added to the item since `cursor` ordered by ascending last modified time.</summary>
        [Newtonsoft.Json.JsonProperty("added", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<Transaction> Added { get; set; } = new System.Collections.ObjectModel.Collection<Transaction>();
    
        /// <summary>Transactions that have been modified on the item since `cursor` ordered by ascending last modified time.</summary>
        [Newtonsoft.Json.JsonProperty("modified", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<Transaction> Modified { get; set; } = new System.Collections.ObjectModel.Collection<Transaction>();
    
        /// <summary>Transactions that have been removed from the item since `cursor` ordered by ascending last modified time.</summary>
        [Newtonsoft.Json.JsonProperty("removed", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<RemovedTransaction> Removed { get; set; } = new System.Collections.ObjectModel.Collection<RemovedTransaction>();
    
        /// <summary>Cursor used for fetching any future updates after the latest update provided in this response.</summary>
        [Newtonsoft.Json.JsonProperty("next_cursor", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Next_cursor { get; set; }
    
        /// <summary>Represents if more than requested count of transaction updates exist. If true, the additional updates can be fetched by making an additional request with `cursor` set to `next_cursor`.</summary>
        [Newtonsoft.Json.JsonProperty("has_more", Required = Newtonsoft.Json.Required.Always)]
        public bool Has_more { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}