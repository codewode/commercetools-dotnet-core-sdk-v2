using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DiscriminatorValue("setParcelItems")]
    public partial class OrderSetParcelItemsAction : OrderUpdateAction
    {
        public string ParcelId { get; set;}
        
        public List<DeliveryItem> Items { get; set;}
        public OrderSetParcelItemsAction()
        { 
           this.Action = "setParcelItems";
        }
    }
}