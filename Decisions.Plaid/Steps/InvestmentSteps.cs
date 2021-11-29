using Decisions.Plaid.Api;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.Investments.Holdings;
using Decisions.Plaid.Data.Investments.Transactions;
using DecisionsFramework.Design.Flow;

namespace Decisions.Plaid.Steps
{
    [AutoRegisterMethodsOnClass(true, "Integration/Plaid/Investments")]
    public class InvestmentSteps
    {
        /// <summary>Get Investment holdings</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Investment Holdings")]
        public InvestmentsHoldingsGetResponse InvestmentsHoldingsGet(InvestmentsHoldingsGetRequest body)
        {
            return new PlaidClient(new()).InvestmentsHoldingsGet(body);
        }
    
        /// <summary>Get investment transactions</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Investment Transactions")]
        public InvestmentsTransactionsGetResponse InvestmentsTransactionsGet(InvestmentsTransactionsGetRequest body)
        {
            return new PlaidClient(new()).InvestmentsTransactionsGet(body);
        }
        
    }
}