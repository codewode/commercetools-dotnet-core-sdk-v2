using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.OrderShipmentStateChangedMessage))]
    public partial interface IOrderShipmentStateChangedMessage : IMessage
    {
        string ShipmentState { get; set;}
        
        ShipmentState ShipmentStateAsEnum { get; }
        
        string OldShipmentState { get; set;}
        
        ShipmentState OldShipmentStateAsEnum { get; }
    }
}