using Decisions.Plaid.Api;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.Employees;
using DecisionsFramework.Design.Flow;

namespace Decisions.Plaid.Steps
{
    
    [AutoRegisterMethodsOnClass(true, "Integration/Plaid/Employment Verification")]
    public class EmploymentVerificationSteps
    {

        /// <summary>Retrieve a summary of an individual's employment information.</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Employment Verification")]
        public EmploymentVerificationGetResponse EmploymentVerificationGet(EmploymentVerificationGetRequest body)
        {
            return new PlaidClient(new()).EmploymentVerificationGet(body);
        }
        
    }
}