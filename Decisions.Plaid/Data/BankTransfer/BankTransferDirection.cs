using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.BankTransfer
{
    /// <summary>Indicates the direction of the transfer: `outbound` for API-initiated transfers, or `inbound` for payments received by the FBO account.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum BankTransferDirection
    {
        [EnumMember(Value = @"outbound")]
        Outbound = 0,
    
        [EnumMember(Value = @"inbound")]
        Inbound = 1,
    
}
}