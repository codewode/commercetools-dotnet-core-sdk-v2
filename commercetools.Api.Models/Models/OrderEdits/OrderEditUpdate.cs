using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.OrderEdits
{
    public class OrderEditUpdate 
    {
        public long Version { get; set;}
        
        public List<OrderEditUpdateAction> Actions { get; set;}
        
        public bool DryRun { get; set;}
    }
}
