using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Common
{
    public class Asset 
    {
        public string Id { get; set;}
        
        public List<AssetSource> Sources { get; set;}
        
        public LocalizedString Name { get; set;}
        
        public LocalizedString Description { get; set;}
        
        public List<string> Tags { get; set;}
        
        public CustomFields Custom { get; set;}
        
        public string Key { get; set;}
    }
}
