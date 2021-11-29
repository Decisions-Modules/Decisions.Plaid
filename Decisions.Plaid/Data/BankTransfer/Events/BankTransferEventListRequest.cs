using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.BankTransfer.Events
{
    /// <summary>Defines the request schema for `/bank_transfer/event/list`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class BankTransferEventListRequest 
    {
        [Newtonsoft.Json.JsonProperty("client_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Client_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("secret", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Secret { get; set; }
    
        /// <summary>The start datetime of bank transfers to list. This should be in RFC 3339 format (i.e. `2019-12-06T22:35:49Z`)</summary>
        [Newtonsoft.Json.JsonProperty("start_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? Start_date { get; set; }
    
        /// <summary>The end datetime of bank transfers to list. This should be in RFC 3339 format (i.e. `2019-12-06T22:35:49Z`)</summary>
        [Newtonsoft.Json.JsonProperty("end_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? End_date { get; set; }
    
        /// <summary>Plaid’s unique identifier for a bank transfer.</summary>
        [Newtonsoft.Json.JsonProperty("bank_transfer_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Bank_transfer_id { get; set; }
    
        /// <summary>The account ID to get events for all transactions to/from an account.</summary>
        [Newtonsoft.Json.JsonProperty("account_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Account_id { get; set; }
    
        /// <summary>The type of bank transfer. This will be either `debit` or `credit`.  A `debit` indicates a transfer of money into your origination account; a `credit` indicates a transfer of money out of your origination account.</summary>
        [Newtonsoft.Json.JsonProperty("bank_transfer_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BankTransferEventListRequestBank_transfer_type? Bank_transfer_type { get; set; }
    
        /// <summary>Filter events by event type.</summary>
        [Newtonsoft.Json.JsonProperty("event_types", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public System.Collections.ObjectModel.Collection<BankTransferEventType> Event_types { get; set; }
    
        /// <summary>The maximum number of bank transfer events to return. If the number of events matching the above parameters is greater than `count`, the most recent events will be returned.</summary>
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(1, 25)]
        public int? Count { get; set; } = 25;
    
        /// <summary>The offset into the list of bank transfer events. When `count`=25 and `offset`=0, the first 25 events will be returned. When `count`=25 and `offset`=25, the next 25 bank transfer events will be returned.</summary>
        [Newtonsoft.Json.JsonProperty("offset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(0, int.MaxValue)]
        public int? Offset { get; set; } = 0;
    
        /// <summary>The origination account ID to get events for transfers from a specific origination account.</summary>
        [Newtonsoft.Json.JsonProperty("origination_account_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Origination_account_id { get; set; }
    
        /// <summary>Indicates the direction of the transfer: `outbound`: for API-initiated transfers
        /// <br/>`inbound`: for payments received by the FBO account.</summary>
        [Newtonsoft.Json.JsonProperty("direction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public BankTransferEventListRequestDirection? Direction { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}