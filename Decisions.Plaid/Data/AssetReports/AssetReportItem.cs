using System.Runtime.Serialization;
using Decisions.Plaid.Data.Accounts;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.AssetReports
{
    /// <summary>A representation of an Item within an Asset Report.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class AssetReportItem 
    {
        [Newtonsoft.Json.JsonProperty("item_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Item_id { get; set; }
    
        /// <summary>The full financial institution name associated with the Item.</summary>
        [Newtonsoft.Json.JsonProperty("institution_name", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Institution_name { get; set; }
    
        /// <summary>The id of the financial institution associated with the Item.</summary>
        [Newtonsoft.Json.JsonProperty("institution_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Institution_id { get; set; }
    
        /// <summary>The date and time when this Item’s data was last retrieved from the financial institution, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format.</summary>
        [Newtonsoft.Json.JsonProperty("date_last_updated", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTime Date_last_updated { get; set; }
    
        /// <summary>Data about each of the accounts open on the Item.</summary>
        [Newtonsoft.Json.JsonProperty("accounts", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.ObjectModel.Collection<AccountAssets> Accounts { get; set; } = new System.Collections.ObjectModel.Collection<AccountAssets>();
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}