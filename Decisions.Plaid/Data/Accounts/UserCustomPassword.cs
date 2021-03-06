using System.Runtime.Serialization;
using Decisions.Plaid.Data.Misc;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Accounts
{
    /// <summary>Custom test accounts are configured with a JSON configuration object formulated according to the schema below. All fields are optional. Sending an empty object as a configuration will result in an account configured with random balances and transaction history.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class UserCustomPassword 
    {
        /// <summary>The version of the password schema to use, possible values are 1 or 2. The default value is 2. You should only specify 1 if you know it is necessary for your test suite.</summary>
        [Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Version { get; set; }
    
        /// <summary>A seed, in the form of a string, that will be used to randomly generate account and transaction data, if this data is not specified using the `override_accounts` argument. If no seed is specified, the randomly generated data will be different each time.
        /// <br/>
        /// <br/>Note that transactions data is generated relative to the Item's creation date. Different Items created on different dates with the same seed for transactions data will have different dates for the transactions. The number of days between each transaction and the Item creation will remain constant. For example, an Item created on December 15 might show a transaction on December 14. An Item created on December 20, using the same seed, would show that same transaction occurring on December 19.</summary>
        [Newtonsoft.Json.JsonProperty("seed", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Seed { get; set; }
    
        /// <summary>An array of account overrides to configure the accounts for the Item. By default, if no override is specified, transactions and account data will be randomly generated based on the account type and subtype, and other products will have fixed or empty data.</summary>
        [Newtonsoft.Json.JsonProperty("override_accounts", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<OverrideAccounts> Override_accounts { get; set; } = new System.Collections.ObjectModel.Collection<OverrideAccounts>();
    
        [Newtonsoft.Json.JsonProperty("mfa", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public MFA Mfa { get; set; } = new MFA();
    
        /// <summary>You may trigger a reCAPTCHA in Plaid Link in the Sandbox environment by using the recaptcha field. Possible values are `good` or `bad`. A value of `good` will result in successful Item creation and `bad` will result in a `RECAPTCHA_BAD` error to simulate a failed reCAPTCHA. Both values require the reCAPTCHA to be manually solved within Plaid Link.</summary>
        [Newtonsoft.Json.JsonProperty("recaptcha", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Recaptcha { get; set; }
    
        /// <summary>An error code to force on Item creation. Possible values are:
        /// <br/>
        /// <br/>`"INSTITUTION_NOT_RESPONDING"`
        /// <br/>`"INSTITUTION_NO_LONGER_SUPPORTED"`
        /// <br/>`"INVALID_CREDENTIALS"`
        /// <br/>`"INVALID_MFA"`
        /// <br/>`"ITEM_LOCKED"`
        /// <br/>`"ITEM_LOGIN_REQUIRED"`
        /// <br/>`"ITEM_NOT_SUPPORTED"`
        /// <br/>`"INVALID_LINK_TOKEN"`
        /// <br/>`"MFA_NOT_SUPPORTED"`
        /// <br/>`"NO_ACCOUNTS"`
        /// <br/>`"PLAID_ERROR"`
        /// <br/>`"PRODUCTS_NOT_SUPPORTED"`
        /// <br/>`"USER_SETUP_REQUIRED"`</summary>
        [Newtonsoft.Json.JsonProperty("force_error", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Force_error { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}