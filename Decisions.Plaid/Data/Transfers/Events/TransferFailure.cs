using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transfers.Events
{
    /// <summary>The failure reason if the type of this transfer is `"failed"` or `"reversed"`. Null value otherwise.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class TransferFailure 
    {
        /// <summary>The ACH return code, e.g. `R01`.  A return code will be provided if and only if the transfer status is `reversed`. For a full listing of ACH return codes, see [Bank Transfers errors](https://plaid.com/docs/errors/bank-transfers/#ach-return-codes).</summary>
        [Newtonsoft.Json.JsonProperty("ach_return_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Ach_return_code { get; set; }
    
        /// <summary>A human-readable description of the reason for the failure or reversal.</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}