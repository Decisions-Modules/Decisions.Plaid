using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Accounts
{
    /// <summary>Specifies the multi-factor authentication settings to use with this test account</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class MFA 
    {
        /// <summary>Possible values are `device`, `selections`, or `questions`.
        /// <br/>
        /// <br/>If value is `device`, the MFA answer is `1234`.
        /// <br/>
        /// <br/>If value is `selections`, the MFA answer is always the first option.
        /// <br/>
        /// <br/>If value is `questions`, the MFA answer is  `answer_&lt;i&gt;_&lt;j&gt;` for the j-th question in the i-th round, starting from 0. For example, the answer to the first question in the second round is `answer_1_0`.</summary>
        [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Type { get; set; }
    
        /// <summary>Number of rounds of questions. Required if value of `type` is `questions`. </summary>
        [Newtonsoft.Json.JsonProperty("question_rounds", Required = Newtonsoft.Json.Required.Always)]
        public double Question_rounds { get; set; }
    
        /// <summary>Number of questions per round. Required if value of `type` is `questions`. If value of type is `selections`, default value is 2.</summary>
        [Newtonsoft.Json.JsonProperty("questions_per_round", Required = Newtonsoft.Json.Required.Always)]
        public double Questions_per_round { get; set; }
    
        /// <summary>Number of rounds of selections, used if `type` is `selections`. Defaults to 1.</summary>
        [Newtonsoft.Json.JsonProperty("selection_rounds", Required = Newtonsoft.Json.Required.Always)]
        public double Selection_rounds { get; set; }
    
        /// <summary>Number of available answers per question, used if `type` is `selection`. Defaults to 2.
        /// <br/></summary>
        [Newtonsoft.Json.JsonProperty("selections_per_question", Required = Newtonsoft.Json.Required.Always)]
        public double Selections_per_question { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}