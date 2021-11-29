using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Webhooks
{
    /// <summary>Fired when the status of an income verification instance has changed. It will typically take several minutes for this webhook to fire after the end user has uploaded their documents in the Document Income flow.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class IncomeVerificationStatusWebhook 
    {
        /// <summary>`"INCOME"`</summary>
        [Newtonsoft.Json.JsonProperty("webhook_type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Webhook_type { get; set; }
    
        /// <summary>`income_verification`</summary>
        [Newtonsoft.Json.JsonProperty("webhook_code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Webhook_code { get; set; }
    
        /// <summary>The `income_verification_id` of the verification instance whose status is being reported.</summary>
        [Newtonsoft.Json.JsonProperty("income_verification_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Income_verification_id { get; set; }
    
        /// <summary>The Item ID associated with the verification.</summary>
        [Newtonsoft.Json.JsonProperty("item_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Item_id { get; set; }
    
        /// <summary>`VERIFICATION_STATUS_PROCESSING_COMPLETE`: The income verification status processing has completed. If the user uploaded multiple documents, this status means that at least one document was processed successfully. 
        /// <br/>
        /// <br/>`VERIFICATION_STATUS_DOCUMENT_REJECTED`: The documentation uploaded by the end user was recognized as a supported file format, but not recognized as a valid verification document. Common causes include poor image quality or the document not being an acceptable income verification document.
        /// <br/>
        /// <br/>`VERIFICATION_STATUS_PROCESSING_FAILED`: A failure occurred when attempting to process the verification documentation.
        /// <br/>
        /// <br/>`VERIFICATION_STATUS_PENDING_APPROVAL`: The income verification has been sent to the user for review.</summary>
        [Newtonsoft.Json.JsonProperty("verification_status", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Verification_status { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}