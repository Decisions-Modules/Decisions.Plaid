using System.Runtime.Serialization;
using Decisions.Plaid.Data.Transactions.Stream;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transactions.Recurring
{
    /// <summary>TransactionsRecurringGetResponse defines the response schema for `/transactions/recurring/get`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class TransactionsRecurringGetResponse 
    {
        /// <summary>An array of depository transaction streams.</summary>
        [Newtonsoft.Json.JsonProperty("inflow_streams", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<TransactionStream> Inflow_streams { get; set; } = new System.Collections.ObjectModel.Collection<TransactionStream>();
    
        /// <summary>An array of expense transaction streams.</summary>
        [Newtonsoft.Json.JsonProperty("outflow_streams", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<TransactionStream> Outflow_streams { get; set; } = new System.Collections.ObjectModel.Collection<TransactionStream>();
    
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