using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.BankTransfer.Events
{
    /// <summary>Represents an event in the Bank Transfers API.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class BankTransferEvent 
    {
        /// <summary>Plaid’s unique identifier for this event. IDs are sequential unsigned 64-bit integers.</summary>
        [Newtonsoft.Json.JsonProperty("event_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public int Event_id { get; set; }
    
        /// <summary>The datetime when this event occurred. This will be of the form `2006-01-02T15:04:05Z`.</summary>
        [Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTime Timestamp { get; set; }
    
        [Newtonsoft.Json.JsonProperty("event_type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BankTransferEventType Event_type { get; set; }
    
        /// <summary>The account ID associated with the bank transfer.</summary>
        [Newtonsoft.Json.JsonProperty("account_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Account_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("bank_transfer_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Bank_transfer_id { get; set; }
    
        /// <summary>The ID of the origination account that this balance belongs to.</summary>
        [Newtonsoft.Json.JsonProperty("origination_account_id", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Origination_account_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("bank_transfer_type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BankTransferType Bank_transfer_type { get; set; }
    
        /// <summary>The bank transfer amount.</summary>
        [Newtonsoft.Json.JsonProperty("bank_transfer_amount", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Bank_transfer_amount { get; set; }
    
        /// <summary>The currency of the bank transfer amount.</summary>
        [Newtonsoft.Json.JsonProperty("bank_transfer_iso_currency_code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Bank_transfer_iso_currency_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("failure_reason", Required = Newtonsoft.Json.Required.AllowNull)]
        public BankTransferFailure Failure_reason { get; set; }
    
        [Newtonsoft.Json.JsonProperty("direction", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BankTransferDirection? Direction { get; set; }
    
        [Newtonsoft.Json.JsonProperty("receiver_details", Required = Newtonsoft.Json.Required.AllowNull)]
        public BankTransferReceiverDetails Receiver_details { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}