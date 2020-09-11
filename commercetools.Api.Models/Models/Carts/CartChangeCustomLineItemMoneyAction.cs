using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    public class CartChangeCustomLineItemMoneyAction : CartUpdateAction
    {
        public string CustomLineItemId { get; set;}
        
        public Money Money { get; set;}
    }
}
