using commercetools.Api.Models.Common;
using commercetools.Api.Models.TaxCategorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.TaxCategorys
{
    [DiscriminatorValue("tax-category")]
    public partial class TaxCategoryReference : Reference
    {
        public TaxCategory Obj { get; set;}
        public TaxCategoryReference()
        { 
           this.TypeId = "tax-category";
        }
    }
}