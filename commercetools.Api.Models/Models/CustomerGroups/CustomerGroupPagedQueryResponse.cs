using commercetools.Api.Models.CustomerGroups;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.CustomerGroups
{
    public class CustomerGroupPagedQueryResponse 
    {
        public long Limit { get; set;}
        
        public long Count { get; set;}
        
        public long Total { get; set;}
        
        public long Offset { get; set;}
        
        public List<CustomerGroup> Results { get; set;}
    }
}
