using System.Runtime.Serialization;
using Decisions.Plaid.Data.Investments;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Accounts.Filters
{
    /// <summary>The `account_filters` specified in the original call to `/link/token/create`.
    /// <br/></summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public class AccountFiltersResponse 
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