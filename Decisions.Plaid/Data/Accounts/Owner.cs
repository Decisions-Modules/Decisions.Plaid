

using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Accounts
{
    /// <summary>Data returned from the financial institution about the owner or owners of an account. Only the `names` array must be non-empty.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class Owner 
    {
        /// <summary>A list of names associated with the account by the financial institution. These should always be the names of individuals, even for business accounts. If the name of a business is reported, please contact Plaid Support. In the case of a joint account, Plaid will make a best effort to report the names of all account holders.
        /// <br/>
        /// <br/>If an Item contains multiple accounts with different owner names, some institutions will report all names associated with the Item in each account's `names` array.</summary>
        [Newtonsoft.Json.JsonProperty("names", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<string> Names { get; set; } = new System.Collections.ObjectModel.Collection<string>();
    
        /// <summary>A list of phone numbers associated with the account by the financial institution. May be an empty array if no relevant information is returned from the financial institution.</summary>
        [Newtonsoft.Json.JsonProperty("phone_numbers", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<PhoneNumber> Phone_numbers { get; set; } = new System.Collections.ObjectModel.Collection<PhoneNumber>();
    
        /// <summary>A list of email addresses associated with the account by the financial institution. May be an empty array if no relevant information is returned from the financial institution.</summary>
        [Newtonsoft.Json.JsonProperty("emails", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<Email> Emails { get; set; } = new System.Collections.ObjectModel.Collection<Email>();
    
        /// <summary>Data about the various addresses associated with the account by the financial institution. May be an empty array if no relevant information is returned from the financial institution.</summary>
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