using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.IncomeVerification.Precheck
{
    /// <summary>The confidence that Plaid can support the user in the income verification flow. One of the following:
    /// <br/>
    /// <br/>`"HIGH"`: This precheck information submitted is definitively tied to a Plaid-supported integration.
    /// <br/>
    /// <br/>"`LOW`": This precheck information submitted is known not to be supported by Plaid.
    /// <br/>
    /// <br/>`"UNKNOWN"`: It was not possible to determine if the user is supportable with the information passed.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum IncomeVerificationPrecheckConfidence
    {
        [EnumMember(Value = @"HIGH")]
        HIGH = 0,
    
        [EnumMember(Value = @"LOW")]
        LOW = 1,
    
        [EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 2,
    
    }
}