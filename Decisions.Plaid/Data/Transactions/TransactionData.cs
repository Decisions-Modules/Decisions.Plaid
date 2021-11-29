

using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transactions
{
    /// <summary>Information about the matched direct deposit transaction used to verify a user's payroll information.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class TransactionData 
    {
        /// <summary>The description of the transaction.</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Description { get; set; }
    
        /// <summary>The amount of the transaction.</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
        public double Amount { get; set; }
    
        /// <summary>The date of the transaction, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format ("yyyy-mm-dd").</summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Date { get; set; }
    
        /// <summary>A unique identifier for the end user's account.</summary>
        [Newtonsoft.Json.JsonProperty("account_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Account_id { get; set; }
    
        /// <summary>A unique identifier for the transaction.</summary>
        [Newtonsoft.Json.JsonProperty("transaction_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Transaction_id { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}