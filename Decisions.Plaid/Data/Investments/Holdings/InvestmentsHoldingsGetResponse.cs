using System.Runtime.Serialization;
using Decisions.Plaid.Data.Accounts;
using Decisions.Plaid.Data.Items;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Investments.Holdings
{
    /// <summary>InvestmentsHoldingsGetResponse defines the response schema for `/investments/holdings/get`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class InvestmentsHoldingsGetResponse 
    {
        /// <summary>The accounts associated with the Item</summary>
        [Newtonsoft.Json.JsonProperty("accounts", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<AccountBase> Accounts { get; set; } = new System.Collections.ObjectModel.Collection<AccountBase>();
    
        /// <summary>The holdings belonging to investment accounts associated with the Item. Details of the securities in the holdings are provided in the `securities` field. </summary>
        [Newtonsoft.Json.JsonProperty("holdings", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<Holding> Holdings { get; set; } = new System.Collections.ObjectModel.Collection<Holding>();
    
        /// <summary>Objects describing the securities held in the accounts associated with the Item. </summary>
        [Newtonsoft.Json.JsonProperty("securities", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<Security> Securities { get; set; } = new System.Collections.ObjectModel.Collection<Security>();
    
        [Newtonsoft.Json.JsonProperty("item", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public Item Item { get; set; } = new Item();
    
        [Newtonsoft.Json.JsonProperty("request_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Request_id { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}