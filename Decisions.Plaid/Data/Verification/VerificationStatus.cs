using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Verification
{
    /// <summary>The verification status. One of the following:
    /// <br/>
    /// <br/>`"VERIFIED"`: The information was successfully verified.
    /// <br/>
    /// <br/>`"UNVERIFIED"`: The verification has not yet been performed.
    /// <br/>
    /// <br/>`"NEEDS_INFO"`: The verification was attempted but could not be completed due to missing information.
    /// <br/>
    /// <br/>"`UNABLE_TO_VERIFY`": The verification was performed and the information could not be verified.
    /// <br/>
    /// <br/>`"UNKNOWN"`: The verification status is unknown.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum VerificationStatus
    {
        [EnumMember(Value = @"VERIFIED")]
        VERIFIED = 0,
    
        [EnumMember(Value = @"UNVERIFIED")]
        UNVERIFIED = 1,
    
        [EnumMember(Value = @"NEEDS_INFO")]
        NEEDS_INFO = 2,
    
        [EnumMember(Value = @"UNABLE_TO_VERIFY")]
        UNABLE_TO_VERIFY = 3,
    
        [EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 4,
    
}
}