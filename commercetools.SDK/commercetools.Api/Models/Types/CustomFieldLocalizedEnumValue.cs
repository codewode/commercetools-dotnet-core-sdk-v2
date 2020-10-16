using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Types
{
    public partial class CustomFieldLocalizedEnumValue 
    {
        public string Key { get; set;}
        
        public LocalizedString Label { get; set;}
    }
}