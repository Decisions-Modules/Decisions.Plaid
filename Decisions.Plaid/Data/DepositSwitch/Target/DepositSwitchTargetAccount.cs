using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.DepositSwitch.Target
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class DepositSwitchTargetAccount 
    {
        /// <summary>Account number for deposit switch destination</summary>
        [Newtonsoft.Json.JsonProperty("account_number", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Account_number { get; set; }
    
        /// <summary>Routing number for deposit switch destination</summary>
        [Newtonsoft.Json.JsonProperty("routing_number", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Routing_number { get; set; }
    
        /// <summary>The name of the deposit switch destination account, as it will be displayed to the end user in the Deposit Switch interface. It is not required to match the name used in online banking.</summary>
        [Newtonsoft.Json.JsonProperty("account_name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Account_name { get; set; }
    
        /// <summary>The account subtype of the account, either `checking` or `savings`.</summary>
        [Newtonsoft.Json.JsonProperty("account_subtype", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DepositSwitchTargetAccountAccount_subtype Account_subtype { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}