using Decisions.Plaid.Api;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.Webhooks;
using DecisionsFramework.Design.Flow;

namespace Decisions.Plaid.Steps
{
    [AutoRegisterMethodsOnClass(true, "Integration/Plaid/Webhooks")]
    public class WebhookSteps
    {
        /// <summary>Get webhook verification key</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Webhook Verification Key")]
        public WebhookVerificationKeyGetResponse WebhookVerificationKeyGet(WebhookVerificationKeyGetRequest body)
        {
            return new PlaidClient(new()).WebhookVerificationKeyGet(body);
        }

    }
}