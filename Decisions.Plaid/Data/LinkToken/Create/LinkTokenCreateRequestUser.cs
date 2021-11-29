

using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.LinkToken.Create
{
    /// <summary>An object specifying information about the end user who will be linking their account.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class LinkTokenCreateRequestUser 
    {
        /// <summary>A unique ID representing the end user. Typically this will be a user ID number from your application. Personally identifiable information, such as an email address or phone number, should not be used in the `client_user_id`. It is currently used as a means of searching logs for the given user in the Plaid Dashboard.</summary>
        [Newtonsoft.Json.JsonProperty("client_user_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Client_user_id { get; set; }
    
        /// <summary>The user's full legal name. This is an optional field used in the [returning user experience](https://plaid.com/docs/link/returning-user) to associate Items to the user.</summary>
        [Newtonsoft.Json.JsonProperty("legal_name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Legal_name { get; set; }
    
        /// <summary>The user's phone number in [E.164](https://en.wikipedia.org/wiki/E.164) format. This field is optional, but required to enable the [returning user experience](https://plaid.com/docs/link/returning-user).</summary>
        [Newtonsoft.Json.JsonProperty("phone_number", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Phone_number { get; set; }
    
        /// <summary>The date and time the phone number was verified in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (`YYYY-MM-DDThh:mm:ssZ`). This field is optional, but required to enable any [returning user experience](https://plaid.com/docs/link/returning-user).
        /// <br/>
        /// <br/> Only pass a verification time for a phone number that you have verified. If you have performed verification but don’t have the time, you may supply a signal value of the start of the UNIX epoch.
        /// <br/>
        /// <br/> Example: `2020-01-01T00:00:00Z`
        /// <br/></summary>
        [Newtonsoft.Json.JsonProperty("phone_number_verified_time", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime Phone_number_verified_time { get; set; }
    
        /// <summary>The user's email address. This field is optional, but required to enable the [pre-authenticated returning user flow](https://plaid.com/docs/link/returning-user/#enabling-the-returning-user-experience).</summary>
        [Newtonsoft.Json.JsonProperty("email_address", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email_address { get; set; }
    
        /// <summary>The date and time the email address was verified in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (`YYYY-MM-DDThh:mm:ssZ`). This is an optional field used in the [returning user experience](https://plaid.com/docs/link/returning-user).
        /// <br/>
        /// <br/> Only pass a verification time for an email address that you have verified. If you have performed verification but don’t have the time, you may supply a signal value of the start of the UNIX epoch.
        /// <br/>
        /// <br/> Example: `2020-01-01T00:00:00Z`</summary>
        [Newtonsoft.Json.JsonProperty("email_address_verified_time", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime Email_address_verified_time { get; set; }
    
        /// <summary>To be provided in the format "ddd-dd-dddd". This field is optional and will support not-yet-implemented functionality for new products.</summary>
        [Newtonsoft.Json.JsonProperty("ssn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Ssn { get; set; }
    
        /// <summary>To be provided in the format "yyyy-mm-dd". This field is optional and will support not-yet-implemented functionality for new products.</summary>
        [Newtonsoft.Json.JsonProperty("date_of_birth", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Date_of_birth { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}