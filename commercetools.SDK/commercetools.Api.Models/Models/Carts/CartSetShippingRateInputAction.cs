using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setShippingRateInput")]
    public partial class CartSetShippingRateInputAction : CartUpdateAction
    {
        public ShippingRateInputDraft ShippingRateInput { get; set;}
        public CartSetShippingRateInputAction()
        { 
           this.Action = "setShippingRateInput";
        }
    }
}