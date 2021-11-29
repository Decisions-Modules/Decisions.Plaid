using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Transfers
{
    /// <summary>Specifies the use case of the transfer.  Required for transfers on an ACH network.
    /// <br/>
    /// <br/>`"arc"` - Accounts Receivable Entry
    /// <br/>
    /// <br/>`"cbr`" - Cross Border Entry
    /// <br/>
    /// <br/>`"ccd"` - Corporate Credit or Debit - fund transfer between two corporate bank accounts
    /// <br/>
    /// <br/>`"cie"` - Customer Initiated Entry
    /// <br/>
    /// <br/>`"cor"` - Automated Notification of Change
    /// <br/>
    /// <br/>`"ctx"` - Corporate Trade Exchange
    /// <br/>
    /// <br/>`"iat"` - International
    /// <br/>
    /// <br/>`"mte"` - Machine Transfer Entry
    /// <br/>
    /// <br/>`"pbr"` - Cross Border Entry
    /// <br/>
    /// <br/>`"pop"` - Point-of-Purchase Entry
    /// <br/>
    /// <br/>`"pos"` - Point-of-Sale Entry
    /// <br/>
    /// <br/>`"ppd"` - Prearranged Payment or Deposit - the transfer is part of a pre-existing relationship with a consumer, eg. bill payment
    /// <br/>
    /// <br/>`"rck"` - Re-presented Check Entry
    /// <br/>
    /// <br/>`"tel"` - Telephone-Initiated Entry
    /// <br/>
    /// <br/>`"web"` - Internet-Initiated Entry - debits from a consumer’s account where their authorization is obtained over the Internet</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum ACHClass
    {
        [EnumMember(Value = @"arc")]
        Arc = 0,
    
        [EnumMember(Value = @"cbr")]
        Cbr = 1,
    
        [EnumMember(Value = @"ccd")]
        Ccd = 2,
    
        [EnumMember(Value = @"cie")]
        Cie = 3,
    
        [EnumMember(Value = @"cor")]
        Cor = 4,
    
        [EnumMember(Value = @"ctx")]
        Ctx = 5,
    
        [EnumMember(Value = @"iat")]
        Iat = 6,
    
        [EnumMember(Value = @"mte")]
        Mte = 7,
    
        [EnumMember(Value = @"pbr")]
        Pbr = 8,
    
        [EnumMember(Value = @"pop")]
        Pop = 9,
    
        [EnumMember(Value = @"pos")]
        Pos = 10,
    
        [EnumMember(Value = @"ppd")]
        Ppd = 11,
    
        [EnumMember(Value = @"rck")]
        Rck = 12,
    
        [EnumMember(Value = @"tel")]
        Tel = 13,
    
        [EnumMember(Value = @"web")]
        Web = 14,
    
    }
} 