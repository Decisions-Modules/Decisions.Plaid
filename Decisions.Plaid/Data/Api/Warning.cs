

using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Api
{
    /// <summary>It is possible for an Asset Report to be returned with missing account owner information. In such cases, the Asset Report will contain warning data in the response, indicating why obtaining the owner information failed.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class Warning 
    {
        /// <summary>The warning type, which will always be `ASSET_REPORT_WARNING`</summary>
        [Newtonsoft.Json.JsonProperty("warning_type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Warning_type { get; set; }
    
        /// <summary>The warning code identifies a specific kind of warning. Currently, the only possible warning code is `OWNERS_UNAVAILABLE`, which indicates that account-owner information is not available.</summary>
        [Newtonsoft.Json.JsonProperty("warning_code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Warning_code Warning_code { get; set; }
    
        [Newtonsoft.Json.JsonProperty("cause", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Cause Cause { get; set; } = new Cause();
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}