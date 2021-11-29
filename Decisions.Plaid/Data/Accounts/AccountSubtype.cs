using System.Runtime.Serialization;
using DecisionsFramework.Design.ConfigurationStorage.Attributes;

namespace Decisions.Plaid.Data.Accounts
{
    /// <summary>See the [Account type schema](https://plaid.com/docs/api/accounts/#account-type-schema) for a full listing of account types and corresponding subtypes.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.5.2.0 (Newtonsoft.Json v12.0.0.0)")]
    [DataContract]
    public enum AccountSubtype
    {
        [EnumMember(Value = @"401a")]
        _401a = 0,
    
        [EnumMember(Value = @"401k")]
        _401k = 1,
    
        [EnumMember(Value = @"403B")]
        _403B = 2,
    
        [EnumMember(Value = @"457b")]
        _457b = 3,
    
        [EnumMember(Value = @"529")]
        _529 = 4,
    
        [EnumMember(Value = @"brokerage")]
        Brokerage = 5,
    
        [EnumMember(Value = @"cash isa")]
        Cash_isa = 6,
    
        [EnumMember(Value = @"education savings account")]
        Education_savings_account = 7,
    
        [EnumMember(Value = @"ebt")]
        Ebt = 8,
    
        [EnumMember(Value = @"fixed annuity")]
        Fixed_annuity = 9,
    
        [EnumMember(Value = @"gic")]
        Gic = 10,
    
        [EnumMember(Value = @"health reimbursement arrangement")]
        Health_reimbursement_arrangement = 11,
    
        [EnumMember(Value = @"hsa")]
        Hsa = 12,
    
        [EnumMember(Value = @"isa")]
        Isa = 13,
    
        [EnumMember(Value = @"ira")]
        Ira = 14,
    
        [EnumMember(Value = @"lif")]
        Lif = 15,
    
        [EnumMember(Value = @"life insurance")]
        Life_insurance = 16,
    
        [EnumMember(Value = @"lira")]
        Lira = 17,
    
        [EnumMember(Value = @"lrif")]
        Lrif = 18,
    
        [EnumMember(Value = @"lrsp")]
        Lrsp = 19,
    
        [EnumMember(Value = @"non-taxable brokerage account")]
        NonTaxable_brokerage_account = 20,
    
        [EnumMember(Value = @"other")]
        Other = 21,
    
        [EnumMember(Value = @"other insurance")]
        Other_insurance = 22,
    
        [EnumMember(Value = @"other annuity")]
        Other_annuity = 23,
    
        [EnumMember(Value = @"prif")]
        Prif = 24,
    
        [EnumMember(Value = @"rdsp")]
        Rdsp = 25,
    
        [EnumMember(Value = @"resp")]
        Resp = 26,
    
        [EnumMember(Value = @"rlif")]
        Rlif = 27,
    
        [EnumMember(Value = @"rrif")]
        Rrif = 28,
    
        [EnumMember(Value = @"pension")]
        Pension = 29,
    
        [EnumMember(Value = @"profit sharing plan")]
        Profit_sharing_plan = 30,
    
        [EnumMember(Value = @"retirement")]
        Retirement = 31,
    
        [EnumMember(Value = @"roth")]
        Roth = 32,
    
        [EnumMember(Value = @"roth 401k")]
        Roth_401k = 33,
    
        [EnumMember(Value = @"rrsp")]
        Rrsp = 34,
    
        [EnumMember(Value = @"sep ira")]
        Sep_ira = 35,
    
        [EnumMember(Value = @"simple ira")]
        Simple_ira = 36,
    
        [EnumMember(Value = @"sipp")]
        Sipp = 37,
    
        [EnumMember(Value = @"stock plan")]
        Stock_plan = 38,
    
        [EnumMember(Value = @"thrift savings plan")]
        Thrift_savings_plan = 39,
    
        [EnumMember(Value = @"tfsa")]
        Tfsa = 40,
    
        [EnumMember(Value = @"trust")]
        Trust = 41,
    
        [EnumMember(Value = @"ugma")]
        Ugma = 42,
    
        [EnumMember(Value = @"utma")]
        Utma = 43,
    
        [EnumMember(Value = @"variable annuity")]
        Variable_annuity = 44,
    
        [EnumMember(Value = @"credit card")]
        Credit_card = 45,
    
        [EnumMember(Value = @"paypal")]
        Paypal = 46,
    
        [EnumMember(Value = @"cd")]
        Cd = 47,
    
        [EnumMember(Value = @"checking")]
        Checking = 48,
    
        [EnumMember(Value = @"savings")]
        Savings = 49,
    
        [EnumMember(Value = @"money market")]
        Money_market = 50,
    
        [EnumMember(Value = @"prepaid")]
        Prepaid = 51,
    
        [EnumMember(Value = @"auto")]
        Auto = 52,
    
        [EnumMember(Value = @"business")]
        Business = 53,
    
        [EnumMember(Value = @"commercial")]
        Commercial = 54,
    
        [EnumMember(Value = @"construction")]
        Construction = 55,
    
        [EnumMember(Value = @"consumer")]
        Consumer = 56,
    
        [EnumMember(Value = @"home equity")]
        Home_equity = 57,
    
        [EnumMember(Value = @"loan")]
        Loan = 58,
    
        [EnumMember(Value = @"mortgage")]
        Mortgage = 59,
    
        [EnumMember(Value = @"overdraft")]
        Overdraft = 60,
    
        [EnumMember(Value = @"line of credit")]
        Line_of_credit = 61,
    
        [EnumMember(Value = @"student")]
        Student = 62,
    
        [EnumMember(Value = @"cash management")]
        Cash_management = 63,
    
        [EnumMember(Value = @"keogh")]
        Keogh = 64,
    
        [EnumMember(Value = @"mutual fund")]
        Mutual_fund = 65,
    
        [EnumMember(Value = @"recurring")]
        Recurring = 66,
    
        [EnumMember(Value = @"rewards")]
        Rewards = 67,
    
        [EnumMember(Value = @"safe deposit")]
        Safe_deposit = 68,
    
        [EnumMember(Value = @"sarsep")]
        Sarsep = 69,
    
        [EnumMember(Value = @"payroll")]
        Payroll = 70,
    
    }
}