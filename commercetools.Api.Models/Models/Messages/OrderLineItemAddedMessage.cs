using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class OrderLineItemAddedMessage : Message
    {
        public LineItem LineItem { get; set;}
        
        public long AddedQuantity { get; set;}
    }
}
