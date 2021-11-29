

using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.PaymentInitiation
{
    /// <summary>An optional object used to restrict the accounts used for payments. If provided, the end user will be able to send payments only from the specified bank account.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class PaymentInitiationOptionalRestrictionBacs : RecipientBACS
    {
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}