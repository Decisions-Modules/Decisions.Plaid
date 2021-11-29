using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Employees
{
    /// <summary>Taxpayer ID of the individual receiving the paystub.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class TaxpayerID 
    {
        /// <summary>Type of ID, e.g. 'SSN'</summary>
        [Newtonsoft.Json.JsonProperty("id_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id_type { get; set; }
    
        /// <summary>ID mask; i.e. last 4 digits of the taxpayer ID</summary>
        [Newtonsoft.Json.JsonProperty("id_mask", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Id_mask { get; set; }
    
        /// <summary>Last 4 digits of unique number of ID.</summary>
        [Newtonsoft.Json.JsonProperty("last_4_digits", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(4, MinimumLength = 4)]
        [System.Obsolete]
        public string Last_4_digits { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}