using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Signal
{
    /// <summary>The user's legal name</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class SignalPersonName 
    {
        /// <summary>The user's name prefix (e.g. "Mr.")</summary>
        [Newtonsoft.Json.JsonProperty("prefix", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Prefix { get; set; }
    
        /// <summary>The user's given name. If the user has a one-word name, it should be provided in this field.</summary>
        [Newtonsoft.Json.JsonProperty("given_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Given_name { get; set; }
    
        /// <summary>The user's middle name</summary>
        [Newtonsoft.Json.JsonProperty("middle_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Middle_name { get; set; }
    
        /// <summary>The user's family name / surname</summary>
        [Newtonsoft.Json.JsonProperty("family_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Family_name { get; set; }
    
        /// <summary>The user's name suffix (e.g. "II")</summary>
        [Newtonsoft.Json.JsonProperty("suffix", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Suffix { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}