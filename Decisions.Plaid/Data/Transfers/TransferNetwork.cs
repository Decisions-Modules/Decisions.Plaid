using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transfers
{
    /// <summary>The network or rails used for the transfer. Valid options are `ach` or `same-day-ach`.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum TransferNetwork
    {
        [EnumMember(Value = @"ach")]
        Ach = 0,
    
        [EnumMember(Value = @"same-day-ach")]
        SameDayAch = 1,
    
}
}