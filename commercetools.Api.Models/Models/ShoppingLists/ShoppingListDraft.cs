using commercetools.Api.Models.Common;
using commercetools.Api.Models.Customers;
using commercetools.Api.Models.ShoppingLists;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.ShoppingLists
{
    public class ShoppingListDraft 
    {
        public CustomFieldsDraft Custom { get; set;}
        
        public CustomerResourceIdentifier Customer { get; set;}
        
        public long DeleteDaysAfterLastModification { get; set;}
        
        public LocalizedString Description { get; set;}
        
        public string Key { get; set;}
        
        public List<ShoppingListLineItemDraft> LineItems { get; set;}
        
        public LocalizedString Name { get; set;}
        
        public LocalizedString Slug { get; set;}
        
        public List<TextLineItemDraft> TextLineItems { get; set;}
        
        public string AnonymousId { get; set;}
    }
}
