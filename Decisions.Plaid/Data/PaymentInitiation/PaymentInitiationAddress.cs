using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.PaymentInitiation
{
    /// <summary>The optional address of the payment recipient. This object is not currently required to make payments from UK institutions and should not be populated, though may be necessary for future European expansion.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class PaymentInitiationAddress 
    {
        /// <summary>An array of length 1-2 representing the street address where the recipient is located. Maximum of 70 characters.</summary>
        [Newtonsoft.Json.JsonProperty("street", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.MinLength(1)]
        public System.Collections.ObjectModel.Collection<string> Street { get; set; } = new System.Collections.ObjectModel.Collection<string>();
    
        /// <summary>The city where the recipient is located. Maximum of 35 characters.</summary>
        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(35, MinimumLength = 1)]
        public string City { get; set; }
    
        /// <summary>The postal code where the recipient is located. Maximum of 16 characters.</summary>
        [Newtonsoft.Json.JsonProperty("postal_code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(16, MinimumLength = 1)]
        public string Postal_code { get; set; }
    
        /// <summary>The ISO 3166-1 alpha-2 country code where the recipient is located.</summary>
        [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(2, MinimumLength = 2)]
        public string Country { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}