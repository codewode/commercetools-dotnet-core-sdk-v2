using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ReturnInfoAdded")]
    public partial class OrderReturnInfoAddedMessage : Message
    {
        public ReturnInfo ReturnInfo { get; set;}
        public OrderReturnInfoAddedMessage()
        { 
           this.Type = "ReturnInfoAdded";
        }
    }
}