using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.BankTransfer.Sweep
{
    /// <summary>BankTransferSweepListResponse defines the response schema for `/bank_transfer/sweep/list`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class BankTransferSweepListResponse 
    {
        [Newtonsoft.Json.JsonProperty("sweeps", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<BankTransferSweep> Sweeps { get; set; } = new System.Collections.ObjectModel.Collection<BankTransferSweep>();
    
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