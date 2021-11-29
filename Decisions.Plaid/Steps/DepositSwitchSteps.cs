using Decisions.Plaid.Api;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.DepositSwitch.Create;
using Decisions.Plaid.Data.DepositSwitch.Get;
using Decisions.Plaid.Data.DepositSwitch.Token;
using DecisionsFramework.Design.Flow;

namespace Decisions.Plaid.Steps
{
    [AutoRegisterMethodsOnClass(true, "Integration/Plaid/Deposit Switch")]
    public class DepositSwitchSteps
    {
        /// <summary>Create a deposit switch</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Create Deposit Switch")]
        public DepositSwitchCreateResponse DepositSwitchCreate(DepositSwitchCreateRequest body)
        {
            return new PlaidClient(new()).DepositSwitchCreate(body);
        }

        /// <summary>Create a deposit switch token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Create Deposit Switch Token")]
        public DepositSwitchTokenCreateResponse DepositSwitchTokenCreate(DepositSwitchTokenCreateRequest body)
        {
            return new PlaidClient(new()).DepositSwitchTokenCreate(body);
        }

        /// <summary>Retrieve a deposit switch</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Deposit Switch")]
        public DepositSwitchGetResponse DepositSwitchGet(DepositSwitchGetRequest body)
        {
            return new PlaidClient(new()).DepositSwitchGet(body);
        }
    
        /// <summary>Create a deposit switch without using Plaid Exchange</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Create Non-Plaid Deposit Switch")]
        public DepositSwitchAltCreateResponse DepositSwitchAltCreate(DepositSwitchAltCreateRequest body)
        {
            return new PlaidClient(new()).DepositSwitchAltCreate(body);
        }
        
    }
}