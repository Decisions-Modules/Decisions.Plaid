using Decisions.Plaid.Api;
using DecisionsFramework.Design.Flow;
using Decisions.Plaid.Data.Accounts.Balance;
using Decisions.Plaid.Data.Accounts.Get;
using Decisions.Plaid.Data.Api;

namespace Decisions.Plaid.Steps
{
    [AutoRegisterMethodsOnClass(true, "Integration/Plaid/Accounts")]
    public class AccountSteps
    {
        
        /// <summary>Retrieve accounts</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Accounts")]
        public AccountsGetResponse AccountsGet(AccountsGetRequest body)
        {
            return new PlaidClient(new()).AccountsGet(body);
        }
        
        /// <summary>Retrieve real-time balance data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Accounts Balance")]
        public AccountsGetResponse AccountsBalanceGet(AccountsBalanceGetRequest body)
        {
            return new PlaidClient(new()).AccountsBalanceGet(body);
        }
        
    }
}