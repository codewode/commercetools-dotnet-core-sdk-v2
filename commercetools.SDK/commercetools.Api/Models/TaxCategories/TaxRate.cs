using commercetools.Api.Models.TaxCategories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.TaxCategories
{
    public partial class TaxRate 
    {
        public string Id { get; set;}
        
        public string Name { get; set;}
        
        public double Amount { get; set;}
        
        public bool IncludedInPrice { get; set;}
        
        public string Country { get; set;}
        
        public string State { get; set;}
        
        public List<SubRate> SubRates { get; set;}
    }
}