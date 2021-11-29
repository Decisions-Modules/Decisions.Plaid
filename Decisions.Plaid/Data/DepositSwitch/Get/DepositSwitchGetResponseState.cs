using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.DepositSwitch.Get
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum DepositSwitchGetResponseState
    {
        [EnumMember(Value = @"initialized")]
        Initialized = 0,
    
        [EnumMember(Value = @"processing")]
        Processing = 1,
    
        [EnumMember(Value = @"completed")]
        Completed = 2,
    
        [EnumMember(Value = @"error")]
        Error = 3,
    
}
}