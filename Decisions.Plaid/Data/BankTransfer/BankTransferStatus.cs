using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.BankTransfer
{
    /// <summary>The status of the transfer.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum BankTransferStatus
    {
        [EnumMember(Value = @"pending")]
        Pending = 0,
    
        [EnumMember(Value = @"posted")]
        Posted = 1,
    
        [EnumMember(Value = @"cancelled")]
        Cancelled = 2,
    
        [EnumMember(Value = @"failed")]
        Failed = 3,
    
        [EnumMember(Value = @"reversed")]
        Reversed = 4,
    
}
}