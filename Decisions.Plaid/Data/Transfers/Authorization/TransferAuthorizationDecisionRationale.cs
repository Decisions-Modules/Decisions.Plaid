using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transfers.Authorization
{
    /// <summary>The rationale for Plaid's decision regarding a proposed transfer. Will be null for `approved` decisions.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class TransferAuthorizationDecisionRationale 
    {
        /// <summary>A code representing the rationale for permitting or declining the proposed transfer. Possible values are:
        /// <br/>
        /// <br/>`NSF` – Transaction likely to result in a return due to insufficient funds.
        /// <br/>
        /// <br/>`RISK` - Transaction is high-risk.
        /// <br/>
        /// <br/>`MANUALLY_VERIFIED_ITEM` – Item created via same-day micro deposits, limited information available. Plaid can only offer `permitted` as a transaction decision.
        /// <br/>
        /// <br/>`LOGIN_REQUIRED` – Unable to collect the account information required for an authorization decision due to Item staleness. Can be rectified using Link update mode.
        /// <br/>
        /// <br/>`ERROR` – Unable to collect the account information required for an authorization decision due to an error.</summary>
        [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TransferAuthorizationDecisionRationaleCode Code { get; set; }
    
        /// <summary>A human-readable description of the code associated with a permitted transfer or transfer decline.</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
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