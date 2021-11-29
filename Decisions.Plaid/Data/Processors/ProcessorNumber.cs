using System.Runtime.Serialization;
using Decisions.Plaid.Data.Number;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Processors
{
    /// <summary>An object containing identifying numbers used for making electronic transfers to and from the `account`. The identifying number type (ACH, EFT, IBAN, or BACS) used will depend on the country of the account. An account may have more than one number type. If a particular identifying number type is not used by the `account` for which auth data has been requested, a null value will be returned.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class ProcessorNumber 
    {
        [Newtonsoft.Json.JsonProperty("ach", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public NumbersACHNullable Ach { get; set; }
    
        [Newtonsoft.Json.JsonProperty("eft", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public NumbersEFTNullable Eft { get; set; }
    
        [Newtonsoft.Json.JsonProperty("international", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public NumbersInternationalNullable International { get; set; }
    
        [Newtonsoft.Json.JsonProperty("bacs", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public NumbersBACSNullable Bacs { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}