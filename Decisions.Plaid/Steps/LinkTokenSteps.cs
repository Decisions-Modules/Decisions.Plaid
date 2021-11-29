using Decisions.Plaid.Api;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.LinkToken.Create;
using Decisions.Plaid.Data.LinkToken.Get;
using DecisionsFramework.Design.Flow;

namespace Decisions.Plaid.Steps
{
    [AutoRegisterMethodsOnClass(true, "Integration/Plaid/Link Tokens")]
    public class LinkTokenSteps
    {
        

        /// <summary>Create Link Token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Create Link Token")]
        public LinkTokenCreateResponse LinkTokenCreate(LinkTokenCreateRequest body)
        {
            return new PlaidClient(new()).LinkTokenCreate(body);
        }
        
        /// <summary>Get Link Token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Link Token")]
        public LinkTokenGetResponse LinkTokenGet(LinkTokenGetRequest body)
        {
            return new PlaidClient(new()).LinkTokenGet(body);
        }
    
    }
}