

using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.IncomeVerification.Documents;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.IncomeVerification.Taxforms
{
    /// <summary>IncomeVerificationTaxformsGetResponse defines the response schema for `/income/verification/taxforms/get`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class IncomeVerificationTaxformsGetResponse 
    {
        [Newtonsoft.Json.JsonProperty("request_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Request_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("document_metadata", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<DocumentMetadata> Document_metadata { get; set; } = new System.Collections.ObjectModel.Collection<DocumentMetadata>();
    
        /// <summary>A list of taxforms.</summary>
        [Newtonsoft.Json.JsonProperty("taxforms", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<Taxform> Taxforms { get; set; } = new System.Collections.ObjectModel.Collection<Taxform>();
    
        [Newtonsoft.Json.JsonProperty("error", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Error Error { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}