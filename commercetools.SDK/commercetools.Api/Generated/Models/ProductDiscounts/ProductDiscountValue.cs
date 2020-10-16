using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [Discriminator(nameof(Type))]
    public abstract partial class ProductDiscountValue 
    {
        public string Type { get; set;}
    }
}