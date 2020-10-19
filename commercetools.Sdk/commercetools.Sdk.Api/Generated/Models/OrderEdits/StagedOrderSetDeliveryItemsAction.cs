using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setDeliveryItems")]
    public partial class StagedOrderSetDeliveryItemsAction : StagedOrderUpdateAction
    {
        public string DeliveryId { get; set;}
        
        public List<DeliveryItem> Items { get; set;}
        public StagedOrderSetDeliveryItemsAction()
        { 
           this.Action = "setDeliveryItems";
        }
    }
}