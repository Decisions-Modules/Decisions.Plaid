using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Verification
{
    /// <summary>The verification refresh status. One of the following:
    /// <br/>
    /// <br/>`"VERIFICATION_REFRESH_STATUS_USER_PRESENCE_REQUIRED"` User presence is required to refresh an income verification.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum VerificationRefreshStatus
    {
        [EnumMember(Value = @"VERIFICATION_REFRESH_STATUS_USER_PRESENCE_REQUIRED")]
        VERIFICATION_REFRESH_STATUS_USER_PRESENCE_REQUIRED = 0,
    
}
}