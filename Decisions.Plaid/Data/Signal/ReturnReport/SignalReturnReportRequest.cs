using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Signal.ReturnReport
{
    /// <summary>SignalReturnReportRequest defines the request schema for `/signal/return/report`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class SignalReturnReportRequest 
    {
        [Newtonsoft.Json.JsonProperty("client_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Client_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("secret", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Secret { get; set; }
    
        /// <summary>Must be the same as the `client_transaction_id` supplied when calling `/signal/evaluate`</summary>
        [Newtonsoft.Json.JsonProperty("client_transaction_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(36, MinimumLength = 1)]
        public string Client_transaction_id { get; set; }
    
        /// <summary>Must be a valid ACH return code (e.g. "R01")</summary>
        [Newtonsoft.Json.JsonProperty("return_code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Return_code { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}