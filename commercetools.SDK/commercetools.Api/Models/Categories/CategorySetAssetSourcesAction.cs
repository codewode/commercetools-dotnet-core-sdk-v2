using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DiscriminatorValue("setAssetSources")]
    public partial class CategorySetAssetSourcesAction : CategoryUpdateAction
    {
        public string AssetId { get; set;}
        
        public string AssetKey { get; set;}
        
        public List<AssetSource> Sources { get; set;}
        public CategorySetAssetSourcesAction()
        { 
           this.Action = "setAssetSources";
        }
    }
}