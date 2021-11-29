using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Items
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum ItemUpdate_type
    {
        [EnumMember(Value = @"background")]
        Background = 0,
    
        [EnumMember(Value = @"user_present_required")]
        User_present_required = 1,
    
}
}