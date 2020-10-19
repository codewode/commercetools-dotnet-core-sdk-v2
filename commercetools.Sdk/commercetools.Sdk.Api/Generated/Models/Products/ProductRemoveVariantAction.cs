using commercetools.Api.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DiscriminatorValue("removeVariant")]
    public partial class ProductRemoveVariantAction : ProductUpdateAction
    {
        public long Id { get; set;}
        
        public string Sku { get; set;}
        
        public bool Staged { get; set;}
        public ProductRemoveVariantAction()
        { 
           this.Action = "removeVariant";
        }
    }
}