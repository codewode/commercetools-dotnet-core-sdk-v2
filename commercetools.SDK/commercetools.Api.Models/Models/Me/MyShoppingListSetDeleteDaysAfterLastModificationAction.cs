using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setDeleteDaysAfterLastModification")]
    public partial class MyShoppingListSetDeleteDaysAfterLastModificationAction : MyShoppingListUpdateAction
    {
        public long DeleteDaysAfterLastModification { get; set;}
        public MyShoppingListSetDeleteDaysAfterLastModificationAction()
        { 
           this.Action = "setDeleteDaysAfterLastModification";
        }
    }
}