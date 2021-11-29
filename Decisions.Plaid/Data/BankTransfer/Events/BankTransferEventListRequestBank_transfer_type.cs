using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.BankTransfer.Events
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum BankTransferEventListRequestBank_transfer_type
    {
        [EnumMember(Value = @"debit")]
        Debit = 0,
    
        [EnumMember(Value = @"credit")]
        Credit = 1,
    
}
}