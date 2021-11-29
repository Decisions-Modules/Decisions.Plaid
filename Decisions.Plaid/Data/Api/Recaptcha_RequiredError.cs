using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Api
{
    /// <summary>The request was flagged by Plaid's fraud system, and requires additional verification to ensure they are not a bot.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class Recaptcha_RequiredError 
    {
        /// <summary>RECAPTCHA_ERROR</summary>
        [Newtonsoft.Json.JsonProperty("error_type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Error_type { get; set; }
    
        /// <summary>RECAPTCHA_REQUIRED</summary>
        [Newtonsoft.Json.JsonProperty("error_code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Error_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("display_message", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Display_message { get; set; }
    
        /// <summary>400</summary>
        [Newtonsoft.Json.JsonProperty("http_code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Http_code { get; set; }
    
        /// <summary>Your user will be prompted to solve a Google reCAPTCHA challenge in the Link Recaptcha pane. If they solve the challenge successfully, the user's request is resubmitted and they are directed to the next Item creation step.</summary>
        [Newtonsoft.Json.JsonProperty("link_user_experience", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Link_user_experience { get; set; }
    
        /// <summary>Plaid's fraud system detects abusive traffic and considers a variety of parameters throughout Item creation requests. When a request is considered risky or possibly fraudulent, Link presents a reCAPTCHA for the user to solve.</summary>
        [Newtonsoft.Json.JsonProperty("common_causes", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Common_causes { get; set; }
    
        /// <summary>Link will automatically guide your user through reCAPTCHA verification. As a general rule, we recommend instrumenting basic fraud monitoring to detect and protect your website from spam and abuse.
        /// <br/>
        /// <br/>If your user cannot verify their session, please submit a Support ticket with the following identifiers: `link_session_id` or `request_id`</summary>
        [Newtonsoft.Json.JsonProperty("troubleshooting_steps", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Troubleshooting_steps { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}