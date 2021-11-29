using System.Runtime.Serialization;
using Decisions.Plaid.Data.Signal;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.IncomeVerification.Precheck
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class IncomeVerificationPrecheckUser 
    {
        /// <summary>The user's first name</summary>
        [Newtonsoft.Json.JsonProperty("first_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string First_name { get; set; }
    
        /// <summary>The user's last name</summary>
        [Newtonsoft.Json.JsonProperty("last_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Last_name { get; set; }
    
        /// <summary>The user's email address</summary>
        [Newtonsoft.Json.JsonProperty("email_address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email_address { get; set; }
    
        [Newtonsoft.Json.JsonProperty("home_address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SignalAddressData Home_address { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
}