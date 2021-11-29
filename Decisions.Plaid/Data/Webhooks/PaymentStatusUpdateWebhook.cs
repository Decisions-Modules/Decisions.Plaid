using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Webhooks
{
    /// <summary>Fired when the status of a payment has changed.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class PaymentStatusUpdateWebhook 
    {
        /// <summary>`PAYMENT_INITIATION`</summary>
        [Newtonsoft.Json.JsonProperty("webhook_type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Webhook_type { get; set; }
    
        /// <summary>`PAYMENT_STATUS_UPDATE`</summary>
        [Newtonsoft.Json.JsonProperty("webhook_code", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Webhook_code { get; set; }
    
        /// <summary>The `payment_id` for the payment being updated</summary>
        [Newtonsoft.Json.JsonProperty("payment_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Payment_id { get; set; }
    
        /// <summary>The new status of the payment.
        /// <br/>
        /// <br/>`PAYMENT_STATUS_INPUT_NEEDED`: This is the initial state of all payments. It indicates that the payment is waiting on user input to continue processing. A payment may re-enter this state later on if further input is needed.
        /// <br/>
        /// <br/>`PAYMENT_STATUS_PROCESSING`: The payment is currently being processed. The payment will automatically exit this state when processing is complete.
        /// <br/>
        /// <br/>`PAYMENT_STATUS_INITIATED`: The payment has been successfully initiated and is considered complete.
        /// <br/>
        /// <br/>`PAYMENT_STATUS_COMPLETED`: Indicates that the standing order has been successfully established. This state is only used for standing orders.
        /// <br/>
        /// <br/>`PAYMENT_STATUS_INSUFFICIENT_FUNDS`: The payment has failed due to insufficient funds.
        /// <br/>
        /// <br/>`PAYMENT_STATUS_FAILED`: The payment has failed to be initiated. This error is retryable once the root cause is resolved.
        /// <br/>
        /// <br/>`PAYMENT_STATUS_BLOCKED`: The payment has been blocked. This is a retryable error.
        /// <br/>
        /// <br/>`PAYMENT_STATUS_UNKNOWN`: The payment status is unknown.</summary>
        [Newtonsoft.Json.JsonProperty("new_payment_status", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PaymentStatusUpdateWebhookNew_payment_status New_payment_status { get; set; }
    
        /// <summary>The previous status of the payment.
        /// <br/>
        /// <br/>`PAYMENT_STATUS_INPUT_NEEDED`: This is the initial state of all payments. It indicates that the payment is waiting on user input to continue processing. A payment may re-enter this state later on if further input is needed.
        /// <br/>
        /// <br/>`PAYMENT_STATUS_PROCESSING`: The payment is currently being processed. The payment will automatically exit this state when processing is complete.
        /// <br/>
        /// <br/>`PAYMENT_STATUS_INITIATED`: The payment has been successfully initiated and is considered complete.
        /// <br/>
        /// <br/>`PAYMENT_STATUS_COMPLETED`: Indicates that the standing order has been successfully established. This state is only used for standing orders.
        /// <br/>
        /// <br/>`PAYMENT_STATUS_INSUFFICIENT_FUNDS`: The payment has failed due to insufficient funds.
        /// <br/>
        /// <br/>`PAYMENT_STATUS_FAILED`: The payment has failed to be initiated. This error is retryable once the root cause is resolved.
        /// <br/>
        /// <br/>`PAYMENT_STATUS_BLOCKED`: The payment has been blocked. This is a retryable error.
        /// <br/>
        /// <br/>`PAYMENT_STATUS_UNKNOWN`: The payment status is unknown.</summary>
        [Newtonsoft.Json.JsonProperty("old_payment_status", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PaymentStatusUpdateWebhookOld_payment_status Old_payment_status { get; set; }
    
        /// <summary>The original value of the reference when creating the payment.</summary>
        [Newtonsoft.Json.JsonProperty("original_reference", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Original_reference { get; set; }
    
        /// <summary>The value of the reference sent to the bank after adjustment to pass bank validation rules.</summary>
        [Newtonsoft.Json.JsonProperty("adjusted_reference", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Adjusted_reference { get; set; }
    
        /// <summary>The original value of the `start_date` provided during the creation of a standing order. If the payment is not a standing order, this field will be `null`.</summary>
        [Newtonsoft.Json.JsonProperty("original_start_date", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Original_start_date { get; set; }
    
        /// <summary>The start date sent to the bank after adjusting for holidays or weekends.  Will be provided in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD). If the start date did not require adjustment, or if the payment is not a standing order, this field will be `null`.</summary>
        [Newtonsoft.Json.JsonProperty("adjusted_start_date", Required = Newtonsoft.Json.Required.AllowNull)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Adjusted_start_date { get; set; }
    
        /// <summary>The timestamp of the update, in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format, e.g. `"2017-09-14T14:42:19.350Z"`</summary>
        [Newtonsoft.Json.JsonProperty("timestamp", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTime Timestamp { get; set; }
    
        [Newtonsoft.Json.JsonProperty("error", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Error Error { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}