using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    public partial class DiscountedPrice 
    {
        public Money Value { get; set;}
        
        public ProductDiscountReference Discount { get; set;}
    }
}