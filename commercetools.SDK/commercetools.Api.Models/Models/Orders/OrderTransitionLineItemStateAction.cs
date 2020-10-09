using commercetools.Api.Models.Orders;
using commercetools.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("transitionLineItemState")]
    public partial class OrderTransitionLineItemStateAction : OrderUpdateAction
    {
        public string LineItemId { get; set;}
        
        public long Quantity { get; set;}
        
        public StateResourceIdentifier FromState { get; set;}
        
        public StateResourceIdentifier ToState { get; set;}
        
        public DateTime ActualTransitionDate { get; set;}
        public OrderTransitionLineItemStateAction()
        { 
           this.Action = "transitionLineItemState";
        }
    }
}