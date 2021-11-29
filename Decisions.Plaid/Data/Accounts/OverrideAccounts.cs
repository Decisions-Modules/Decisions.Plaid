using System.Runtime.Serialization;
using Decisions.Plaid.Data.IncomeVerification.Paystubs;
using Decisions.Plaid.Data.Investments;
using Decisions.Plaid.Data.Investments.Holdings;
using Decisions.Plaid.Data.Liabilities;

using Decisions.Plaid.Data.Number;
using Decisions.Plaid.Data.Transactions;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Accounts
{
    /// <summary>Data to use to set values of test accounts. Some values cannot be specified in the schema and will instead will be calculated from other test data in order to achieve more consistent, realistic test data.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class OverrideAccounts 
    {
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OverrideAccountType Type { get; set; }
    
        [Newtonsoft.Json.JsonProperty("subtype", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AccountSubtype? Subtype { get; set; }
    
        /// <summary>If provided, the account will start with this amount as the current balance.
        /// <br/></summary>
        [Newtonsoft.Json.JsonProperty("starting_balance", Required = Newtonsoft.Json.Required.Always)]
        public double Starting_balance { get; set; }
    
        /// <summary>If provided, the account will always have this amount as its  available balance, regardless of current balance or changes in transactions over time.</summary>
        [Newtonsoft.Json.JsonProperty("force_available_balance", Required = Newtonsoft.Json.Required.Always)]
        public double Force_available_balance { get; set; }
    
        /// <summary>ISO-4217 currency code. If provided, the account will be denominated in the given currency. Transactions will also be in this currency by default.</summary>
        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Currency { get; set; }
    
        [Newtonsoft.Json.JsonProperty("meta", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Meta Meta { get; set; } = new Meta();
    
        [Newtonsoft.Json.JsonProperty("numbers", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Numbers Numbers { get; set; } = new Numbers();
    
        /// <summary>Specify the list of transactions on the account.</summary>
        [Newtonsoft.Json.JsonProperty("transactions", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<TransactionOverride> Transactions { get; set; } = new System.Collections.ObjectModel.Collection<TransactionOverride>();
    
        [Newtonsoft.Json.JsonProperty("holdings", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public HoldingsOverride Holdings { get; set; }
    
        [Newtonsoft.Json.JsonProperty("investment_transactions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Investments_TransactionsOverride Investment_transactions { get; set; }
    
        [Newtonsoft.Json.JsonProperty("identity", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public OwnerOverride Identity { get; set; } = new OwnerOverride();
    
        [Newtonsoft.Json.JsonProperty("liability", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public LiabilityOverride Liability { get; set; } = new LiabilityOverride();
    
        [Newtonsoft.Json.JsonProperty("inflow_model", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public InflowModel Inflow_model { get; set; } = new InflowModel();
    
        [Newtonsoft.Json.JsonProperty("income", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public IncomeOverride Income { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}