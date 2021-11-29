using Decisions.Plaid.Api;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.Identity;
using DecisionsFramework.Design.Flow;

namespace Decisions.Plaid.Steps
{
    [AutoRegisterMethodsOnClass(true, "Integration/Plaid/Identity")]
    public class IdentitySteps
    {
        /// <summary>Retrieve identity data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Identity")]
        public IdentityGetResponse IdentityGet(IdentityGetRequest body)
        {
            return new PlaidClient(new()).IdentityGet(body);
        }
        
    }
}