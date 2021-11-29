using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.DepositSwitch.Target
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class DepositSwitchTargetUser 
    {
        /// <summary>The given name (first name) of the user.</summary>
        [Newtonsoft.Json.JsonProperty("given_name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Given_name { get; set; }
    
        /// <summary>The family name (last name) of the user.</summary>
        [Newtonsoft.Json.JsonProperty("family_name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Family_name { get; set; }
    
        /// <summary>The phone number of the user. The endpoint can accept a variety of phone number formats, including E.164.</summary>
        [Newtonsoft.Json.JsonProperty("phone", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Phone { get; set; }
    
        /// <summary>The email address of the user.</summary>
        [Newtonsoft.Json.JsonProperty("email", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Email { get; set; }
    
        [Newtonsoft.Json.JsonProperty("address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DepositSwitchAddressData Address { get; set; }
    
        /// <summary>The taxpayer ID of the user, generally their SSN, EIN, or TIN.</summary>
        [Newtonsoft.Json.JsonProperty("tax_payer_id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Tax_payer_id { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}