using System.Runtime.Serialization;
using Decisions.Plaid.Data.Accounts.Balance;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Accounts
{
    /// <summary>A single account at a financial institution.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public class AccountBase 
    {
        /// <summary>Plaid’s unique identifier for the account. This value will not change unless Plaid can't reconcile the account with the data returned by the financial institution. This may occur, for example, when the name of the account changes. If this happens a new `account_id` will be assigned to the account.
        /// <br/>
        /// <br/>The `account_id` can also change if the `access_token` is deleted and the same credentials that were used to generate that `access_token` are used to generate a new `access_token` on a later date. In that case, the new `account_id` will be different from the old `account_id`.
        /// <br/>
        /// <br/>If an account with a specific `account_id` disappears instead of changing, the account is likely closed. Closed accounts are not returned by the Plaid API.
        /// <br/>
        /// <br/>Like all Plaid identifiers, the `account_id` is case sensitive.</summary>
        [Newtonsoft.Json.JsonProperty("account_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Account_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("balances", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public AccountBalance Balances { get; set; } = new AccountBalance();
    
        /// <summary>The last 2-4 alphanumeric characters of an account's official account number. Note that the mask may be non-unique between an Item's accounts, and it may also not match the mask that the bank displays to the user.</summary>
        [Newtonsoft.Json.JsonProperty("mask", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Mask { get; set; }
    
        /// <summary>The name of the account, either assigned by the user or by the financial institution itself</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Name { get; set; }
    
        /// <summary>The official name of the account as given by the financial institution</summary>
        [Newtonsoft.Json.JsonProperty("official_name", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Official_name { get; set; }
    
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AccountType Type { get; set; }
    
        [Newtonsoft.Json.JsonProperty("subtype", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AccountSubtype? Subtype { get; set; }
    
        /// <summary>The current verification status of an Auth Item initiated through Automated or Manual micro-deposits.  Returned for Auth Items only.
        /// <br/>
        /// <br/>`pending_automatic_verification`: The Item is pending automatic verification
        /// <br/>
        /// <br/>`pending_manual_verification`: The Item is pending manual micro-deposit verification. Items remain in this state until the user successfully verifies the two amounts.
        /// <br/>
        /// <br/>`automatically_verified`: The Item has successfully been automatically verified	
        /// <br/>
        /// <br/>`manually_verified`: The Item has successfully been manually verified
        /// <br/>
        /// <br/>`verification_expired`: Plaid was unable to automatically verify the deposit within 7 calendar days and will no longer attempt to validate the Item. Users may retry by submitting their information again through Link.
        /// <br/>
        /// <br/>`verification_failed`: The Item failed manual micro-deposit verification because the user exhausted all 3 verification attempts. Users may retry by submitting their information again through Link.	
        /// <br/>	</summary>
        [Newtonsoft.Json.JsonProperty("verification_status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AccountBaseVerification_status Verification_status { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
} 