using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [Discriminator(nameof(Type))]
    public abstract partial class OrderEditResult 
    {
        public string Type { get; set;}
    }
}