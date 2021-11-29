using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transactions
{
    /// <summary>describes the frequency of the transaction stream.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum RecurringTransactionFrequency
    {
        [EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 0,
    
        [EnumMember(Value = @"WEEKLY")]
        WEEKLY = 1,
    
        [EnumMember(Value = @"BIWEEKLY")]
        BIWEEKLY = 2,
    
        [EnumMember(Value = @"SEMI_MONTHLY")]
        SEMI_MONTHLY = 3,
    
        [EnumMember(Value = @"MONTHLY")]
        MONTHLY = 4,
    
}
}