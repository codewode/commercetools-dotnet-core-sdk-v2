using commercetools.Api.Models.Inventories;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    [DiscriminatorValue("setCustomType")]
    public partial class InventoryEntrySetCustomTypeAction : InventoryEntryUpdateAction
    {
        public TypeResourceIdentifier Type { get; set;}
        
        public FieldContainer Fields { get; set;}
        public InventoryEntrySetCustomTypeAction()
        { 
           this.Action = "setCustomType";
        }
    }
}