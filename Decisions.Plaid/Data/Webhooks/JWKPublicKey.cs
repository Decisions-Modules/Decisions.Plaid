using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Webhooks
{
    /// <summary>A JSON Web Key (JWK) that can be used in conjunction with [JWT libraries](https://jwt.io/#libraries-io) to verify Plaid webhooks</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    [Writable]
    public  class JWKPublicKey 
    {
        /// <summary>The alg member identifies the cryptographic algorithm family used with the key.</summary>
        [Newtonsoft.Json.JsonProperty("alg", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Alg { get; set; }
    
        /// <summary>The crv member identifies the cryptographic curve used with the key.</summary>
        [Newtonsoft.Json.JsonProperty("crv", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Crv { get; set; }
    
        /// <summary>The kid (Key ID) member can be used to match a specific key. This can be used, for instance, to choose among a set of keys within the JWK during key rollover.</summary>
        [Newtonsoft.Json.JsonProperty("kid", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Kid { get; set; }
    
        /// <summary>The kty (key type) parameter identifies the cryptographic algorithm family used with the key, such as RSA or EC.</summary>
        [Newtonsoft.Json.JsonProperty("kty", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Kty { get; set; }
    
        /// <summary>The use (public key use) parameter identifies the intended use of the public key.</summary>
        [Newtonsoft.Json.JsonProperty("use", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Use { get; set; }
    
        /// <summary>The x member contains the x coordinate for the elliptic curve point.</summary>
        [Newtonsoft.Json.JsonProperty("x", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string X { get; set; }
    
        /// <summary>The y member contains the y coordinate for the elliptic curve point.</summary>
        [Newtonsoft.Json.JsonProperty("y", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Y { get; set; }
    
        /// <summary>The timestamp when the key was created, in Unix time.</summary>
        [Newtonsoft.Json.JsonProperty("created_at", Required = Newtonsoft.Json.Required.Always)]
        public int Created_at { get; set; }
    
        /// <summary>The timestamp when the key expired, in Unix time.</summary>
        [Newtonsoft.Json.JsonProperty("expired_at", Required = Newtonsoft.Json.Required.AllowNull)]
        public int? Expired_at { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
}
}