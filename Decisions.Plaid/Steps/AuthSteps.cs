using Decisions.Plaid.Api;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.Auth;
using DecisionsFramework.Design.Flow;

namespace Decisions.Plaid.Steps
{
    [AutoRegisterMethodsOnClass(true, "Integration/Plaid/Auth")]
    public class AuthSteps
    {

        /// <summary>Retrieve auth data</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Auth Data")]
        public AuthGetResponse AuthGet(AuthGetRequest body)
        {
            return new PlaidClient(new()).AuthGet(body);
        }
    
    }
}