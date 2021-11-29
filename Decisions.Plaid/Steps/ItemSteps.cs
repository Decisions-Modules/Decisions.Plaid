using Decisions.Plaid.Api;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.Items.AccessToken;
using Decisions.Plaid.Data.Items.Get;
using Decisions.Plaid.Data.Items.Import;
using Decisions.Plaid.Data.Items.PublicToken;
using Decisions.Plaid.Data.Items.Remove;
using Decisions.Plaid.Data.Webhooks;
using DecisionsFramework.Design.Flow;

namespace Decisions.Plaid.Steps
{
    [AutoRegisterMethodsOnClass(true, "Integration/Plaid/Items")]
    public class ItemSteps
    {
        
        /// <summary>Retrieve an Item</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Item")]
        public ItemGetResponse ItemGet(ItemGetRequest body)
        {
            return new PlaidClient(new()).ItemGet(body);
        }
    
        /// <summary>Remove an Item</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Remove Item")]
        public ItemRemoveResponse ItemRemove(ItemRemoveRequest body)
        {
            return new PlaidClient(new()).ItemRemove(body);
        }
        
        /// <summary>Update Webhook URL</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Update Item Webhook")]
        public ItemWebhookUpdateResponse ItemWebhookUpdate(ItemWebhookUpdateRequest body)
        {
            return new PlaidClient(new()).ItemWebhookUpdate(body);
        }
        
        /// <summary>Invalidate access_token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Invalidate access_token")]
        public ItemAccessTokenInvalidateResponse ItemAccessTokenInvalidate(ItemAccessTokenInvalidateRequest body)
        {
            return new PlaidClient(new()).ItemAccessTokenInvalidate(body);
        }
       
        /// <summary>Exchange public token for an access token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Exchange Public Token For access_token")]
        public ItemPublicTokenExchangeResponse ItemPublicTokenExchange(ItemPublicTokenExchangeRequest body)
        {
            return new PlaidClient(new()).ItemPublicTokenExchange(body);
        }
        
        /// <summary>Create public token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Create Public Token")]
        public ItemPublicTokenCreateResponse ItemCreatePublicToken(ItemPublicTokenCreateRequest body)
        {
            return new PlaidClient(new()).ItemCreatePublicToken(body);
        }
      
        /// <summary>Import Item</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Import Item")]
        public ItemImportResponse ItemImport(ItemImportRequest body)
        {
            return new PlaidClient(new()).ItemImport(body);
        }
        
    }
}