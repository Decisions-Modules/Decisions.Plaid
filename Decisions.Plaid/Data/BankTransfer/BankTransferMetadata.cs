using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.BankTransfer
{
    /// <summary>The Metadata object is a mapping of client-provided string fields to any string value. The following limitations apply:
    /// <br/>- The JSON values must be Strings (no nested JSON objects allowed)
    /// <br/>- Only ASCII characters may be used
    /// <br/>- Maximum of 50 key/value pairs
    /// <br/>- Maximum key length of 40 characters
    /// <br/>- Maximum value length of 500 characters
    /// <br/></summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class BankTransferMetadata : System.Collections.Generic.Dictionary<string, string>
    {
    
}
}