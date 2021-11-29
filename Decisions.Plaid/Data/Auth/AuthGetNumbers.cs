using System.Runtime.Serialization;
using Decisions.Plaid.Data.Number;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Auth
{
    /// <summary>An object containing identifying numbers used for making electronic transfers to and from the `accounts`. The identifying number type (ACH, EFT, IBAN, or BACS) used will depend on the country of the account. An account may have more than one number type. If a particular identifying number type is not used by any `accounts` for which data has been requested, the array for that type will be empty.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class AuthGetNumbers 
    {
        /// <summary>An array of ACH numbers identifying accounts.</summary>
        [Newtonsoft.Json.JsonProperty("ach", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<NumbersACH> Ach { get; set; } = new System.Collections.ObjectModel.Collection<NumbersACH>();
    
        /// <summary>An array of EFT numbers identifying accounts.</summary>
        [Newtonsoft.Json.JsonProperty("eft", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<NumbersEFT> Eft { get; set; } = new System.Collections.ObjectModel.Collection<NumbersEFT>();
    
        /// <summary>An array of IBAN numbers identifying accounts.</summary>
        [Newtonsoft.Json.JsonProperty("international", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<NumbersInternational> International { get; set; } = new System.Collections.ObjectModel.Collection<NumbersInternational>();
    
        /// <summary>An array of BACS numbers identifying accounts.</summary>
        [Newtonsoft.Json.JsonProperty("bacs", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<NumbersBACS> Bacs { get; set; } = new System.Collections.ObjectModel.Collection<NumbersBACS>();
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}