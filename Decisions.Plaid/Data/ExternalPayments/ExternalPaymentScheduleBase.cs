using System.Runtime.Serialization;
using Decisions.Plaid.Data.Api;

using Decisions.Plaid.Data.PaymentInitiation;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.ExternalPayments
{
    /// <summary>The schedule that the payment will be executed on. If a schedule is provided, the payment is automatically set up as a standing order. If no schedule is specified, the payment will be executed only once.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class ExternalPaymentScheduleBase 
    {
        [Newtonsoft.Json.JsonProperty("interval", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 1)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PaymentScheduleInterval Interval { get; set; }
    
        /// <summary>The day of the interval on which to schedule the payment.
        /// <br/>
        /// <br/>If the payment interval is weekly, `interval_execution_day` should be an integer from 1 (Monday) to 7 (Sunday).
        /// <br/>
        /// <br/>If the payment interval is monthly, `interval_execution_day` should be an integer indicating which day of the month to make the payment on. Integers from 1 to 28 can be used to make a payment on that day of the month. Negative integers from -1 to -5 can be used to make a payment relative to the end of the month. To make a payment on the last day of the month, use -1; to make the payment on the second-to-last day, use -2, and so on.</summary>
        [Newtonsoft.Json.JsonProperty("interval_execution_day", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Interval_execution_day { get; set; }
    
        /// <summary>A date in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD). Standing order payments will begin on the first `interval_execution_day` on or after the `start_date`.
        /// <br/>
        /// <br/>If the first `interval_execution_day` on or after the start date is also the same day that `/payment_initiation/payment/create` was called, the bank *may* make the first payment on that day, but it is not guaranteed to do so.</summary>
        [Newtonsoft.Json.JsonProperty("start_date", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime Start_date { get; set; }
    
        /// <summary>A date in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD). Standing order payments will end on the last `interval_execution_day` on or before the `end_date`.
        /// <br/>If the only `interval_execution_day` between the start date and the end date (inclusive) is also the same day that `/payment_initiation/payment/create` was called, the bank *may* make a payment on that day, but it is not guaranteed to do so.</summary>
        [Newtonsoft.Json.JsonProperty("end_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? End_date { get; set; }
    
        /// <summary>The start date sent to the bank after adjusting for holidays or weekends.  Will be provided in [ISO 8601](https://wikipedia.org/wiki/ISO_8601) format (YYYY-MM-DD). If the start date did not require adjustment, this field will be `null`.</summary>
        [Newtonsoft.Json.JsonProperty("adjusted_start_date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(DateFormatConverter))]
        public System.DateTime? Adjusted_start_date { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}