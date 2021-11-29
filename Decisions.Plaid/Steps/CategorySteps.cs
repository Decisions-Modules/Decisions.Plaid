using Decisions.Plaid.Api;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.Categories;
using DecisionsFramework.Design.Flow;

namespace Decisions.Plaid.Steps
{
    [AutoRegisterMethodsOnClass(true, "Integration/Plaid/Categories")]
    public class CategorySteps
    {
        
        /// <summary>Get Categories</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Categories")]
        public CategoriesGetResponse CategoriesGet(CategoriesGetRequest body)
        {
            return new PlaidClient(new()).CategoriesGet(body);
        }
    
    }
}