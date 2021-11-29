﻿using System.Runtime.Serialization;
using Decisions.Plaid.Data.Accounts;
using Decisions.Plaid.Data.Accounts.Filters;
using Decisions.Plaid.Data.Investments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;


namespace Decisions.Plaid.Data.LinkToken
{
    /// <summary>By default, Link will provide limited account filtering: it will only display Institutions that are compatible with all products supplied in the `products` parameter of `/link/token/create`, and, if `auth` is specified in the `products` array, will also filter out accounts other than `checking` and `savings` accounts on the Account Select pane. You can further limit the accounts shown in Link by using `account_filters` to specify the account subtypes to be shown in Link. Only the specified subtypes will be shown. This filtering applies to both the Account Select view (if enabled) and the Institution Select view. Institutions that do not support the selected subtypes will be omitted from Link. To indicate that all subtypes should be shown, use the value `"all"`. If the `account_filters` filter is used, any account type for which a filter is not specified will be entirely omitted from Link. For a full list of valid types and subtypes, see the [Account schema](https://plaid.com/docs/api/accounts#accounts-schema).
    /// <br/>
    /// <br/>For institutions using OAuth, the filter will not affect the list of accounts shown by the bank in the OAuth window.
    /// <br/></summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class LinkTokenAccountFilters 
    {
        [Newtonsoft.Json.JsonProperty("depository", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DepositoryFilter Depository { get; set; }
    
        [Newtonsoft.Json.JsonProperty("credit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public CreditFilter Credit { get; set; }
    
        [Newtonsoft.Json.JsonProperty("loan", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LoanFilter Loan { get; set; }
    
        [Newtonsoft.Json.JsonProperty("investment", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public InvestmentFilter Investment { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}