

using System.Runtime.Serialization;
using Decisions.Plaid.Data.ExternalPayments;
using Decisions.Plaid.Data.PaymentInitiation.Refund;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.PaymentInitiation.Payments
{
    /// <summary>PaymentInitiationPayment defines a payment initiation payment</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class PaymentInitiationPayment 
    {
        /// <summary>The ID of the payment. Like all Plaid identifiers, the `payment_id` is case sensitive.</summary>
        [Newtonsoft.Json.JsonProperty("payment_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Payment_id { get; set; }
    
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public PaymentAmount Amount { get; set; } = new PaymentAmount();
    
        /// <summary>The status of the payment.
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
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PaymentInitiationPaymentStatus Status { get; set; }
    
        /// <summary>The ID of the recipient</summary>
        [Newtonsoft.Json.JsonProperty("recipient_id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Recipient_id { get; set; }
    
        /// <summary>A reference for the payment.</summary>
        [Newtonsoft.Json.JsonProperty("reference", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Reference { get; set; }
    
        /// <summary>The value of the reference sent to the bank after adjustment to pass bank validation rules.</summary>
        [Newtonsoft.Json.JsonProperty("adjusted_reference", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Adjusted_reference { get; set; }
    
        /// <summary>The date and time of the last time the `status` was updated, in IS0 8601 format</summary>
        [Newtonsoft.Json.JsonProperty("last_status_update", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTime Last_status_update { get; set; }
    
        [Newtonsoft.Json.JsonProperty("schedule", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ExternalPaymentScheduleGet Schedule { get; set; }
    
        [Newtonsoft.Json.JsonProperty("refund_details", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public ExternalPaymentRefundDetails Refund_details { get; set; }
    
        [Newtonsoft.Json.JsonProperty("bacs", Required = Newtonsoft.Json.Required.AllowNull)]
        public SenderBACSNullable Bacs { get; set; }
    
        /// <summary>The International Bank Account Number (IBAN) for the sender, if specified in the `/payment_initiation/payment/create` call.</summary>
        [Newtonsoft.Json.JsonProperty("iban", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Iban { get; set; }
    
        /// <summary>Initiated refunds associated with the payment.</summary>
        [Newtonsoft.Json.JsonProperty("initiated_refunds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.ObjectModel.Collection<PaymentInitiationRefund> Initiated_refunds { get; set; }
    
        /// <summary>The EMI (E-Money Institution) account that this payment is associated with, if any. This EMI account is used as an intermediary account to enable Plaid to reconcile the settlement of funds for Payment Initiation requests.</summary>
        [Newtonsoft.Json.JsonProperty("emi_account_id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 1)]
        public string Emi_account_id { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}