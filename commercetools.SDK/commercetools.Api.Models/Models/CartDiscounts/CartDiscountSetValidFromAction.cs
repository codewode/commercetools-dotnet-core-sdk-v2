using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("setValidFrom")]
    public partial class CartDiscountSetValidFromAction : CartDiscountUpdateAction
    {
        public DateTime ValidFrom { get; set;}
        public CartDiscountSetValidFromAction()
        { 
           this.Action = "setValidFrom";
        }
    }
}