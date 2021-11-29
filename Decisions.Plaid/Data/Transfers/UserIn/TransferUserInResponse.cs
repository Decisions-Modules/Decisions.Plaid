using System.Runtime.Serialization;
using Decisions.Plaid.Data.Transfers.UserAddressIn;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transfers.UserIn
{
    /// <summary>The legal name and other information for the account holder.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class TransferUserInResponse 
    {
        /// <summary>The user's legal name.</summary>
        [Newtonsoft.Json.JsonProperty("legal_name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Legal_name { get; set; }
    
        /// <summary>The user's phone number.</summary>
        [Newtonsoft.Json.JsonProperty("phone_number", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Phone_number { get; set; }
    
        /// <summary>The user's email address.</summary>
        [Newtonsoft.Json.JsonProperty("email_address", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Email_address { get; set; }
    
        [Newtonsoft.Json.JsonProperty("address", Required = Newtonsoft.Json.Required.AllowNull)]
        public TransferUserAddressInResponse Address { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}