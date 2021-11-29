using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Products.Status
{
    /// <summary>A representation of the status health of a request type. Auth requests, Balance requests, Identity requests, Investments requests, Liabilities requests, Transactions updates, Investments updates, Liabilities updates, and Item logins each have their own status object.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class ProductStatus 
    {
        /// <summary>This field is deprecated in favor of the `breakdown` object, which provides more granular institution health data.
        /// <br/>
        /// <br/>`HEALTHY`: the majority of requests are successful
        /// <br/>`DEGRADED`: only some requests are successful
        /// <br/>`DOWN`: all requests are failing</summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [System.Obsolete]
        public ProductStatusStatus Status { get; set; }
    
        /// <summary>[ISO 8601](https://wikipedia.org/wiki/ISO_8601) formatted timestamp of the last status change for the institution.
        /// <br/></summary>
        [Newtonsoft.Json.JsonProperty("last_status_change", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTime Last_status_change { get; set; }
    
        [Newtonsoft.Json.JsonProperty("breakdown", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ProductStatusBreakdown Breakdown { get; set; } = new ProductStatusBreakdown();
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}