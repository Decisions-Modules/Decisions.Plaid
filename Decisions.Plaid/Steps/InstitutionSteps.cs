using Decisions.Plaid.Api;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.Institutions.Get;
using Decisions.Plaid.Data.Institutions.Search;
using DecisionsFramework.Design.Flow;

namespace Decisions.Plaid.Steps
{
    [AutoRegisterMethodsOnClass(true, "Integration/Plaid/Institutions")]
    public class InstitutionSteps
    {
        
  
        /// <summary>Get details of all supported institutions</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Institutions")]
        public InstitutionsGetResponse InstitutionsGet(InstitutionsGetRequest body)
        {
            return new PlaidClient(new()).InstitutionsGet(body);
        }
    
        /// <summary>Search institutions</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Find Institutions")]
        public InstitutionsSearchResponse InstitutionsSearch(InstitutionsSearchRequest body)
        {
            return new PlaidClient(new()).InstitutionsSearch(body);
        }
    
        /// <summary>Get details of an institution</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Institution by Id")]
        public InstitutionsGetByIdResponse InstitutionsGetById(InstitutionsGetByIdRequest body)
        {
            return new PlaidClient(new()).InstitutionsGetById(body);
        }
        }
}