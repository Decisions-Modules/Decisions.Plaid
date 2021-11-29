
using System.Runtime.Serialization;
using Decisions.Plaid.Data.StudentLoans;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Liabilities
{
    /// <summary>An object containing liability accounts</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class LiabilitiesObject 
    {
        /// <summary>The credit accounts returned.</summary>
        [Newtonsoft.Json.JsonProperty("credit", Required = Newtonsoft.Json.Required.AllowNull)]
        public System.Collections.ObjectModel.Collection<CreditCardLiability> Credit { get; set; }
    
        /// <summary>The mortgage accounts returned.</summary>
        [Newtonsoft.Json.JsonProperty("mortgage", Required = Newtonsoft.Json.Required.AllowNull)]
        public System.Collections.ObjectModel.Collection<MortgageLiability> Mortgage { get; set; }
    
        /// <summary>The student loan accounts returned.</summary>
        [Newtonsoft.Json.JsonProperty("student", Required = Newtonsoft.Json.Required.AllowNull)]
        public System.Collections.ObjectModel.Collection<StudentLoan> Student { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}