using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class OrderSetDeliveryAddressAction : OrderUpdateAction
    {
        public string DeliveryId { get; set;}
        
        public Address Address { get; set;}
    }
}
