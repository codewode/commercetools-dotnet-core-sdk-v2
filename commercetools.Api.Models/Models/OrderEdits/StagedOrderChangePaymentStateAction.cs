using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class StagedOrderChangePaymentStateAction : StagedOrderUpdateAction
    {
        public PaymentState PaymentState { get; set;}
    }
}
