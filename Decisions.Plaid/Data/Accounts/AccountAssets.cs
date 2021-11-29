using System.Runtime.Serialization;
using Decisions.Plaid.Data.AssetReports;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;


namespace Decisions.Plaid.Data.Accounts
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public class AccountAssets : AccountBase
    {
        /// <summary>The duration of transaction history available for this Item, typically defined as the time since the date of the earliest transaction in that account. Only returned by Assets endpoints.</summary>
        [Newtonsoft.Json.JsonProperty("days_available", Required = Newtonsoft.Json.Required.Always)]
        public double Days_available { get; set; }
    
        /// <summary>Transaction history associated with the account. Only returned by Assets endpoints. Transaction history returned by endpoints such as `/transactions/get` or `/investments/transactions/get` will be returned in the top-level `transactions` field instead.</summary>
        [Newtonsoft.Json.JsonProperty("transactions", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<AssetReportTransaction> Transactions { get; set; } = new System.Collections.ObjectModel.Collection<AssetReportTransaction>();
    
        /// <summary>Data returned by the financial institution about the account owner or owners. Only returned by Identity or Assets endpoints. Multiple owners on a single account will be represented in the same `owner` object, not in multiple owner objects within the array.</summary>
        [Newtonsoft.Json.JsonProperty("owners", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<Owner> Owners { get; set; } = new System.Collections.ObjectModel.Collection<Owner>();
    
        /// <summary>Calculated data about the historical balances on the account. Only returned by Assets endpoints.</summary>
        [Newtonsoft.Json.JsonProperty("historical_balances", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<HistoricalBalance> Historical_balances { get; set; } = new System.Collections.ObjectModel.Collection<HistoricalBalance>();
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}