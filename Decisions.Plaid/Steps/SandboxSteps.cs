using Decisions.Plaid.Api;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.Sandbox;
using DecisionsFramework.Design.Flow;

namespace Decisions.Plaid.Steps
{
    [AutoRegisterMethodsOnClass(true, "Integration/Plaid/Sandbox")]
    public class SandboxSteps
    {
        
        /// <summary>Create a test Item and processor token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Create Test Item and Processor Token")]
        public SandboxProcessorTokenCreateResponse SandboxProcessorTokenCreate(SandboxProcessorTokenCreateRequest body)
        {
            return new PlaidClient(new()).SandboxProcessorTokenCreate(body);
        }
        
        /// <summary>Create a test Item</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Create Test Item")]
        public SandboxPublicTokenCreateResponse SandboxPublicTokenCreate(SandboxPublicTokenCreateRequest body)
        {
            return new PlaidClient(new()).SandboxPublicTokenCreate(body);
        }
        
        /// <summary>Fire a test webhook</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Fire Test Webhook")]
        public SandboxItemFireWebhookResponse SandboxItemFireWebhook(SandboxItemFireWebhookRequest body)
        {
            return new PlaidClient(new()).SandboxItemFireWebhook(body);
        }
        
        /// <summary>Force a Sandbox Item into an error state</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Force Sandbox Item into Error State")]
        public SandboxItemResetLoginResponse SandboxItemResetLogin(SandboxItemResetLoginRequest body)
        {
            return new PlaidClient(new()).SandboxItemResetLogin(body);
        }
        
        /// <summary>Set verification status for Sandbox account</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Set Verification Status for Sandbox Account")]
        public SandboxItemSetVerificationStatusResponse SandboxItemSetVerificationStatus(SandboxItemSetVerificationStatusRequest body)
        {
            return new PlaidClient(new()).SandboxItemSetVerificationStatus(body);
        }
        
        /// <summary>Simulate a bank transfer event in Sandbox</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Simulate Bank Transfer Event in Sandbox")]
        public SandboxBankTransferSimulateResponse SandboxBankTransferSimulate(SandboxBankTransferSimulateRequest body)
        {
            return new PlaidClient(new()).SandboxBankTransferSimulate(body);
        }
        
        /// <summary>Simulate a transfer event in Sandbox</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Simulate Transfer Event in Sandbox")]
        public SandboxTransferSimulateResponse SandboxTransferSimulate(SandboxTransferSimulateRequest body)
        {
            return new PlaidClient(new()).SandboxTransferSimulate(body);
        }
      
        /// <summary>Manually fire a Bank Transfer webhook</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Manually Fire Bank Transfer Webhook")]
        public SandboxBankTransferFireWebhookResponse SandboxBankTransferFireWebhook(SandboxBankTransferFireWebhookRequest body)
        {
            return new PlaidClient(new()).SandboxBankTransferFireWebhook(body);
        }
        
        /// <summary>Manually fire an Income webhook</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Manually Fire Income Webhook")]
        public SandboxIncomeFireWebhookResponse SandboxIncomeFireWebhook(SandboxIncomeFireWebhookRequest body)
        {
            return new PlaidClient(new()).SandboxIncomeFireWebhook(body);
        }
        
        /// <summary>Save the selected accounts when connecting to the Platypus Oauth institution</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Save Selected Accounts for Platypus OAuth")]
        public SandboxOauthSelectAccountsResponse SandboxOauthSelectAccounts(SandboxOauthSelectAccountsRequest body)
        {
            return new PlaidClient(new()).SandboxOauthSelectAccounts(body);
        }
            
        
    }
}