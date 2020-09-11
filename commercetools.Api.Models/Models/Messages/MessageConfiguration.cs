using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class MessageConfiguration 
    {
        public bool Enabled { get; set;}
        
        public int DeleteDaysAfterCreation { get; set;}
    }
}
