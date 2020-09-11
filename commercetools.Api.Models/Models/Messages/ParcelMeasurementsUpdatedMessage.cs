using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class ParcelMeasurementsUpdatedMessage : Message
    {
        public string DeliveryId { get; set;}
        
        public string ParcelId { get; set;}
        
        public ParcelMeasurements Measurements { get; set;}
    }
}
