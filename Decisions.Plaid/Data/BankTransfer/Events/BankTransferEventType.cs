using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.BankTransfer.Events
{
    /// <summary>The type of event that this bank transfer represents.
    /// <br/>
    /// <br/>`pending`: A new transfer was created; it is in the pending state.
    /// <br/>
    /// <br/>`cancelled`: The transfer was cancelled by the client.
    /// <br/>
    /// <br/>`failed`: The transfer failed, no funds were moved.
    /// <br/>
    /// <br/>`posted`: The transfer has been successfully submitted to the payment network.
    /// <br/>
    /// <br/>`reversed`: A posted transfer was reversed.
    /// <br/>
    /// <br/>`receiver_pending`: The matching transfer was found as a pending transaction in the receiver's account
    /// <br/>
    /// <br/>`receiver_posted`: The matching transfer was found as a posted transaction in the receiver's account</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum BankTransferEventType
    {
        [EnumMember(Value = @"pending")]
        Pending = 0,
    
        [EnumMember(Value = @"cancelled")]
        Cancelled = 1,
    
        [EnumMember(Value = @"failed")]
        Failed = 2,
    
        [EnumMember(Value = @"posted")]
        Posted = 3,
    
        [EnumMember(Value = @"reversed")]
        Reversed = 4,
    
        [EnumMember(Value = @"receiver_pending")]
        Receiver_pending = 5,
    
        [EnumMember(Value = @"receiver_posted")]
        Receiver_posted = 6,
    
}
}