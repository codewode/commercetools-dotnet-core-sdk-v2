using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using commercetools.Api.Client;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Payments;
using commercetools.Base.Client;
using static commercetools.Api.IntegrationTests.GenericFixture;

namespace commercetools.Api.IntegrationTests.Payments
{
    public class PaymentsFixture
    {
        #region DraftBuilds
        public static PaymentDraft DefaultPaymentDraft(PaymentDraft paymentDraft)
        {
            var random = TestingUtility.RandomInt();
            paymentDraft.Key = $"Key_{random}";
            paymentDraft.AmountPlanned = Money.FromDecimal("EUR", 1000);
            return paymentDraft;
        }
        public static PaymentDraft DefaultPaymentDraftWithTransaction(PaymentDraft draft, ITransactionDraft transactionDraft)
        {
            var paymentDraft = DefaultPaymentDraft(draft);
            paymentDraft.Transactions = new List<ITransactionDraft> { transactionDraft };
            return paymentDraft;
        }
        
        #endregion
        
        #region CreateAndDelete

        public static async Task<Payment> CreatePayment(IClient client, PaymentDraft paymentDraft)
        {
            var resource = await client.ApiRoot().WithProjectKey(DefaultProjectKey)
                .Payments()
                .Post(paymentDraft)
                .ExecuteAsync();
            return resource;
        }
        
        public static async Task DeletePayment(IClient client, Payment payment)
        {
            try
            {
                await client.ApiRoot().WithProjectKey(DefaultProjectKey)
                    .Payments()
                    .WithId(payment.Id)
                    .Delete()
                    .WithVersion(payment.Version)
                    .ExecuteAsync();
            }
            catch (Exception)
            {
                // ignored
            }
        }

        #endregion
        
        #region WithPayment

        public static async Task WithPayment( IClient client, Func<PaymentDraft, PaymentDraft> draftAction, Action<Payment> func)
        {
            await With(client, new PaymentDraft(), draftAction, func, CreatePayment, DeletePayment);
        }
        #endregion
    }
}