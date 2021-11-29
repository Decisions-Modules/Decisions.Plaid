using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transfers.Authorization
{
    /// <summary>TransferAuthorization contains the authorization decision for a proposed transfer</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class TransferAuthorization 
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Id { get; set; }
    
        /// <summary>The datetime representing when the authorization was created, in the format "2006-01-02T15:04:05Z".</summary>
        [Newtonsoft.Json.JsonProperty("created", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Created { get; set; }
    
        /// <summary>
        /// <br/>A decision regarding the proposed transfer.
        /// <br/>
        /// <br/>`approved` – The proposed transfer has received the end user's consent and has been approved for processing. Plaid has also reviewed the proposed transfer and has approved it for processing. 
        /// <br/>
        /// <br/>`permitted` – Plaid was unable to fetch the information required to approve or decline the proposed transfer. You may proceed with the transfer, but further review is recommended. Plaid is awaiting further instructions from the client.
        /// <br/>
        /// <br/>`declined` – Plaid reviewed the proposed transfer and declined processing. Refer to the `code` field in the `decision_rationale` object for details.</summary>
        [Newtonsoft.Json.JsonProperty("decision", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public TransferAuthorizationDecision Decision { get; set; }
    
        [Newtonsoft.Json.JsonProperty("decision_rationale", Required = Newtonsoft.Json.Required.AllowNull)]
        public TransferAuthorizationDecisionRationale Decision_rationale { get; set; }
    
        [Newtonsoft.Json.JsonProperty("proposed_transfer", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public TransferAuthorizationProposedTransfer Proposed_transfer { get; set; } = new TransferAuthorizationProposedTransfer();
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}