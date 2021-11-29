using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Number
{
    /// <summary>Identifying information for transferring money to or from a US account via ACH or wire transfer.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class NumbersACH 
    {
        /// <summary>The Plaid account ID associated with the account numbers</summary>
        [Newtonsoft.Json.JsonProperty("account_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Account_id { get; set; }
    
        /// <summary>The ACH account number for the account.
        /// <br/>
        /// <br/>Note that when using OAuth with Chase Bank (`ins_56`), Chase will issue "tokenized" routing and account numbers, which are not the user's actual account and routing numbers. These tokenized numbers should work identically to normal account and routing numbers. The digits returned in the `mask` field will continue to reflect the actual account number, rather than the tokenized account number; for this reason, when displaying account numbers to the user to help them identify their account in your UI, always use the `mask` rather than truncating the `account` number. If a user revokes their permissions to your app, the tokenized numbers will continue to work for ACH deposits, but not withdrawals.</summary>
        [Newtonsoft.Json.JsonProperty("account", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Account { get; set; }
    
        /// <summary>The ACH routing number for the account. If the institution is `ins_56`, this may be a tokenized routing number. For more information, see the description of the `account` field.</summary>
        [Newtonsoft.Json.JsonProperty("routing", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Routing { get; set; }
    
        /// <summary>The wire transfer routing number for the account, if available</summary>
        [Newtonsoft.Json.JsonProperty("wire_routing", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Wire_routing { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}