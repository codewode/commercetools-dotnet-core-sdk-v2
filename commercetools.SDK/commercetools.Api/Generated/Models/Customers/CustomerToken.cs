using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Customers
{
    public partial class CustomerToken 
    {
        public string Id { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public string CustomerId { get; set;}
        
        public DateTime ExpiresAt { get; set;}
        
        public string Value { get; set;}
    }
}