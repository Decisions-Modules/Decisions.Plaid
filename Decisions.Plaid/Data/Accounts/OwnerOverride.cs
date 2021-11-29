using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Accounts
{
    /// <summary>Data about the owner or owners of an account. Any fields not specified will be filled in with default Sandbox information.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class OwnerOverride 
    {
        /// <summary>A list of names associated with the account by the financial institution. These should always be the names of individuals, even for business accounts. Note that the same name data will be used for all accounts associated with an Item.</summary>
        [Newtonsoft.Json.JsonProperty("names", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<string> Names { get; set; } = new System.Collections.ObjectModel.Collection<string>();
    
        /// <summary>A list of phone numbers associated with the account.</summary>
        [Newtonsoft.Json.JsonProperty("phone_numbers", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<PhoneNumber> Phone_numbers { get; set; } = new System.Collections.ObjectModel.Collection<PhoneNumber>();
    
        /// <summary>A list of email addresses associated with the account.</summary>
        [Newtonsoft.Json.JsonProperty("emails", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<Email> Emails { get; set; } = new System.Collections.ObjectModel.Collection<Email>();
    
        /// <summary>Data about the various addresses associated with the account.</summary>
        [Newtonsoft.Json.JsonProperty("addresses", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<Address> Addresses { get; set; } = new System.Collections.ObjectModel.Collection<Address>();
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}