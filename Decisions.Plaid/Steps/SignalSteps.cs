using Decisions.Plaid.Api;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.Signal.DecisionReport;
using Decisions.Plaid.Data.Signal.Evaluate;
using Decisions.Plaid.Data.Signal.ReturnReport;
using DecisionsFramework.Design.Flow;

namespace Decisions.Plaid.Steps
{
    [AutoRegisterMethodsOnClass(true, "Integration/Plaid/Signal")]
    public class SignalSteps
    {
        

        /// <summary>Evaluate a planned ACH transaction</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Evaluate Planned ACH Transaction")]
        public SignalEvaluateResponse SignalEvaluate(SignalEvaluateRequest body)
        {
            return new PlaidClient(new()).SignalEvaluate(body);
        }
        
        /// <summary>Report whether you initiated an ACH transaction</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Report ACH Transaction Initiation")]
        public SignalDecisionReportResponse SignalDecisionReport(SignalDecisionReportRequest body)
        {
            return new PlaidClient(new()).SignalDecisionReport(body);
        }
        
        /// <summary>Report a return for an ACH transaction</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Report ACH Transaction Return")]
        public SignalReturnReportResponse SignalReturnReport(SignalReturnReportRequest body)
        {
            return new PlaidClient(new()).SignalReturnReport(body);
        }
        }
}