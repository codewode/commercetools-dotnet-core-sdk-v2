using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Carts
{
    public partial class ItemShippingTarget 
    {
        public string AddressKey { get; set;}
        
        public double Quantity { get; set;}
    }
}