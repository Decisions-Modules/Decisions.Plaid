using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.IncomeVerification.Precheck
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum IncomeVerificationPrecheckMilitaryInfoBranch
    {
        [EnumMember(Value = @"AIR FORCE")]
        AIR_FORCE = 0,
    
        [EnumMember(Value = @"ARMY")]
        ARMY = 1,
    
        [EnumMember(Value = @"COAST GUARD")]
        COAST_GUARD = 2,
    
        [EnumMember(Value = @"MARINES")]
        MARINES = 3,
    
        [EnumMember(Value = @"NAVY")]
        NAVY = 4,
    
}
}