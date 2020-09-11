using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Carts
{
    public class LineItemDraft 
    {
        public string ProductId { get; set;}
        
        public long VariantId { get; set;}
        
        public string Sku { get; set;}
        
        public long Quantity { get; set;}
        
        public ChannelResourceIdentifier SupplyChannel { get; set;}
        
        public ChannelResourceIdentifier DistributionChannel { get; set;}
        
        public ExternalTaxRateDraft ExternalTaxRate { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        
        public Money ExternalPrice { get; set;}
        
        public ExternalLineItemTotalPrice ExternalTotalPrice { get; set;}
        
        public ItemShippingDetailsDraft ShippingDetails { get; set;}
    }
}
