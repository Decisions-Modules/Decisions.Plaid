using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.DepositSwitch.Target
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum DepositSwitchTargetAccountAccount_subtype
    {
        [EnumMember(Value = @"checking")]
        Checking = 0,
    
        [EnumMember(Value = @"savings")]
        Savings = 1,
    
}
}