using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Common
{
    public class HighPrecisionMoney : TypedMoney
    {
        public long PreciseAmount { get; set;}
    }
}
