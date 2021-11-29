

using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Institutions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class HealthIncident 
    {
        /// <summary>The start date of the incident, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format, e.g. `"2020-10-30T15:26:48Z"`.</summary>
        [Newtonsoft.Json.JsonProperty("start_date", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTime Start_date { get; set; }
    
        /// <summary>The end date of the incident, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format, e.g. `"2020-10-30T15:26:48Z"`.</summary>
        [Newtonsoft.Json.JsonProperty("end_date", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime End_date { get; set; }
    
        /// <summary>The title of the incident</summary>
        [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Title { get; set; }
    
        /// <summary>Updates on the health incident.</summary>
        [Newtonsoft.Json.JsonProperty("incident_updates", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<IncidentUpdate> Incident_updates { get; set; } = new System.Collections.ObjectModel.Collection<IncidentUpdate>();
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}