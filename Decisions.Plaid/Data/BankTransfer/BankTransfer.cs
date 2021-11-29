

using System.Runtime.Serialization;
using Decisions.Plaid.Data.Transfers;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.BankTransfer
{
    /// <summary>Represents a bank transfer within the Bank Transfers API.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class BankTransfer 
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("ach_class", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ACHClass Ach_class { get; set; }
    
        /// <summary>The account ID that should be credited/debited for this bank transfer.</summary>
        [Newtonsoft.Json.JsonProperty("account_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Account_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BankTransferType Type { get; set; }
    
        [Newtonsoft.Json.JsonProperty("user", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public BankTransferUser User { get; set; } = new BankTransferUser();
    
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Amount { get; set; }
    
        /// <summary>The currency of the transfer amount, e.g. "USD"</summary>
        [Newtonsoft.Json.JsonProperty("iso_currency_code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Iso_currency_code { get; set; }
    
        /// <summary>The description of the transfer.</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Description { get; set; }
    
        /// <summary>The datetime when this bank transfer was created. This will be of the form `2006-01-02T15:04:05Z`</summary>
        [Newtonsoft.Json.JsonProperty("created", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTime Created { get; set; }
    
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BankTransferStatus Status { get; set; }
    
        [Newtonsoft.Json.JsonProperty("network", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BankTransferNetwork Network { get; set; }
    
        /// <summary>When `true`, you can still cancel this bank transfer.</summary>
        [Newtonsoft.Json.JsonProperty("cancellable", Required = Newtonsoft.Json.Required.Always)]
        public bool Cancellable { get; set; }
    
        [Newtonsoft.Json.JsonProperty("failure_reason", Required = Newtonsoft.Json.Required.AllowNull)]
        public BankTransferFailure Failure_reason { get; set; }
    
        /// <summary>A string containing the custom tag provided by the client in the create request. Will be null if not provided.</summary>
        [Newtonsoft.Json.JsonProperty("custom_tag", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Custom_tag { get; set; }
    
        [Newtonsoft.Json.JsonProperty("metadata", Required = Newtonsoft.Json.Required.AllowNull)]
        public BankTransferMetadata Metadata { get; set; }
    
        /// <summary>Plaid’s unique identifier for the origination account that was used for this transfer.</summary>
        [Newtonsoft.Json.JsonProperty("origination_account_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Origination_account_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("direction", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BankTransferDirection? Direction { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}