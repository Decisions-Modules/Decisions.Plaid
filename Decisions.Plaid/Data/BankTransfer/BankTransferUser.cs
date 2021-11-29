using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.BankTransfer
{
    /// <summary>The legal name and other information for the account holder.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class BankTransferUser 
    {
        /// <summary>The account holder’s full legal name. If the transfer description is `ccd`, this should be the business name of the account holder.</summary>
        [Newtonsoft.Json.JsonProperty("legal_name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Legal_name { get; set; }
    
        /// <summary>The account holder’s email.</summary>
        [Newtonsoft.Json.JsonProperty("email_address", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email_address { get; set; }
    
        /// <summary>The account holder's routing number. This field is only used in response data. Do not provide this field when making requests.</summary>
        [Newtonsoft.Json.JsonProperty("routing_number", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Routing_number { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}