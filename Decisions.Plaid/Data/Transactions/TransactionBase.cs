

using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transactions
{
    /// <summary>A representation of a transaction</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class TransactionBase 
    {
        /// <summary>Please use the `payment_channel` field, `transaction_type` will be deprecated in the future.
        /// <br/>
        /// <br/>`digital:` transactions that took place online.
        /// <br/>
        /// <br/>`place:` transactions that were made at a physical location.
        /// <br/>
        /// <br/>`special:` transactions that relate to banks, e.g. fees or deposits.
        /// <br/>
        /// <br/>`unresolved:` transactions that do not fit into the other three types.
        /// <br/></summary>
        [Newtonsoft.Json.JsonProperty("transaction_type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [System.Obsolete]
        public TransactionBaseTransaction_type Transaction_type { get; set; }
    
        /// <summary>The ID of a posted transaction's associated pending transaction, where applicable.</summary>
        [Newtonsoft.Json.JsonProperty("pending_transaction_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Pending_transaction_id { get; set; }
    
        /// <summary>The ID of the category to which this transaction belongs. See [Categories](https://plaid.com/docs/#category-overview).
        /// <br/>
        /// <br/>If the `transactions` object was returned by an Assets endpoint such as `/asset_report/get/` or `/asset_report/pdf/get`, this field will only appear in an Asset Report with Insights.</summary>
        [Newtonsoft.Json.JsonProperty("category_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Category_id { get; set; }
    
        /// <summary>A hierarchical array of the categories to which this transaction belongs. See [Categories](https://plaid.com/docs/#category-overview).
        /// <br/>
        /// <br/>If the `transactions` object was returned by an Assets endpoint such as `/asset_report/get/` or `/asset_report/pdf/get`, this field will only appear in an Asset Report with Insights.</summary>
        [Newtonsoft.Json.JsonProperty("category", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.Collection<string> Category { get; set; }
    
        [Newtonsoft.Json.JsonProperty("location", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Location Location { get; set; }
    
        [Newtonsoft.Json.JsonProperty("payment_meta", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public PaymentMeta Payment_meta { get; set; }
    
        /// <summary>The name of the account owner. This field is not typically populated and only relevant when dealing with sub-accounts.</summary>
        [Newtonsoft.Json.JsonProperty("account_owner", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Account_owner { get; set; }
    
        /// <summary>The merchant name or transaction description.
        /// <br/>
        /// <br/>If the `transactions` object was returned by a Transactions endpoint such as `/transactions/get`, this field will always appear. If the `transactions` object was returned by an Assets endpoint such as `/asset_report/get/` or `/asset_report/pdf/get`, this field will only appear in an Asset Report with Insights.</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        /// <summary>The string returned by the financial institution to describe the transaction. For transactions returned by `/transactions/get`, this field is in beta and will be omitted unless the client is both enrolled in the closed beta program and has set `options.include_original_description` to `true`.</summary>
        [Newtonsoft.Json.JsonProperty("original_description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Original_description { get; set; }
    
        /// <summary>The ID of the account in which this transaction occurred.</summary>
        [Newtonsoft.Json.JsonProperty("account_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Account_id { get; set; }
    
        /// <summary>The settled value of the transaction, denominated in the account's currency, as stated in `iso_currency_code` or `unofficial_currency_code`. Positive values when money moves out of the account; negative values when money moves in. For example, debit card purchases are positive; credit card payments, direct deposits, and refunds are negative.</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
        public double Amount { get; set; }
    
        /// <summary>The ISO-4217 currency code of the transaction. Always `null` if `unofficial_currency_code` is non-null.</summary>
        [Newtonsoft.Json.JsonProperty("iso_currency_code", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Iso_currency_code { get; set; }
    
        /// <summary>The unofficial currency code associated with the transaction. Always `null` if `iso_currency_code` is non-`null`. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.
        /// <br/>
        /// <br/>See the [currency code schema](https://plaid.com/docs/api/accounts#currency-code-schema) for a full listing of supported `iso_currency_code`s.</summary>
        [Newtonsoft.Json.JsonProperty("unofficial_currency_code", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Unofficial_currency_code { get; set; }
    
        /// <summary>For pending transactions, the date that the transaction occurred; for posted transactions, the date that the transaction posted. Both dates are returned in an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format ( `YYYY-MM-DD` ).</summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Date { get; set; }
    
        /// <summary>When `true`, identifies the transaction as pending or unsettled. Pending transaction details (name, type, amount, category ID) may change before they are settled.</summary>
        [Newtonsoft.Json.JsonProperty("pending", Required = Newtonsoft.Json.Required.Always)]
        public bool Pending { get; set; }
    
        /// <summary>The unique ID of the transaction. Like all Plaid identifiers, the `transaction_id` is case sensitive.</summary>
        [Newtonsoft.Json.JsonProperty("transaction_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Transaction_id { get; set; }
    
        /// <summary>The merchant name, as extracted by Plaid from the `name` field.</summary>
        [Newtonsoft.Json.JsonProperty("merchant_name", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Merchant_name { get; set; }
    
        /// <summary>The check number of the transaction. This field is only populated for check transactions.</summary>
        [Newtonsoft.Json.JsonProperty("check_number", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Check_number { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}