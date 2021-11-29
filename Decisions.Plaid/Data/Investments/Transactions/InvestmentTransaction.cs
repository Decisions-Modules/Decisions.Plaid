

using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Investments.Transactions
{
    /// <summary>A transaction within an investment account.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class InvestmentTransaction 
    {
        /// <summary>The ID of the Investment transaction, unique across all Plaid transactions. Like all Plaid identifiers, the `investment_transaction_id` is case sensitive.</summary>
        [Newtonsoft.Json.JsonProperty("investment_transaction_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Investment_transaction_id { get; set; }
    
        /// <summary>A legacy field formerly used internally by Plaid to identify certain canceled transactions.</summary>
        [Newtonsoft.Json.JsonProperty("cancel_transaction_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.Obsolete]
        public string Cancel_transaction_id { get; set; }
    
        /// <summary>The `account_id` of the account against which this transaction posted.</summary>
        [Newtonsoft.Json.JsonProperty("account_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Account_id { get; set; }
    
        /// <summary>The `security_id` to which this transaction is related.</summary>
        [Newtonsoft.Json.JsonProperty("security_id", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Security_id { get; set; }
    
        /// <summary>The [ISO 8601](https://wikipedia.org/wiki/ISO_8601) posting date for the transaction, or transacted date for pending transactions.</summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Date { get; set; }
    
        /// <summary>The institution’s description of the transaction.</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; }
    
        /// <summary>The number of units of the security involved in this transaction.</summary>
        [Newtonsoft.Json.JsonProperty("quantity", Required = Newtonsoft.Json.Required.Always)]
        public double Quantity { get; set; }
    
        /// <summary>The complete value of the transaction. Positive values when cash is debited, e.g. purchases of stock; negative values when cash is credited, e.g. sales of stock. Treatment remains the same for cash-only movements unassociated with securities.</summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
        public double Amount { get; set; }
    
        /// <summary>The price of the security at which this transaction occurred.</summary>
        [Newtonsoft.Json.JsonProperty("price", Required = Newtonsoft.Json.Required.Always)]
        public double Price { get; set; }
    
        /// <summary>The combined value of all fees applied to this transaction</summary>
        [Newtonsoft.Json.JsonProperty("fees", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Fees { get; set; }
    
        /// <summary>Value is one of the following:
        /// <br/>`buy`: Buying an investment
        /// <br/>`sell`: Selling an investment
        /// <br/>`cancel`: A cancellation of a pending transaction
        /// <br/>`cash`: Activity that modifies a cash position
        /// <br/>`fee`: A fee on the account
        /// <br/>`transfer`: Activity which modifies a position, but not through buy/sell activity e.g. options exercise, portfolio transfer
        /// <br/>
        /// <br/>For descriptions of possible transaction types and subtypes, see the [Investment transaction types schema](https://plaid.com/docs/api/accounts/#investment-transaction-types-schema).</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public InvestmentTransactionType Type { get; set; }
    
        /// <summary>For descriptions of possible transaction types and subtypes, see the [Investment transaction types schema](https://plaid.com/docs/api/accounts/#investment-transaction-types-schema).</summary>
        [Newtonsoft.Json.JsonProperty("subtype", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public InvestmentTransactionSubtype Subtype { get; set; }
    
        /// <summary>The ISO-4217 currency code of the transaction. Always `null` if `unofficial_currency_code` is non-`null`.</summary>
        [Newtonsoft.Json.JsonProperty("iso_currency_code", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Iso_currency_code { get; set; }
    
        /// <summary>The unofficial currency code associated with the holding. Always `null` if `iso_currency_code` is non-`null`. Unofficial currency codes are used for currencies that do not have official ISO currency codes, such as cryptocurrencies and the currencies of certain countries.
        /// <br/>
        /// <br/>See the [currency code schema](https://plaid.com/docs/api/accounts#currency-code-schema) for a full listing of supported `iso_currency_code`s.</summary>
        [Newtonsoft.Json.JsonProperty("unofficial_currency_code", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Unofficial_currency_code { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}