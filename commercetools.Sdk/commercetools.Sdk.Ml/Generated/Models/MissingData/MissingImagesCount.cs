using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Ml.Models.MissingData
{
    public partial class MissingImagesCount : IMissingImagesCount
    {
        public long MissingImages { get; set;}
        
        public long Total { get; set;}
    }
}