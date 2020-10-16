using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderShipmentStateChanged")]
    public partial class OrderShipmentStateChangedMessage : Message
    {
        public string ShipmentState { get; set;}
        
        [JsonIgnore]
        public ShipmentState ShipmentStateAsEnum => this.ShipmentState.GetEnum<ShipmentState>();
        
        public string OldShipmentState { get; set;}
        
        [JsonIgnore]
        public ShipmentState OldShipmentStateAsEnum => this.OldShipmentState.GetEnum<ShipmentState>();
        public OrderShipmentStateChangedMessage()
        { 
           this.Type = "OrderShipmentStateChanged";
        }
    }
}