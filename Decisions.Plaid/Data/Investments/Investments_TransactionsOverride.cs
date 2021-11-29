

using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Investments
{
    /// <summary>Specify the list of investments transactions on the account.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class Investments_TransactionsOverride 
    {
        /// <summary>Posting date for the transaction. Must be formatted as an [ISO 8601](https://wikipedia.org/wiki/ISO_8601) date.</summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Date { get; set; }
    
        /// <summary>The institution's description of the transaction.</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; }
    
        /// <summary>The number of units of the security involved in this transaction. Must be positive if the type is a buy and negative if the type is a sell.</summary>
        [Newtonsoft.Json.JsonProperty("quantity", Required = Newtonsoft.Json.Required.Always)]
        public double Quantity { get; set; }
    
        /// <summary>The price of the security at which this transaction occurred.</summary>
        [Newtonsoft.Json.JsonProperty("price", Required = Newtonsoft.Json.Required.Always)]
        public double Price { get; set; }
    
        /// <summary>The combined value of all fees applied to this transaction.</summary>
        [Newtonsoft.Json.JsonProperty("fees", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double Fees { get; set; }
    
        /// <summary>The type of the investment transaction. Possible values are:
        /// <br/>`buy`: Buying an investment
        /// <br/>`sell`: Selling an investment
        /// <br/>`cash`: Activity that modifies a cash position
        /// <br/>`fee`: A fee on the account
        /// <br/>`transfer`: Activity that modifies a position, but not through buy/sell activity e.g. options exercise, portfolio transfer</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Type { get; set; }
    
        /// <summary>Either a valid `iso_currency_code` or `unofficial_currency_code`</summary>
        [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Currency { get; set; }
    
        [Newtonsoft.Json.JsonProperty("security", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SecurityOverride Security { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}