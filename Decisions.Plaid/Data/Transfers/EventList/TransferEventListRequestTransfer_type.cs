using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transfers.EventList
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum TransferEventListRequestTransfer_type
    {
        [EnumMember(Value = @"debit")]
        Debit = 0,
    
        [EnumMember(Value = @"credit")]
        Credit = 1,
    
}
}