using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Api
{
    /// <summary>We use standard HTTP response codes for success and failure notifications, and our errors are further classified by `error_type`. In general, 200 HTTP codes correspond to success, 40X codes are for developer- or user-related failures, and 50X codes are for Plaid-related issues.  Error fields will be `null` if no error has occurred.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class Error 
    {
        /// <summary>A broad categorization of the error. Safe for programatic use.</summary>
        [Newtonsoft.Json.JsonProperty("error_type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Error_type Error_type { get; set; }
    
        /// <summary>The particular error code. Safe for programmatic use.</summary>
        [Newtonsoft.Json.JsonProperty("error_code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Error_code { get; set; }
    
        /// <summary>A developer-friendly representation of the error code. This may change over time and is not safe for programmatic use.</summary>
        [Newtonsoft.Json.JsonProperty("error_message", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Error_message { get; set; }
    
        /// <summary>A user-friendly representation of the error code. `null` if the error is not related to user action.
        /// <br/>
        /// <br/>This may change over time and is not safe for programmatic use.</summary>
        [Newtonsoft.Json.JsonProperty("display_message", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Display_message { get; set; }
    
        /// <summary>A unique ID identifying the request, to be used for troubleshooting purposes. This field will be omitted in errors provided by webhooks.</summary>
        [Newtonsoft.Json.JsonProperty("request_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Request_id { get; set; }
    
        /// <summary>In the Assets product, a request can pertain to more than one Item. If an error is returned for such a request, `causes` will return an array of errors containing a breakdown of these errors on the individual Item level, if any can be identified.
        /// <br/>
        /// <br/>`causes` will only be provided for the `error_type` `ASSET_REPORT_ERROR`.</summary>
        [Newtonsoft.Json.JsonProperty("causes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.Collection<object> Causes { get; set; }
    
        /// <summary>The HTTP status code associated with the error. This will only be returned in the response body when the error information is provided via a webhook.</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Status { get; set; }
    
        /// <summary>The URL of a Plaid documentation page with more information about the error</summary>
        [Newtonsoft.Json.JsonProperty("documentation_url", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Documentation_url { get; set; }
    
        /// <summary>Suggested steps for resolving the error</summary>
        [Newtonsoft.Json.JsonProperty("suggested_action", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Suggested_action { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}