using Decisions.Plaid.Api;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.Liabilities.Get;
using DecisionsFramework.Design.Flow;

namespace Decisions.Plaid.Steps
{
    [AutoRegisterMethodsOnClass(true, "Integration/Plaid/Liabilities")]
    public class LiabilitySteps
    {

        /// <summary>Retrieve Liabilities data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Liabilities")]
        public LiabilitiesGetResponse LiabilitiesGet(LiabilitiesGetRequest body)
        {
            return new PlaidClient(new()).LiabilitiesGet(body);
        }
    
        
        
    }
}