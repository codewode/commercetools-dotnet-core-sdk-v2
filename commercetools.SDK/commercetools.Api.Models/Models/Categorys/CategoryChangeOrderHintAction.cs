using commercetools.Api.Models.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Categorys
{
    [DiscriminatorValue("changeOrderHint")]
    public partial class CategoryChangeOrderHintAction : CategoryUpdateAction
    {
        public string OrderHint { get; set;}
        public CategoryChangeOrderHintAction()
        { 
           this.Action = "changeOrderHint";
        }
    }
}