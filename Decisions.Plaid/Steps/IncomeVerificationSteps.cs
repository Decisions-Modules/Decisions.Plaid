using Decisions.Plaid.Api;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.IncomeVerification.Create;
using Decisions.Plaid.Data.IncomeVerification.Documents;
using Decisions.Plaid.Data.IncomeVerification.Paystubs;
using Decisions.Plaid.Data.IncomeVerification.Precheck;
using Decisions.Plaid.Data.IncomeVerification.Refresh;
using Decisions.Plaid.Data.IncomeVerification.Summary;
using Decisions.Plaid.Data.IncomeVerification.Taxforms;
using DecisionsFramework.Design.Flow;

namespace Decisions.Plaid.Steps
{
    [AutoRegisterMethodsOnClass(true, "Integration/Plaid/Income Verification")]
    public class IncomeVerificationSteps
    {
        

        /// <summary>(Deprecated) Create an income verification instance</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [System.Obsolete]
        [AutoRegisterMethod("Create Income Verification")]
        public IncomeVerificationCreateResponse IncomeVerificationCreate(IncomeVerificationCreateRequest body)
        {
            return new PlaidClient(new()).IncomeVerificationCreate(body);
        }
    
        /// <summary>(Deprecated) Retrieve a summary of information derived from income verification</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Income Verification Summary")]
        public IncomeVerificationSummaryGetResponse IncomeVerificationSummaryGet(IncomeVerificationSummaryGetRequest body)
        {
            return new PlaidClient(new()).IncomeVerificationSummaryGet(body);
        }
    
        /// <summary>(Deprecated) Retrieve information from a single paystub used for income verification</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [System.Obsolete]
        //[AutoRegisterMethod("Get Income Verification (Paystub)")]
        [ExcludeMethodOnAutoRegister]
        public IncomeVerificationPaystubGetResponse IncomeVerificationPaystubGet(IncomeVerificationPaystubGetRequest body)
        {
            return new PlaidClient(new()).IncomeVerificationPaystubGet(body);
        }
    
        /// <summary>Retrieve information from the paystubs used for income verification</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Income Verification (Paystubs)")]
        public IncomeVerificationPaystubsGetResponse IncomeVerificationPaystubsGet(IncomeVerificationPaystubsGetRequest body)
        {
            return new PlaidClient(new()).IncomeVerificationPaystubsGet(body);
        }
    
        /// <summary>Download the original documents used for income verification</summary>
        /// <returns>A ZIP file containing source documents(s) used as the basis for income verification.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Original Documentation")]
        public FileResponse IncomeVerificationDocumentsDownload(IncomeVerificationDocumentsDownloadRequest body)
        {
            return new PlaidClient(new()).IncomeVerificationDocumentsDownload(body);
        }
    
        /// <summary>Refresh an income verification</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Refresh Income Verification")]
        public IncomeVerificationRefreshResponse IncomeVerificationRefresh(IncomeVerificationRefreshRequest body)
        {
            return new PlaidClient(new()).IncomeVerificationRefresh(body);
        }
    
        /// <summary>Retrieve information from the tax documents used for income verification</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Income Verification (Tax forms)")]
        public IncomeVerificationTaxformsGetResponse IncomeVerificationTaxformsGet(IncomeVerificationTaxformsGetRequest body)
        {
            return new PlaidClient(new()).IncomeVerificationTaxformsGet(body);
        }
    
        /// <summary>Check a user's eligibility for the income verification product</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Income Verification Precheck")]
        public IncomeVerificationPrecheckResponse IncomeVerificationPrecheck(IncomeVerificationPrecheckRequest body)
        {
            return new PlaidClient(new()).IncomeVerificationPrecheck(body);
        }
      
        
        
        
    }
}