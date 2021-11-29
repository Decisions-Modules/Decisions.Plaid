using Decisions.Plaid.Api;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.Transfers.Authorization;
using Decisions.Plaid.Data.Transfers.Cancel;
using Decisions.Plaid.Data.Transfers.Create;
using Decisions.Plaid.Data.Transfers.EventList;
using Decisions.Plaid.Data.Transfers.Events;
using Decisions.Plaid.Data.Transfers.Get;
using Decisions.Plaid.Data.Transfers.List;
using DecisionsFramework.Design.Flow;

namespace Decisions.Plaid.Steps
{
    [AutoRegisterMethodsOnClass(true, "Integration/Plaid/Transfers")]
    public class TransferSteps
    {
        

        /// <summary>Retrieve a transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Transfer")]
        public TransferGetResponse TransferGet(TransferGetRequest body)
        {
            return new PlaidClient(new()).TransferGet(body);
        }
        
        /// <summary>Create a transfer authorization</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Create Transfer Authorization")]
        public TransferAuthorizationCreateResponse TransferAuthorizationCreate(TransferAuthorizationCreateRequest body)
        {
            return new PlaidClient(new()).TransferAuthorizationCreate(body);
        }
        
        /// <summary>Create a transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Create Transfer")]
        public TransferCreateResponse TransferCreate(TransferCreateRequest body)
        {
            return new PlaidClient(new()).TransferCreate(body);
        }
        
        /// <summary>List transfers</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("List Transfers")]
        public TransferListResponse TransferList(TransferListRequest body)
        {
            return new PlaidClient(new()).TransferList(body);
        }
        
        /// <summary>Cancel a transfer</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Cancel Transfer")]
        public TransferCancelResponse TransferCancel(TransferCancelRequest body)
        {
            return new PlaidClient(new()).TransferCancel(body);
        }
        
        /// <summary>List transfer events</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("List Transfer Events")]
        public TransferEventListResponse TransferEventList(TransferEventListRequest body)
        {
            return new PlaidClient(new()).TransferEventList(body);
        }
    

        /// <summary>Sync transfer events</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Sync Transfer Events")]
        public TransferEventSyncResponse TransferEventSync(TransferEventSyncRequest body)
        {
            return new PlaidClient(new()).TransferEventSync(body);
        }


    }
}