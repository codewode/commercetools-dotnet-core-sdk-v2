using commercetools.Api.Models.Categorys;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class ProductRemovedFromCategoryMessage : Message
    {
        public CategoryReference Category { get; set;}
        
        public bool Staged { get; set;}
    }
}
