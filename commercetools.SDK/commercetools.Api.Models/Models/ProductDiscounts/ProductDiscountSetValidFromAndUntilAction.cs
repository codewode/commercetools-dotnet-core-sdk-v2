using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DiscriminatorValue("setValidFromAndUntil")]
    public partial class ProductDiscountSetValidFromAndUntilAction : ProductDiscountUpdateAction
    {
        public DateTime ValidFrom { get; set;}
        
        public DateTime ValidUntil { get; set;}
        public ProductDiscountSetValidFromAndUntilAction()
        { 
           this.Action = "setValidFromAndUntil";
        }
    }
}