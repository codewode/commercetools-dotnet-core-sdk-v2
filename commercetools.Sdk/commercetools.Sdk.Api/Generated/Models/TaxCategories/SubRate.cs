using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.TaxCategories
{
    public partial class SubRate 
    {
        public string Name { get; set;}
        
        public double Amount { get; set;}
    }
}