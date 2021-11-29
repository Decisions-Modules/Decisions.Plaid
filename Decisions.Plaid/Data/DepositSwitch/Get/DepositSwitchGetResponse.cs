

using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.DepositSwitch.Get
{
    /// <summary>DepositSwitchGetResponse defines the response schema for `/deposit_switch/get`</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class DepositSwitchGetResponse 
    {
        /// <summary>The ID of the deposit switch.</summary>
        [Newtonsoft.Json.JsonProperty("deposit_switch_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Deposit_switch_id { get; set; }
    
        /// <summary>The ID of the bank account the direct deposit was switched to.</summary>
        [Newtonsoft.Json.JsonProperty("target_account_id", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Target_account_id { get; set; }
    
        /// <summary>The ID of the Item the direct deposit was switched to.</summary>
        [Newtonsoft.Json.JsonProperty("target_item_id", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Target_item_id { get; set; }
    
        /// <summary>
        /// <br/>The state, or status, of the deposit switch.
        /// <br/>
        /// <br/>- `initialized` – The deposit switch has been initialized with the user entering the information required to submit the deposit switch request.
        /// <br/>
        /// <br/>- `processing` – The deposit switch request has been submitted and is being processed.
        /// <br/>
        /// <br/>- `completed` – The user's employer has fulfilled the deposit switch request.
        /// <br/>
        /// <br/>- `error` – There was an error processing the deposit switch request.</summary>
        [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DepositSwitchGetResponseState State { get; set; }
    
        /// <summary>The method used to make the deposit switch.
        /// <br/>
        /// <br/>- `instant` – User instantly switched their direct deposit to a new or existing bank account by connecting their payroll or employer account.
        /// <br/>
        /// <br/>- `mail` – User requested that Plaid contact their employer by mail to make the direct deposit switch.
        /// <br/>
        /// <br/>- `pdf` – User generated a PDF or email to be sent to their employer with the information necessary to make the deposit switch.'</summary>
        [Newtonsoft.Json.JsonProperty("switch_method", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DepositSwitchGetResponseSwitch_method? Switch_method { get; set; }
    
        /// <summary>When `true`, user’s direct deposit goes to multiple banks. When false, user’s direct deposit only goes to the target account. Always `null` if the deposit switch has not been completed.</summary>
        [Newtonsoft.Json.JsonProperty("account_has_multiple_allocations", Required = Newtonsoft.Json.Required.AllowNull)]
        public bool? Account_has_multiple_allocations { get; set; }
    
        /// <summary>When `true`, the target account is allocated the remainder of direct deposit after all other allocations have been deducted. When `false`, user’s direct deposit is allocated as a percent or amount. Always `null` if the deposit switch has not been completed.</summary>
        [Newtonsoft.Json.JsonProperty("is_allocated_remainder", Required = Newtonsoft.Json.Required.AllowNull)]
        public bool? Is_allocated_remainder { get; set; }
    
        /// <summary>The percentage of direct deposit allocated to the target account. Always `null` if the target account is not allocated a percentage or if the deposit switch has not been completed or if `is_allocated_remainder` is true.</summary>
        [Newtonsoft.Json.JsonProperty("percent_allocated", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Percent_allocated { get; set; }
    
        /// <summary>The dollar amount of direct deposit allocated to the target account. Always `null` if the target account is not allocated an amount or if the deposit switch has not been completed.</summary>
        [Newtonsoft.Json.JsonProperty("amount_allocated", Required = Newtonsoft.Json.Required.AllowNull)]
        public double? Amount_allocated { get; set; }
    
        /// <summary>The name of the employer selected by the user. If the user did not select an employer, the value returned is `null`.</summary>
        [Newtonsoft.Json.JsonProperty("employer_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Employer_name { get; set; }
    
        /// <summary>The ID of the employer selected by the user. If the user did not select an employer, the value returned is `null`.</summary>
        [Newtonsoft.Json.JsonProperty("employer_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Employer_id { get; set; }
    
        /// <summary>The name of the institution selected by the user. If the user did not select an institution, the value returned is `null`.</summary>
        [Newtonsoft.Json.JsonProperty("institution_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Institution_name { get; set; }
    
        /// <summary>The ID of the institution selected by the user. If the user did not select an institution, the value returned is `null`.</summary>
        [Newtonsoft.Json.JsonProperty("institution_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Institution_id { get; set; }
    
        /// <summary>[ISO 8601](https://wikipedia.org/wiki/ISO_8601) date the deposit switch was created.
        /// <br/></summary>
        [Newtonsoft.Json.JsonProperty("date_created", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Date_created { get; set; }
    
        /// <summary>[ISO 8601](https://wikipedia.org/wiki/ISO_8601) date the deposit switch was completed. Always `null` if the deposit switch has not been completed.
        /// <br/></summary>
        [Newtonsoft.Json.JsonProperty("date_completed", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Date_completed { get; set; }
    
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