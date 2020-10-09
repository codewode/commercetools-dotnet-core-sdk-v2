using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("InventoryEntryDeleted")]
    public partial class InventoryEntryDeletedMessagePayload : MessagePayload
    {
        public string Sku { get; set;}
        
        public ChannelReference SupplyChannel { get; set;}
        public InventoryEntryDeletedMessagePayload()
        { 
           this.Type = "InventoryEntryDeleted";
        }
    }
}