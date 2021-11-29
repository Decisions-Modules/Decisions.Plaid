using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Scope
{
    /// <summary>An indicator for when scopes are being updated. When scopes are updated via enrollment (i.e. OAuth), the partner must send `ENROLLMENT`. When scopes are updated in a post-enrollment view, the partner must send `PORTAL`.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum ScopesContext
    {
        [EnumMember(Value = @"ENROLLMENT")]
        ENROLLMENT = 0,
    
        [EnumMember(Value = @"PORTAL")]
        PORTAL = 1,
    
}
}