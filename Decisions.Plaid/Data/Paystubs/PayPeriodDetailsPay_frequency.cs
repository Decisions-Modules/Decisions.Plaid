using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Paystubs
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum PayPeriodDetailsPay_frequency
    {
        [EnumMember(Value = @"PAY_FREQUENCY_UNKNOWN")]
        PAY_FREQUENCY_UNKNOWN = 0,
    
        [EnumMember(Value = @"PAY_FREQUENCY_WEEKLY")]
        PAY_FREQUENCY_WEEKLY = 1,
    
        [EnumMember(Value = @"PAY_FREQUENCY_BIWEEKLY")]
        PAY_FREQUENCY_BIWEEKLY = 2,
    
        [EnumMember(Value = @"PAY_FREQUENCY_SEMIMONTHLY")]
        PAY_FREQUENCY_SEMIMONTHLY = 3,
    
        [EnumMember(Value = @"PAY_FREQUENCY_MONTHLY")]
        PAY_FREQUENCY_MONTHLY = 4,
    
}
}