using Decisions.Plaid.Api;
using Decisions.Plaid.Data.Api;
using Decisions.Plaid.Data.PaymentInitiation.Payments;
using Decisions.Plaid.Data.PaymentInitiation.Recipient;
using DecisionsFramework.Design.Flow;

namespace Decisions.Plaid.Steps
{
    [AutoRegisterMethodsOnClass(true, "Integration/Plaid/Payment Initiation")]
    public class PaymentSteps
    {
        
        /// <summary>Create payment recipient</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Create Payment Recipient")]
        public PaymentInitiationRecipientCreateResponse PaymentInitiationRecipientCreate(PaymentInitiationRecipientCreateRequest body)
        {
            return new PlaidClient(new()).PaymentInitiationRecipientCreate(body);
        }
        
        /// <summary>Reverse an existing payment</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Reverse Payment")]
        public PaymentInitiationPaymentReverseResponse PaymentInitiationPaymentReverse(PaymentInitiationPaymentReverseRequest body)
        {
            return new PlaidClient(new()).PaymentInitiationPaymentReverse(body);
        }
        
        /// <summary>Get payment recipient</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Payment Recipient")]
        public PaymentInitiationRecipientGetResponse PaymentInitiationRecipientGet(PaymentInitiationRecipientGetRequest body)
        {
            return new PlaidClient(new()).PaymentInitiationRecipientGet(body);
        }
        
        /// <summary>List payment recipients</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("List Payment Recipients")]
        public PaymentInitiationRecipientListResponse PaymentInitiationRecipientList(PaymentInitiationRecipientListRequest body)
        {
            return new PlaidClient(new()).PaymentInitiationRecipientList(body);
        }
        
        /// <summary>Create a payment</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Create Payment")]
        public PaymentInitiationPaymentCreateResponse PaymentInitiationPaymentCreate(PaymentInitiationPaymentCreateRequest body)
        {
            return new PlaidClient(new()).PaymentInitiationPaymentCreate(body);
        }
        
        /// <summary>Create payment token</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [System.Obsolete]
        [AutoRegisterMethod("Create Payment Token")]
        public PaymentInitiationPaymentTokenCreateResponse CreatePaymentToken(PaymentInitiationPaymentTokenCreateRequest body)
        {
            return new PlaidClient(new()).CreatePaymentToken(body);
        }
    
        /// <summary>Get payment details</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("Get Payment Details")]
        public PaymentInitiationPaymentGetResponse PaymentInitiationPaymentGet(PaymentInitiationPaymentGetRequest body)
        {
            return new PlaidClient(new()).PaymentInitiationPaymentGet(body);
        }
        
        /// <summary>List payments</summary>
        /// <returns>OK</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        [AutoRegisterMethod("List Payments")]
        public PaymentInitiationPaymentListResponse PaymentInitiationPaymentList(PaymentInitiationPaymentListRequest body)
        {
            return new PlaidClient(new()).PaymentInitiationPaymentList(body);
        }
            
        
        
        
    }
}