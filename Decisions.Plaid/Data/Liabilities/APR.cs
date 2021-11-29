using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Liabilities
{
    /// <summary>Information about the APR on the account.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class APR 
    {
        /// <summary>Annual Percentage Rate applied.
        /// <br/></summary>
        [Newtonsoft.Json.JsonProperty("apr_percentage", Required = Newtonsoft.Json.Required.Always)]
        public double Apr_percentage { get; set; }
    
        /// <summary>The type of balance to which the APR applies.</summary>
        [Newtonsoft.Json.JsonProperty("apr_type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Apr_type Apr_type { get; set; }
    
        /// <summary>Amount of money that is subjected to the APR if a balance was carried beyond payment due date. How it is calculated can vary by card issuer. It is often calculated as an average daily balance.</summary>
        [Newtonsoft.Json.JsonProperty("balance_subject_to_apr", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Balance_subject_to_apr { get; set; }
    
        /// <summary>Amount of money charged due to interest from last statement.</summary>
        [Newtonsoft.Json.JsonProperty("interest_charge_amount", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Interest_charge_amount { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}