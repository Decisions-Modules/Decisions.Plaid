using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Institutions.Get
{
    /// <summary>Specifies optional parameters for `/institutions/get_by_id`. If provided, must not be `null`.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class InstitutionsGetByIdRequestOptions 
    {
        /// <summary>When `true`, return an institution's logo, brand color, and URL. When available, the bank's logo is returned as a base64 encoded 152x152 PNG, the brand color is in hexadecimal format. The default value is `false`.
        /// <br/>
        /// <br/>Note that Plaid does not own any of the logos shared by the API and that by accessing or using these logos, you agree that you are doing so at your own risk and will, if necessary, obtain all required permissions from the appropriate rights holders and adhere to any applicable usage guidelines. Plaid disclaims all express or implied warranties with respect to the logos.</summary>
        [Newtonsoft.Json.JsonProperty("include_optional_metadata", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Include_optional_metadata { get; set; } = false;
    
        /// <summary>If `true`, the response will include status information about the institution. Default value is `false`.</summary>
        [Newtonsoft.Json.JsonProperty("include_status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Include_status { get; set; } = false;
    
        /// <summary>When `true`, returns metadata related to the Auth product indicating which auth methods are supported.</summary>
        [Newtonsoft.Json.JsonProperty("include_auth_metadata", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Include_auth_metadata { get; set; } = false;
    
        /// <summary>When `true`, returns metadata related to the Payment Initiation product indicating which payment configurations are supported.</summary>
        [Newtonsoft.Json.JsonProperty("include_payment_initiation_metadata", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Include_payment_initiation_metadata { get; set; } = false;
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}