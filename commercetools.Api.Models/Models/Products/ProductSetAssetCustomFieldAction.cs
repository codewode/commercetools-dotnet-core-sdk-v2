using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Products
{
    public class ProductSetAssetCustomFieldAction : ProductUpdateAction
    {
        public long VariantId { get; set;}
        
        public string Sku { get; set;}
        
        public bool Staged { get; set;}
        
        public string AssetId { get; set;}
        
        public string AssetKey { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
