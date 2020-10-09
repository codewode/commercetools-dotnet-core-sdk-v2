using commercetools.Api.Models.Common;
using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DiscriminatorValue("changeName")]
    public partial class ShoppingListChangeNameAction : ShoppingListUpdateAction
    {
        public LocalizedString Name { get; set;}
        public ShoppingListChangeNameAction()
        { 
           this.Action = "changeName";
        }
    }
}