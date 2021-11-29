using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Processors.Token
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum ProcessorTokenCreateRequestProcessor
    {
        [EnumMember(Value = @"achq")]
        Achq = 0,
    
        [EnumMember(Value = @"alpaca")]
        Alpaca = 1,
    
        [EnumMember(Value = @"astra")]
        Astra = 2,
    
        [EnumMember(Value = @"check")]
        Check = 3,
    
        [EnumMember(Value = @"checkbook")]
        Checkbook = 4,
    
        [EnumMember(Value = @"circle")]
        Circle = 5,
    
        [EnumMember(Value = @"drivewealth")]
        Drivewealth = 6,
    
        [EnumMember(Value = @"dwolla")]
        Dwolla = 7,
    
        [EnumMember(Value = @"galileo")]
        Galileo = 8,
    
        [EnumMember(Value = @"lithic")]
        Lithic = 9,
    
        [EnumMember(Value = @"modern_treasury")]
        Modern_treasury = 10,
    
        [EnumMember(Value = @"moov")]
        Moov = 11,
    
        [EnumMember(Value = @"ocrolus")]
        Ocrolus = 12,
    
        [EnumMember(Value = @"prime_trust")]
        Prime_trust = 13,
    
        [EnumMember(Value = @"rize")]
        Rize = 14,
    
        [EnumMember(Value = @"sila_money")]
        Sila_money = 15,
    
        [EnumMember(Value = @"svb_api")]
        Svb_api = 16,
    
        [EnumMember(Value = @"treasury_prime")]
        Treasury_prime = 17,
    
        [EnumMember(Value = @"unit")]
        Unit = 18,
    
        [EnumMember(Value = @"vesta")]
        Vesta = 19,
    
        [EnumMember(Value = @"vopay")]
        Vopay = 20,
    
        [EnumMember(Value = @"wyre")]
        Wyre = 21,
    
}
}