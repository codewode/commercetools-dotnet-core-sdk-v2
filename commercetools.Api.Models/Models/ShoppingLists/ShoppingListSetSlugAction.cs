using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ShoppingLists
{
    public class ShoppingListSetSlugAction : ShoppingListUpdateAction
    {
        public LocalizedString Slug { get; set;}
    }
}
