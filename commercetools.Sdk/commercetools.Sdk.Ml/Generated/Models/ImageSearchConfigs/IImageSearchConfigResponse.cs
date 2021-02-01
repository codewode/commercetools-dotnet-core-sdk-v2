using commercetools.Ml.Models.ImageSearchConfigs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.ImageSearchConfigs
{
    [DeserializeAs(typeof(commercetools.Ml.Models.ImageSearchConfigs.ImageSearchConfigResponse))]
    public partial interface IImageSearchConfigResponse 
    {
        IImageSearchConfigStatus Status { get; set;}
        
        DateTime LastModifiedAt { get; set;}
    }
}