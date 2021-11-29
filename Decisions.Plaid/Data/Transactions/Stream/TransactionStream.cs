

using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transactions.Stream
{
    /// <summary>A grouping of related transactions</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class TransactionStream 
    {
        /// <summary>The ID of the account to which the stream belongs</summary>
        [Newtonsoft.Json.JsonProperty("account_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Account_id { get; set; }
    
        /// <summary>A unique id for the stream</summary>
        [Newtonsoft.Json.JsonProperty("stream_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Stream_id { get; set; }
    
        /// <summary>The ID of the category to which this transaction belongs. See [Categories](https://plaid.com/docs/#category-overview).</summary>
        [Newtonsoft.Json.JsonProperty("category_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Category_id { get; set; }
    
        /// <summary>A hierarchical array of the categories to which this transaction belongs. See [Categories](https://plaid.com/docs/#category-overview).</summary>
        [Newtonsoft.Json.JsonProperty("category", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<string> Category { get; set; } = new System.Collections.ObjectModel.Collection<string>();
    
        /// <summary>A description of the transaction stream.</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Description { get; set; }
    
        /// <summary>The posted date of the earliest transaction in the stream.</summary>
        [Newtonsoft.Json.JsonProperty("first_date", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime First_date { get; set; }
    
        /// <summary>The posted date of the latest transaction in the stream.</summary>
        [Newtonsoft.Json.JsonProperty("last_date", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Last_date { get; set; }
    
        [Newtonsoft.Json.JsonProperty("frequency", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RecurringTransactionFrequency Frequency { get; set; }
    
        /// <summary>An array of Plaid transaction IDs belonging to the stream, sorted by posted date.</summary>
        [Newtonsoft.Json.JsonProperty("transaction_ids", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<string> Transaction_ids { get; set; } = new System.Collections.ObjectModel.Collection<string>();
    
        [Newtonsoft.Json.JsonProperty("average_amount", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public TransactionStreamAmount Average_amount { get; set; } = new TransactionStreamAmount();
    
        /// <summary>indicates whether the transaction stream is still live.</summary>
        [Newtonsoft.Json.JsonProperty("is_active", Required = Newtonsoft.Json.Required.Always)]
        public bool Is_active { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}