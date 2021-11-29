using Decisions.Plaid.Api;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.Employees.Search;
using DecisionsFramework.Design.Flow;

namespace Decisions.Plaid.Steps
{
    [AutoRegisterMethodsOnClass(true, "Integration/Plaid/Employer")]
    public class EmployerSteps
    {

        /// <summary>Search employer database</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Find Employer")]
        public EmployersSearchResponse EmployersSearch(EmployersSearchRequest body)
        {
            return new PlaidClient(new()).EmployersSearch(body);
        }
    
    }
}