using System.Runtime.Serialization;
using Decisions.Plaid.Data.Accounts;
using Decisions.Plaid.Data.Investments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.LinkToken.Create
{
    /// <summary>By default, Link will only display account types that are compatible with all products supplied in the `products` parameter of `/link/token/create`. You can further limit the accounts shown in Link by using `account_filters` to specify the account subtypes to be shown in Link. Only the specified subtypes will be shown. This filtering applies to both the Account Select view (if enabled) and the Institution Select view. Institutions that do not support the selected subtypes will be omitted from Link. To indicate that all subtypes should be shown, use the value `"all"`. If the `account_filters` filter is used, any account type for which a filter is not specified will be entirely omitted from Link.
    /// <br/>
    /// <br/>For a full list of valid types and subtypes, see the [Account schema](https://plaid.com/docs/api/accounts#accounts-schema).
    /// <br/>
    /// <br/>For institutions using OAuth, the filter will not affect the list of institutions or accounts shown by the bank in the OAuth window.
    /// <br/></summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class LinkTokenCreateRequestAccountSubtypes 
    {
        /// <summary>A filter to apply to `depository`-type accounts</summary>
        [Newtonsoft.Json.JsonProperty("depository", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Depository Depository { get; set; }
    
        /// <summary>A filter to apply to `credit`-type accounts</summary>
        [Newtonsoft.Json.JsonProperty("credit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Credit Credit { get; set; }
    
        /// <summary>A filter to apply to `loan`-type accounts</summary>
        [Newtonsoft.Json.JsonProperty("loan", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Loan Loan { get; set; }
    
        /// <summary>A filter to apply to `investment`-type accounts</summary>
        [Newtonsoft.Json.JsonProperty("investment", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Investment Investment { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}