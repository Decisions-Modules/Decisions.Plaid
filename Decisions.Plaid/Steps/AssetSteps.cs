using Decisions.Plaid.Api;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.AssetReports;
using Decisions.Plaid.Data.AssetReports.Audit;
using Decisions.Plaid.Data.AssetReports.Create;
using Decisions.Plaid.Data.AssetReports.Filter;
using Decisions.Plaid.Data.AssetReports.Refresh;
using Decisions.Plaid.Data.AssetReports.Remove;
using DecisionsFramework.Design.Flow;

namespace Decisions.Plaid.Steps
{
    [AutoRegisterMethodsOnClass(true, "Integration/Plaid/Assets")]
    public class AssetSteps
    {
        /// <summary>Create an Asset Report</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Create Asset Report")]
        public AssetReportCreateResponse AssetReportCreate(AssetReportCreateRequest body)
        {
            return new PlaidClient(new()).AssetReportCreate(body);
        }
        
        /// <summary>Refresh an Asset Report</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Refresh Asset Report")]
        public AssetReportRefreshResponse AssetReportRefresh(AssetReportRefreshRequest body)
        {
            return new PlaidClient(new()).AssetReportRefresh(body);
        }
        
        /// <summary>Delete an Asset Report</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Remove Asset Report")]
        public AssetReportRemoveResponse AssetReportRemove(AssetReportRemoveRequest body)
        {
            return new PlaidClient(new()).AssetReportRemove(body);
        }
    
        /// <summary>Filter Asset Report</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Filter Asset Report")]
        public AssetReportFilterResponse AssetReportFilter(AssetReportFilterRequest body)
        {
            return new PlaidClient(new()).AssetReportFilter(body);
        }

        /// <summary>Retrieve an Asset Report</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Asset Report")]
        public AssetReportGetResponse AssetReportGet(AssetReportGetRequest body)
        {
            return new PlaidClient(new()).AssetReportGet(body);
        }

        /// <summary>Retrieve a PDF Asset Report</summary>
        /// <returns>A PDF of the Asset Report</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Asset Report PDF")]
        public FileResponse AssetReportPdfGet(AssetReportPDFGetRequest body)
        {
            return new PlaidClient(new()).AssetReportPdfGet(body);
        }
        
        /// <summary>Create Asset Report Audit Copy</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Create Asset Report Audit Copy", new []{ "Integration","Plaid","Assets","Audit"})]
        public AssetReportAuditCopyCreateResponse AssetReportAuditCopyCreate(AssetReportAuditCopyCreateRequest body)
        {
            return new PlaidClient(new()).AssetReportAuditCopyCreate(body);
        }
        
        /// <summary>Remove Asset Report Audit Copy</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Remove Asset Report Audit Copy", new []{ "Integration","Assets","Audit"})]
        public AssetReportAuditCopyRemoveResponse AssetReportAuditCopyRemove(AssetReportAuditCopyRemoveRequest body)
        {
            return new PlaidClient(new()).AssetReportAuditCopyRemove(body);
        }

        /// <summary>Retrieve an Asset Report Audit Copy</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Asset Report Audit Copy", new []{ "Integration","Assets","Audit"})]
        public AssetReportGetResponse AssetReportAuditCopyGet(AssetReportAuditCopyGetRequest body)
        {
            return new PlaidClient(new()).AssetReportAuditCopyGet(body);
        }

    }
}