using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class OrderSetLineItemShippingDetailsAction : OrderUpdateAction
    {
        public string LineItemId { get; set;}
        
        public ItemShippingDetailsDraft ShippingDetails { get; set;}
    }
}
