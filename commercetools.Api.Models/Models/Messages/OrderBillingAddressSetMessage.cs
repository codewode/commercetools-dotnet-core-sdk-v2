using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class OrderBillingAddressSetMessage : Message
    {
        public Address Address { get; set;}
        
        public Address OldAddress { get; set;}
    }
}
