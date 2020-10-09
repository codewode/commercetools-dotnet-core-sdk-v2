using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    public partial class AttributeLocalizedEnumValue 
    {
        public string Key { get; set;}
        
        public LocalizedString Label { get; set;}
    }
}