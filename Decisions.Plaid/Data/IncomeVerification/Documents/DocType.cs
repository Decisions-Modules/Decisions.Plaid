using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.IncomeVerification.Documents
{
    /// <summary>The type of document.
    /// <br/>
    /// <br/>`DOCUMENT_TYPE_PAYSTUB`: A paystub.
    /// <br/>
    /// <br/>`DOCUMENT_TYPE_BANK_STATEMENT`: A bank statement.
    /// <br/>
    /// <br/>`DOCUMENT_TYPE_US_TAX_W2`: A W-2 wage and tax statement provided by a US employer reflecting wages earned by the employee.
    /// <br/>
    /// <br/>`DOCUMENT_TYPE_US_MILITARY_ERAS`: An electronic Retirement Account Statement (eRAS) issued by the US military.
    /// <br/>
    /// <br/>`DOCUMENT_TYPE_US_MILITARY_LES`: A Leave and Earnings Statement (LES) issued by the US military.
    /// <br/>
    /// <br/>`DOCUMENT_TYPE_US_MILITARY_CLES`: A Civilian Leave and Earnings Statment (CLES) issued by the US military.
    /// <br/>
    /// <br/>`DOCUMENT_TYPE_GIG`: Used to indicate that the income is related to gig work. Does not necessarily correspond to a specific document type.
    /// <br/>
    /// <br/>`UNKNOWN`: Document type could not be determined.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum DocType
    {
        [EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 0,
    
        [EnumMember(Value = @"DOCUMENT_TYPE_PAYSTUB")]
        DOCUMENT_TYPE_PAYSTUB = 1,
    
        [EnumMember(Value = @"DOCUMENT_TYPE_BANK_STATEMENT")]
        DOCUMENT_TYPE_BANK_STATEMENT = 2,
    
        [EnumMember(Value = @"DOCUMENT_TYPE_US_TAX_W2")]
        DOCUMENT_TYPE_US_TAX_W2 = 3,
    
        [EnumMember(Value = @"DOCUMENT_TYPE_US_MILITARY_ERAS")]
        DOCUMENT_TYPE_US_MILITARY_ERAS = 4,
    
        [EnumMember(Value = @"DOCUMENT_TYPE_US_MILITARY_LES")]
        DOCUMENT_TYPE_US_MILITARY_LES = 5,
    
        [EnumMember(Value = @"DOCUMENT_TYPE_US_MILITARY_CLES")]
        DOCUMENT_TYPE_US_MILITARY_CLES = 6,
    
        [EnumMember(Value = @"DOCUMENT_TYPE_GIG")]
        DOCUMENT_TYPE_GIG = 7,
    
}
}