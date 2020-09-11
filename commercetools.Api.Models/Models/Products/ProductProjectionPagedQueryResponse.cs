using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Products
{
    public class ProductProjectionPagedQueryResponse 
    {
        public long Limit { get; set;}
        
        public long Count { get; set;}
        
        public long Total { get; set;}
        
        public long Offset { get; set;}
        
        public List<ProductProjection> Results { get; set;}
    }
}
