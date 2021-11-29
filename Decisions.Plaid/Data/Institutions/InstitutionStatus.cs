
using System.Runtime.Serialization;
using Decisions.Plaid.Data.Products;
using Decisions.Plaid.Data.Products.Status;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Institutions
{
    /// <summary>The status of an institution is determined by the health of its Item logins, Transactions updates, Investments updates, Liabilities updates, Auth requests, Balance requests, Identity requests, Investments requests, and Liabilities requests. A login attempt is conducted during the initial Item add in Link. If there is not enough traffic to accurately calculate an institution's status, Plaid will return null rather than potentially inaccurate data.
    /// <br/>
    /// <br/>Institution status is accessible in the Dashboard and via the API using the `/institutions/get_by_id` endpoint with the `include_status` option set to true. Note that institution status is not available in the Sandbox environment.
    /// <br/></summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class InstitutionStatus 
    {
        [Newtonsoft.Json.JsonProperty("item_logins", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ProductStatus Item_logins { get; set; } = new ProductStatus();
    
        [Newtonsoft.Json.JsonProperty("transactions_updates", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ProductStatus Transactions_updates { get; set; } = new ProductStatus();
    
        [Newtonsoft.Json.JsonProperty("auth", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ProductStatus Auth { get; set; } = new ProductStatus();
    
        [Newtonsoft.Json.JsonProperty("balance", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ProductStatus Balance { get; set; } = new ProductStatus();
    
        [Newtonsoft.Json.JsonProperty("identity", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ProductStatus Identity { get; set; } = new ProductStatus();
    
        [Newtonsoft.Json.JsonProperty("investments_updates", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public ProductStatus Investments_updates { get; set; } = new ProductStatus();
    
        [Newtonsoft.Json.JsonProperty("liabilities_updates", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ProductStatus Liabilities_updates { get; set; }
    
        [Newtonsoft.Json.JsonProperty("liabilities", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ProductStatus Liabilities { get; set; }
    
        [Newtonsoft.Json.JsonProperty("investments", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ProductStatus Investments { get; set; }
    
        /// <summary>Details of recent health incidents associated with the institution.</summary>
        [Newtonsoft.Json.JsonProperty("health_incidents", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.Collection<HealthIncident> Health_incidents { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}