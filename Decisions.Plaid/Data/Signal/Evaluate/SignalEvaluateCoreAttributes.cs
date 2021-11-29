using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Signal.Evaluate
{
    /// <summary>The core attributes object contains additional data that can be used to assess the ACH return risk. Examples of data include:
    /// <br/>
    /// <br/>`days_since_first_plaid_connection`: The number of days since the first time the Item was connected to an application via Plaid
    /// <br/>`plaid_connections_count_7d`: The number of times the Item has been connected to applications via Plaid over the past 7 days
    /// <br/>`plaid_connections_count_30d`: The number of times the Item has been connected to applications via Plaid over the past 30 days
    /// <br/>`total_plaid_connections_count`: The number of times the Item has been connected to applications via Plaid
    /// <br/>`is_savings_or_money_market_account`: Indicates whether the ACH transaction funding account is a savings/money market account
    /// <br/>
    /// <br/>For the full list and detailed documentation of core attributes available, or to request that core attributes not be returned, contact Sales or your Plaid account manager      </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class SignalEvaluateCoreAttributes 
    {
        /// <summary>We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 7 days from the account that will be debited.</summary>
        [Newtonsoft.Json.JsonProperty("unauthorized_transactions_count_7d", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Unauthorized_transactions_count_7d { get; set; }
    
        /// <summary>We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 30 days from the account that will be debited.</summary>
        [Newtonsoft.Json.JsonProperty("unauthorized_transactions_count_30d", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Unauthorized_transactions_count_30d { get; set; }
    
        /// <summary>We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 60 days from the account that will be debited.</summary>
        [Newtonsoft.Json.JsonProperty("unauthorized_transactions_count_60d", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Unauthorized_transactions_count_60d { get; set; }
    
        /// <summary>We parse and analyze historical transaction metadata to identify the number of possible past returns due to unauthorized transactions over the past 90 days from the account that will be debited.</summary>
        [Newtonsoft.Json.JsonProperty("unauthorized_transactions_count_90d", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Unauthorized_transactions_count_90d { get; set; }
    
        /// <summary>We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 7 days from the account that will be debited.</summary>
        [Newtonsoft.Json.JsonProperty("nsf_overdraft_transactions_count_7d", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Nsf_overdraft_transactions_count_7d { get; set; }
    
        /// <summary>We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 30 days from the account that will be debited.</summary>
        [Newtonsoft.Json.JsonProperty("nsf_overdraft_transactions_count_30d", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Nsf_overdraft_transactions_count_30d { get; set; }
    
        /// <summary>We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 60 days from the account that will be debited.</summary>
        [Newtonsoft.Json.JsonProperty("nsf_overdraft_transactions_count_60d", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Nsf_overdraft_transactions_count_60d { get; set; }
    
        /// <summary>We parse and analyze historical transaction metadata to identify the number of possible past returns due to non-sufficient funds/overdrafts over the past 90 days from the account that will be debited.</summary>
        [Newtonsoft.Json.JsonProperty("nsf_overdraft_transactions_count_90d", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Nsf_overdraft_transactions_count_90d { get; set; }
    
        /// <summary>The number of days since the first time the Item was connected to an application via Plaid</summary>
        [Newtonsoft.Json.JsonProperty("days_since_first_plaid_connection", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Days_since_first_plaid_connection { get; set; }
    
        /// <summary>The number of times the Item has been connected to applications via Plaid over the past 7 days</summary>
        [Newtonsoft.Json.JsonProperty("plaid_connections_count_7d", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Plaid_connections_count_7d { get; set; }
    
        /// <summary>The number of times the Item has been connected to applications via Plaid over the past 30 days</summary>
        [Newtonsoft.Json.JsonProperty("plaid_connections_count_30d", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Plaid_connections_count_30d { get; set; }
    
        /// <summary>The total number of times the Item has been connected to applications via Plaid</summary>
        [Newtonsoft.Json.JsonProperty("total_plaid_connections_count", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Total_plaid_connections_count { get; set; }
    
        /// <summary>Indicates if the ACH transaction funding account is a savings/money market account</summary>
        [Newtonsoft.Json.JsonProperty("is_savings_or_money_market_account", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Is_savings_or_money_market_account { get; set; }
    
        /// <summary>The total credit (inflow) transaction amount over the past 10 days from the account that will be debited</summary>
        [Newtonsoft.Json.JsonProperty("total_credit_transactions_amount_10d", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Total_credit_transactions_amount_10d { get; set; }
    
        /// <summary>The total debit (outflow) transaction amount over the past 10 days from the account that will be debited</summary>
        [Newtonsoft.Json.JsonProperty("total_debit_transactions_amount_10d", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Total_debit_transactions_amount_10d { get; set; }
    
        /// <summary>The 50th percentile of all credit (inflow) transaction amounts over the past 28 days from the account that will be debited</summary>
        [Newtonsoft.Json.JsonProperty("p50_credit_transactions_amount_28d", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? P50_credit_transactions_amount_28d { get; set; }
    
        /// <summary>The 50th percentile of all debit (outflow) transaction amounts over the past 28 days from the account that will be debited</summary>
        [Newtonsoft.Json.JsonProperty("p50_debit_transactions_amount_28d", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? P50_debit_transactions_amount_28d { get; set; }
    
        /// <summary>The 95th percentile of all credit (inflow) transaction amounts over the past 28 days from the account that will be debited</summary>
        [Newtonsoft.Json.JsonProperty("p95_credit_transactions_amount_28d", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? P95_credit_transactions_amount_28d { get; set; }
    
        /// <summary>The 95th percentile of all debit (outflow) transaction amounts over the past 28 days from the account that will be debited</summary>
        [Newtonsoft.Json.JsonProperty("p95_debit_transactions_amount_28d", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? P95_debit_transactions_amount_28d { get; set; }
    
        /// <summary>The number of days within the past 90 days when the account that will be debited had a negative end-of-day available balance</summary>
        [Newtonsoft.Json.JsonProperty("days_with_negative_balance_count_90d", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Days_with_negative_balance_count_90d { get; set; }
    
        /// <summary>The 90th percentile of the end-of-day available balance over the past 30 days of the account that will be debited</summary>
        [Newtonsoft.Json.JsonProperty("p90_eod_balance_30d", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? P90_eod_balance_30d { get; set; }
    
        /// <summary>The 90th percentile of the end-of-day available balance over the past 60 days of the account that will be debited</summary>
        [Newtonsoft.Json.JsonProperty("p90_eod_balance_60d", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? P90_eod_balance_60d { get; set; }
    
        /// <summary>The 90th percentile of the end-of-day available balance over the past 90 days of the account that will be debited</summary>
        [Newtonsoft.Json.JsonProperty("p90_eod_balance_90d", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? P90_eod_balance_90d { get; set; }
    
        /// <summary>The 10th percentile of the end-of-day available balance over the past 30 days of the account that will be debited</summary>
        [Newtonsoft.Json.JsonProperty("p10_eod_balance_30d", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? P10_eod_balance_30d { get; set; }
    
        /// <summary>The 10th percentile of the end-of-day available balance over the past 60 days of the account that will be debited</summary>
        [Newtonsoft.Json.JsonProperty("p10_eod_balance_60d", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? P10_eod_balance_60d { get; set; }
    
        /// <summary>The 10th percentile of the end-of-day available balance over the past 90 days of the account that will be debited</summary>
        [Newtonsoft.Json.JsonProperty("p10_eod_balance_90d", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? P10_eod_balance_90d { get; set; }
    
        /// <summary>Available balance, as of the `balance_last_updated` time. The available balance is the current balance less any outstanding holds or debits that have not yet posted to the account.</summary>
        [Newtonsoft.Json.JsonProperty("available_balance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Available_balance { get; set; }
    
        /// <summary>Current balance, as of the `balance_last_updated` time. The current balance is the total amount of funds in the account.</summary>
        [Newtonsoft.Json.JsonProperty("current_balance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Current_balance { get; set; }
    
        /// <summary>Timestamp in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DDTHH:mm:ssZ) indicating the last time that the balance for the given account has been updated.</summary>
        [Newtonsoft.Json.JsonProperty("balance_last_updated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? Balance_last_updated { get; set; }
    
        /// <summary>The number of times the account's phone numbers on file have changed over the past 28 days</summary>
        [Newtonsoft.Json.JsonProperty("phone_change_count_28d", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Phone_change_count_28d { get; set; }
    
        /// <summary>The number of times the account's phone numbers on file have changed over the past 90 days</summary>
        [Newtonsoft.Json.JsonProperty("phone_change_count_90d", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Phone_change_count_90d { get; set; }
    
        /// <summary>The number of times the account's email addresses on file have changed over the past 28 days</summary>
        [Newtonsoft.Json.JsonProperty("email_change_count_28d", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Email_change_count_28d { get; set; }
    
        /// <summary>The number of times the account's email addresses on file have changed over the past 90 days</summary>
        [Newtonsoft.Json.JsonProperty("email_change_count_90d", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Email_change_count_90d { get; set; }
    
        /// <summary>The number of times the account's addresses on file have changed over the past 28 days</summary>
        [Newtonsoft.Json.JsonProperty("address_change_count_28d", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Address_change_count_28d { get; set; }
    
        /// <summary>The number of times the account's addresses on file have changed over the past 90 days</summary>
        [Newtonsoft.Json.JsonProperty("address_change_count_90d", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Address_change_count_90d { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}