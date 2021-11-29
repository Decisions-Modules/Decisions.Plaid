

using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Employees
{
    /// <summary>Data about the employer.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class Employer 
    {
        /// <summary>Plaid's unique identifier for the employer.</summary>
        [Newtonsoft.Json.JsonProperty("employer_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Employer_id { get; set; }
    
        /// <summary>The name of the employer</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("address", Required = Newtonsoft.Json.Required.AllowNull)]
        public AddressDataNullable Address { get; set; }
    
        /// <summary>A number from 0 to 1 indicating Plaid's level of confidence in the pairing between the employer and the institution (not yet implemented).</summary>
        [Newtonsoft.Json.JsonProperty("confidence_score", Required = Newtonsoft.Json.Required.Always)]
        public double Confidence_score { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}