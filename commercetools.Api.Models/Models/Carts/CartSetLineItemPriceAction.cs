using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    public class CartSetLineItemPriceAction : CartUpdateAction
    {
        public string LineItemId { get; set;}
        
        public Money ExternalPrice { get; set;}
    }
}
