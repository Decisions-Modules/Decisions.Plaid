using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Employees
{
    /// <summary>Current employment status.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum EmploymentVerificationStatus
    {
        [EnumMember(Value = @"EMPLOYMENT_STATUS_ACTIVE")]
        EMPLOYMENT_STATUS_ACTIVE = 0,
    
        [EnumMember(Value = @"EMPLOYMENT_STATUS_INACTIVE")]
        EMPLOYMENT_STATUS_INACTIVE = 1,
    
}
}