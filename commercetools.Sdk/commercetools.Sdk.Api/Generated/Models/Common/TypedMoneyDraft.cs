using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [Discriminator(nameof(Type))]
    public abstract partial class TypedMoneyDraft : Money
    {
        public string Type { get; set;}
        
        [JsonIgnore]
        public MoneyType TypeAsEnum => this.Type.GetEnum<MoneyType>();
    }
}