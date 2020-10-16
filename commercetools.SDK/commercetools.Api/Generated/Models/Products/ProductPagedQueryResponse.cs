using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Products
{
    public partial class ProductPagedQueryResponse 
    {
        public long Limit { get; set;}
        
        public long Count { get; set;}
        
        public long Total { get; set;}
        
        public long Offset { get; set;}
        
        public List<Product> Results { get; set;}
    }
}