using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ParcelRemovedFromDelivery")]
    public partial class ParcelRemovedFromDeliveryMessagePayload : MessagePayload
    {
        public string DeliveryId { get; set;}
        
        public Parcel Parcel { get; set;}
        public ParcelRemovedFromDeliveryMessagePayload()
        { 
           this.Type = "ParcelRemovedFromDelivery";
        }
    }
}