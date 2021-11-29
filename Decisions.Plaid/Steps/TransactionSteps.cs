using Decisions.Plaid.Api;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.Transactions.Get;
using Decisions.Plaid.Data.Transactions.Recurring;
using Decisions.Plaid.Data.Transactions.Refresh;
using Decisions.Plaid.Data.Transactions.Sync;
using DecisionsFramework.Design.Flow;

namespace Decisions.Plaid.Steps
{
    [AutoRegisterMethodsOnClass(true, "Integration/Plaid/Transactions")]
    public class TransactionSteps
    {

        /// <summary>Get transaction data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Transaction Data")]
        public TransactionsGetResponse TransactionsGet(TransactionsGetRequest body)
        {
            return new PlaidClient(new()).TransactionsGet(body);
        }
        
        /// <summary>Refresh transaction data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Refresh Transaction Data")]
        public TransactionsRefreshResponse TransactionsRefresh(TransactionsRefreshRequest body)
        {
            return new PlaidClient(new()).TransactionsRefresh(body);
        }
        
        /// <summary>Get streams of recurring transactions</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Recurring Transaction Streams")]
        public TransactionsRecurringGetResponse TransactionsRecurringGet(TransactionsRecurringGetRequest body)
        {
            return new PlaidClient(new()).TransactionsRecurringGet(body);
        }
        
        /// <summary>Get incremental transaction updates on an item</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Incremental Transaction Updates on Item")]
        public TransactionsSyncResponse TransactionsSync(TransactionsSyncRequest body)
        {
            return new PlaidClient(new()).TransactionsSync(body);
        }
        }
}