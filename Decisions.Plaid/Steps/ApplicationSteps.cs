using Decisions.Plaid.Api;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.Applications;
using Decisions.Plaid.Data.Items.Application;
using DecisionsFramework.Design.Flow;

namespace Decisions.Plaid.Steps
{
    [AutoRegisterMethodsOnClass(true, "Integration/Plaid/Applications")]
    public class ApplicationSteps
    {
        
        /// <summary>List a user’s connected applications</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("List Applications")]
        public ItemApplicationListResponse ItemApplicationList(ItemApplicationListRequest body)
        {
            return new PlaidClient(new()).ItemApplicationList(body);
        }

        /// <summary>Update the scopes of access for a particular application</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Update Application Scopes")]
        public ItemApplicationScopesUpdateResponse ItemApplicationScopesUpdate(ItemApplicationScopesUpdateRequest body)
        {
            return new PlaidClient(new()).ItemApplicationScopesUpdate(body);
        }
        
        /// <summary>Retrieve information about a Plaid application</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Application")]
        public ApplicationGetResponse ApplicationGet(ApplicationGetRequest body)
        {
            return new PlaidClient(new()).ApplicationGet(body);
        }
    
    }
}