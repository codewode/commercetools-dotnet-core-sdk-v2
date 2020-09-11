using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class StagedOrderSetParcelTrackingDataAction : StagedOrderUpdateAction
    {
        public string ParcelId { get; set;}
        
        public TrackingData TrackingData { get; set;}
    }
}
