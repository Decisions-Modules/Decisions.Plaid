using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Investments.Transactions
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum InvestmentTransactionSubtype
    {
        [EnumMember(Value = @"account fee")]
        Account_fee = 0,
    
        [EnumMember(Value = @"assignment")]
        Assignment = 1,
    
        [EnumMember(Value = @"buy")]
        Buy = 2,
    
        [EnumMember(Value = @"buy to cover")]
        Buy_to_cover = 3,
    
        [EnumMember(Value = @"contribution")]
        Contribution = 4,
    
        [EnumMember(Value = @"deposit")]
        Deposit = 5,
    
        [EnumMember(Value = @"distribution")]
        Distribution = 6,
    
        [EnumMember(Value = @"dividend")]
        Dividend = 7,
    
        [EnumMember(Value = @"dividend reinvestment")]
        Dividend_reinvestment = 8,
    
        [EnumMember(Value = @"exercise")]
        Exercise = 9,
    
        [EnumMember(Value = @"expire")]
        Expire = 10,
    
        [EnumMember(Value = @"fund fee")]
        Fund_fee = 11,
    
        [EnumMember(Value = @"interest")]
        Interest = 12,
    
        [EnumMember(Value = @"interest receivable")]
        Interest_receivable = 13,
    
        [EnumMember(Value = @"interest reinvestment")]
        Interest_reinvestment = 14,
    
        [EnumMember(Value = @"legal fee")]
        Legal_fee = 15,
    
        [EnumMember(Value = @"loan payment")]
        Loan_payment = 16,
    
        [EnumMember(Value = @"long-term capital gain")]
        LongTerm_capital_gain = 17,
    
        [EnumMember(Value = @"long-term capital gain reinvestment")]
        LongTerm_capital_gain_reinvestment = 18,
    
        [EnumMember(Value = @"management fee")]
        Management_fee = 19,
    
        [EnumMember(Value = @"margin expense")]
        Margin_expense = 20,
    
        [EnumMember(Value = @"merger")]
        Merger = 21,
    
        [EnumMember(Value = @"miscellaneous fee")]
        Miscellaneous_fee = 22,
    
        [EnumMember(Value = @"non-qualified dividend")]
        NonQualified_dividend = 23,
    
        [EnumMember(Value = @"non-resident tax")]
        NonResident_tax = 24,
    
        [EnumMember(Value = @"pending credit")]
        Pending_credit = 25,
    
        [EnumMember(Value = @"pending debit")]
        Pending_debit = 26,
    
        [EnumMember(Value = @"qualified dividend")]
        Qualified_dividend = 27,
    
        [EnumMember(Value = @"rebalance")]
        Rebalance = 28,
    
        [EnumMember(Value = @"return of principal")]
        Return_of_principal = 29,
    
        [EnumMember(Value = @"sell")]
        Sell = 30,
    
        [EnumMember(Value = @"sell short")]
        Sell_short = 31,
    
        [EnumMember(Value = @"short-term capital gain")]
        ShortTerm_capital_gain = 32,
    
        [EnumMember(Value = @"short-term capital gain reinvestment")]
        ShortTerm_capital_gain_reinvestment = 33,
    
        [EnumMember(Value = @"spin off")]
        Spin_off = 34,
    
        [EnumMember(Value = @"split")]
        Split = 35,
    
        [EnumMember(Value = @"stock distribution")]
        Stock_distribution = 36,
    
        [EnumMember(Value = @"tax")]
        Tax = 37,
    
        [EnumMember(Value = @"tax withheld")]
        Tax_withheld = 38,
    
        [EnumMember(Value = @"transfer")]
        Transfer = 39,
    
        [EnumMember(Value = @"transfer fee")]
        Transfer_fee = 40,
    
        [EnumMember(Value = @"trust fee")]
        Trust_fee = 41,
    
        [EnumMember(Value = @"unqualified gain")]
        Unqualified_gain = 42,
    
        [EnumMember(Value = @"withdrawal")]
        Withdrawal = 43,
    
}
}