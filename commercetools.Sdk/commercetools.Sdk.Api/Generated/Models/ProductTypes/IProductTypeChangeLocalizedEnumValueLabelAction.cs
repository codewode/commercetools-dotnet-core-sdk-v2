using commercetools.Api.Models.ProductTypes;
using Attribute = commercetools.Api.Models.Products.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeLocalizedEnumValueLabelAction))]
    public partial interface IProductTypeChangeLocalizedEnumValueLabelAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set;}
        
        IAttributeLocalizedEnumValue NewValue { get; set;}
    }
}