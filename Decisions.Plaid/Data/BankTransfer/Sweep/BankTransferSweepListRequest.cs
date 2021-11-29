using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.BankTransfer.Sweep
{
    /// <summary>BankTransferSweepListRequest defines the request schema for `/bank_transfer/sweep/list`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class BankTransferSweepListRequest 
    {
        [Newtonsoft.Json.JsonProperty("client_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Client_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("secret", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Secret { get; set; }
    
        /// <summary>If multiple origination accounts are available, `origination_account_id` must be used to specify the account that the sweeps belong to.</summary>
        [Newtonsoft.Json.JsonProperty("origination_account_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Origination_account_id { get; set; }
    
        /// <summary>The start datetime of sweeps to return (RFC 3339 format).</summary>
        [Newtonsoft.Json.JsonProperty("start_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? Start_time { get; set; }
    
        /// <summary>The end datetime of sweeps to return (RFC 3339 format).</summary>
        [Newtonsoft.Json.JsonProperty("end_time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? End_time { get; set; }
    
        /// <summary>The maximum number of sweeps to return.</summary>
        [Newtonsoft.Json.JsonProperty("count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.Range(1, 25)]
        public int? Count { get; set; } = 25;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}