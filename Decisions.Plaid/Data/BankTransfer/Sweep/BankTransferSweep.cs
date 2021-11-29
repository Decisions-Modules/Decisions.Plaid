using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.BankTransfer.Sweep
{
    /// <summary>BankTransferSweep describes a sweep transfer.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class BankTransferSweep 
    {
        /// <summary>Identifier of the sweep.</summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Id { get; set; }
    
        /// <summary>Identifier of the sweep transfer.</summary>
        [Newtonsoft.Json.JsonProperty("transfer_id", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Transfer_id { get; set; }
    
        /// <summary>The datetime when the sweep occurred, in RFC 3339 format.</summary>
        [Newtonsoft.Json.JsonProperty("created_at", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTime Created_at { get; set; }
    
        /// <summary>The amount of the sweep.</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Amount { get; set; }
    
        /// <summary>The currency of the sweep, e.g. "USD".</summary>
        [Newtonsoft.Json.JsonProperty("iso_currency_code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Iso_currency_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("sweep_account", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public BankTransferSweepAccount Sweep_account { get; set; } = new BankTransferSweepAccount();
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}