using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Reviews
{
    public class ReviewSetRatingAction : ReviewUpdateAction
    {
        public int Rating { get; set;}
    }
}
