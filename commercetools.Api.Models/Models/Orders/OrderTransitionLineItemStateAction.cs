using commercetools.Api.Models.Orders;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Orders
{
    public class OrderTransitionLineItemStateAction : OrderUpdateAction
    {
        public string LineItemId { get; set;}
        
        public long Quantity { get; set;}
        
        public StateResourceIdentifier FromState { get; set;}
        
        public StateResourceIdentifier ToState { get; set;}
        
        public DateTime ActualTransitionDate { get; set;}
    }
}
