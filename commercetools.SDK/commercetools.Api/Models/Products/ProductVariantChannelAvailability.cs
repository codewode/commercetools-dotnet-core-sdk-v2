using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Products
{
    public partial class ProductVariantChannelAvailability 
    {
        public bool IsOnStock { get; set;}
        
        public long RestockableInDays { get; set;}
        
        public long AvailableQuantity { get; set;}
    }
}