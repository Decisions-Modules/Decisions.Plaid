using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.DepositSwitch.Get
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum DepositSwitchGetResponseSwitch_method
    {
        [EnumMember(Value = @"instant")]
        Instant = 0,
    
        [EnumMember(Value = @"mail")]
        Mail = 1,
    
        [EnumMember(Value = @"pdf")]
        Pdf = 2,
    
}
}