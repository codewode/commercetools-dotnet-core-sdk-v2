using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class CustomerDateOfBirthSetMessagePayload : MessagePayload
    {
        public DateTime DateOfBirth { get; set;}
    }
}
