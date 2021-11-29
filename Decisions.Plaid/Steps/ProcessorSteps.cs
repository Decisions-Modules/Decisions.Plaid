using Decisions.Plaid.Api;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.Processors;
using Decisions.Plaid.Data.Processors.Auth;
using Decisions.Plaid.Data.Processors.Balance;
using Decisions.Plaid.Data.Processors.Create;
using Decisions.Plaid.Data.Processors.Identity;
using Decisions.Plaid.Data.Processors.Stripe;
using Decisions.Plaid.Data.Processors.Token;
using DecisionsFramework.Design.Flow;

namespace Decisions.Plaid.Steps
{
    [AutoRegisterMethodsOnClass(true, "Integration/Plaid/Processors")]
    public class ProcessorSteps
    {
        /// <summary>Retrieve Auth data</summary>
        /// <returns>success</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Auth Data")]
        public ProcessorAuthGetResponse ProcessorAuthGet(ProcessorAuthGetRequest body)
        {
            return new PlaidClient(new()).ProcessorAuthGet(body);
        }
        
        /// <summary>Create a bank transfer as a processor</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Create Bank Transfer as Processor")]
        public ProcessorBankTransferCreateResponse ProcessorBankTransferCreate(ProcessorBankTransferCreateRequest body)
        {
            return new PlaidClient(new()).ProcessorBankTransferCreate(body);
        }
        
        /// <summary>Retrieve Identity data</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Retrieve Identity Data")]
        public ProcessorIdentityGetResponse ProcessorIdentityGet(ProcessorIdentityGetRequest body)
        {
            return new PlaidClient(new()).ProcessorIdentityGet(body);
        }
        
        /// <summary>Retrieve Balance data</summary>
        /// <param name="body">The `/processor/balance/get` endpoint returns the real-time balance for the account associated with a given `processor_token`.
        /// <br/>
        /// <br/>The current balance is the total amount of funds in the account. The available balance is the current balance less any outstanding holds or debits that have not yet posted to the account.
        /// <br/>
        /// <br/>Note that not all institutions calculate the available balance. In the event that available balance is unavailable from the institution, Plaid will return an available balance value of `null`.</param>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Balance Data")]
        public ProcessorBalanceGetResponse ProcessorBalanceGet(ProcessorBalanceGetRequest body)
        {
            return new PlaidClient(new()).ProcessorBalanceGet(body);
        }
        
        /// <summary>Create processor token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Create Processor Token")]
        public ProcessorTokenCreateResponse ProcessorTokenCreate(ProcessorTokenCreateRequest body)
        {
            return new PlaidClient(new()).ProcessorTokenCreate(body);
        }
        
        /// <summary>Create Stripe bank account token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Create Stripe Bank Account Token")]
        public ProcessorStripeBankAccountTokenCreateResponse ProcessorStripeBankAccountTokenCreate(ProcessorStripeBankAccountTokenCreateRequest body)
        {
            return new PlaidClient(new()).ProcessorStripeBankAccountTokenCreate(body);
        }
        
        /// <summary>Create Apex bank account token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Create Apex Bank Account Token")]
        public ProcessorTokenCreateResponse ProcessorApexProcessorTokenCreate(ProcessorApexProcessorTokenCreateRequest body)
        {
            return new PlaidClient(new()).ProcessorApexProcessorTokenCreate(body);
        }
            
        
        
    }
}