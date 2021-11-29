using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transfers.Authorization
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum TransferAuthorizationDecision
    {
        [EnumMember(Value = @"approved")]
        Approved = 0,
    
        [EnumMember(Value = @"permitted")]
        Permitted = 1,
    
        [EnumMember(Value = @"declined")]
        Declined = 2,
    
}
}