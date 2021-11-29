using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transfers.Events
{
    /// <summary>The type of event that this transfer represents.
    /// <br/>
    /// <br/>`pending`: A new transfer was created; it is in the pending state.
    /// <br/>
    /// <br/>`cancelled`: The transfer was cancelled by the client.
    /// <br/>
    /// <br/>`failed`: The transfer failed, no funds were moved.
    /// <br/>
    /// <br/>`posted`: The transfer has been successfully submitted to the payment network.
    /// <br/>
    /// <br/>`reversed`: A posted transfer was reversed.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum TransferEventType
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
    
}
}