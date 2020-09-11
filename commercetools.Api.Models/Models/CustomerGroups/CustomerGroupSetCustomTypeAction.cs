using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.CustomerGroups
{
    public class CustomerGroupSetCustomTypeAction : CustomerGroupUpdateAction
    {
        public TypeResourceIdentifier Type { get; set;}
        
        public FieldContainer Fields { get; set;}
    }
}
