using System.Runtime.Serialization;
using Decisions.Plaid.Data.Accounts;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Institutions.Search
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class InstitutionsSearchAccountFilter 
    {
        [Newtonsoft.Json.JsonProperty("loan", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public System.Collections.ObjectModel.Collection<AccountSubtype?> Loan { get; set; }
    
        [Newtonsoft.Json.JsonProperty("depository", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public System.Collections.ObjectModel.Collection<AccountSubtype?> Depository { get; set; }
    
        [Newtonsoft.Json.JsonProperty("credit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public System.Collections.ObjectModel.Collection<AccountSubtype?> Credit { get; set; }
    
        [Newtonsoft.Json.JsonProperty("investment", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public System.Collections.ObjectModel.Collection<AccountSubtype?> Investment { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}