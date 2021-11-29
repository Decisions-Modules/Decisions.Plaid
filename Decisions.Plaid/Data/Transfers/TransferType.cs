using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transfers
{
    /// <summary>The type of transfer. This will be either `debit` or `credit`.  A `debit` indicates a transfer of money into the origination account; a `credit` indicates a transfer of money out of the origination account.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum TransferType
    {
        [EnumMember(Value = @"debit")]
        Debit = 0,
    
        [EnumMember(Value = @"credit")]
        Credit = 1,
    
}
}