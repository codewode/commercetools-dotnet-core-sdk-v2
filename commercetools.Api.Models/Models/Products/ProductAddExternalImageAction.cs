using commercetools.Api.Models.Common;
using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Products
{
    public class ProductAddExternalImageAction : ProductUpdateAction
    {
        public long VariantId { get; set;}
        
        public string Sku { get; set;}
        
        public Image Image { get; set;}
        
        public bool Staged { get; set;}
    }
}
