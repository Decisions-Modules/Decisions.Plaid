using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.BankTransfer
{
    /// <summary>The network or rails used for the transfer. Valid options are `ach`, `same-day-ach`, or `wire`.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum BankTransferNetwork
    {
        [EnumMember(Value = @"ach")]
        Ach = 0,
    
        [EnumMember(Value = @"same-day-ach")]
        SameDayAch = 1,
    
        [EnumMember(Value = @"wire")]
        Wire = 2,
    
}
}