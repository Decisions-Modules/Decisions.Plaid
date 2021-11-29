using Decisions.Plaid.Api;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.BankTransfer.Balance;
using Decisions.Plaid.Data.BankTransfer.Cancel;
using Decisions.Plaid.Data.BankTransfer.Create;
using Decisions.Plaid.Data.BankTransfer.Events;
using Decisions.Plaid.Data.BankTransfer.Get;
using Decisions.Plaid.Data.BankTransfer.List;
using Decisions.Plaid.Data.BankTransfer.MigrateAccount;
using Decisions.Plaid.Data.BankTransfer.Sweep;
using DecisionsFramework.Design.Flow;

namespace Decisions.Plaid.Steps
{
    [AutoRegisterMethodsOnClass(true, "Integration", "Plaid", "Bank Transfer")]
    public class BankTransferSteps
    {

        /// <summary>Retrieve a bank transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Bank Transfer")]
        public BankTransferGetResponse BankTransferGet(BankTransferGetRequest body)
        {
            return new PlaidClient(new()).BankTransferGet(body);
        }

        /// <summary>Create a bank transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Create Bank Transfer")]
        public BankTransferCreateResponse BankTransferCreate(BankTransferCreateRequest body)
        {
            return new PlaidClient(new()).BankTransferCreate(body);
        }
        
        /// <summary>List bank transfers</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("List Bank Transfers")]
        public BankTransferListResponse BankTransferList(BankTransferListRequest body)
        {
            return new PlaidClient(new()).BankTransferList(body);
        }
    
        /// <summary>Cancel a bank transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Cancel  Bank Transfer")]
        public BankTransferCancelResponse BankTransferCancel(BankTransferCancelRequest body)
        {
            return new PlaidClient(new()).BankTransferCancel(body);
        }
    
        /// <summary>List bank transfer events</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("List  Bank Transfer Events")]
        public BankTransferEventListResponse BankTransferEventList(BankTransferEventListRequest body)
        {
            return new PlaidClient(new()).BankTransferEventList(body);
        }
    
        /// <summary>Sync bank transfer events</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Sync Bank Transfer Events")]
        public BankTransferEventSyncResponse BankTransferEventSync(BankTransferEventSyncRequest body)
        {
            return new PlaidClient(new()).BankTransferEventSync(body);
        }
        
        /// <summary>Retrieve a sweep</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Sweep", new []{ "Integration","Plaid","Bank Transfer","Sweeps"})]
        public BankTransferSweepGetResponse BankTransferSweepGet(BankTransferSweepGetRequest body)
        {
            return new PlaidClient(new()).BankTransferSweepGet(body);
        }
        
        /// <summary>List sweeps</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("List Sweeps", new []{ "Integration","Plaid","Bank Transfer","Sweeps"})]
        public BankTransferSweepListResponse BankTransferSweepList(BankTransferSweepListRequest body)
        {
            return new PlaidClient(new()).BankTransferSweepList(body);
        }
        
        /// <summary>Get balance of your Bank Transfer account</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Bank Transfer Balance")]
        public BankTransferBalanceGetResponse BankTransferBalanceGet(BankTransferBalanceGetRequest body)
        {
            return new PlaidClient(new()).BankTransferBalanceGet(body);
        }
        
        /// <summary>Migrate account into Bank Transfers</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Migrade Account into Bank Transfers")]
        public BankTransferMigrateAccountResponse BankTransferMigrateAccount(BankTransferMigrateAccountRequest body)
        {
            return new PlaidClient(new()).BankTransferMigrateAccount(body);
        }

    }
}