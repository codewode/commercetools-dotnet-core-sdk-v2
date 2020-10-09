using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    public partial class TaxedItemPriceDraft 
    {
        public Money TotalNet { get; set;}
        
        public Money TotalGross { get; set;}
    }
}