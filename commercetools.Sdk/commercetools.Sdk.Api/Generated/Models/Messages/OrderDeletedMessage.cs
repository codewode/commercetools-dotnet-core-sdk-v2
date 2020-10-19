using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderDeleted")]
    public partial class OrderDeletedMessage : Message
    {
        public Order Order { get; set;}
        public OrderDeletedMessage()
        { 
           this.Type = "OrderDeleted";
        }
    }
}