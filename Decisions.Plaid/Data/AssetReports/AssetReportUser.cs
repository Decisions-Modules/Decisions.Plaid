using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.AssetReports
{
    /// <summary>The user object allows you to provide additional information about the user to be appended to the Asset Report. All fields are optional. The `first_name`, `last_name`, and `ssn` fields are required if you would like the Report to be eligible for Fannie Mae’s Day 1 Certainty™ program.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class AssetReportUser 
    {
        /// <summary>An identifier you determine and submit for the user.</summary>
        [Newtonsoft.Json.JsonProperty("client_user_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Client_user_id { get; set; }
    
        /// <summary>The user's first name. Required for the Fannie Mae Day 1 Certainty™ program.</summary>
        [Newtonsoft.Json.JsonProperty("first_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string First_name { get; set; }
    
        /// <summary>The user's middle name</summary>
        [Newtonsoft.Json.JsonProperty("middle_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Middle_name { get; set; }
    
        /// <summary>The user's last name.  Required for the Fannie Mae Day 1 Certainty™ program.</summary>
        [Newtonsoft.Json.JsonProperty("last_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Last_name { get; set; }
    
        /// <summary>The user's Social Security Number. Required for the Fannie Mae Day 1 Certainty™ program.
        /// <br/>
        /// <br/>Format: "ddd-dd-dddd"</summary>
        [Newtonsoft.Json.JsonProperty("ssn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Ssn { get; set; }
    
        /// <summary>The user's phone number, in E.164 format: +{countrycode}{number}. For example: "+14151234567". Phone numbers provided in other formats will be parsed on a best-effort basis.</summary>
        [Newtonsoft.Json.JsonProperty("phone_number", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Phone_number { get; set; }
    
        /// <summary>The user's email address.</summary>
        [Newtonsoft.Json.JsonProperty("email", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}